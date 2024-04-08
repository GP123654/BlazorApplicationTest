
//Imports
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

//Namespace
namespace DataAccessLibrary
{
    //SqlDataAccess class that inherits from the ISqlDataAccess interface
    public class SqlDataAccess : ISqlDataAccess
    {
        //
        private readonly IConfiguration _config;

        //Initializing the connection string name
        public string ConnectionStringName { get; set; } = "Default";

        //----------------------------------------------------------------//
        /// <summary>
        /// Constructor that initializes the interface
        /// </summary>
        /// <param name="config"></param>
        public SqlDataAccess(IConfiguration config)
        {
            //
            _config = config;
        }

        //----------------------------------------------------------------//
        /// <summary>
        /// Loading/Retrieving data asyncrously from the database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            //getting and saving the connection string into a variable
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            //Creating a connection to the database
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                //Gets the data from the database and stores it
                var data = await connection.QueryAsync<T>(sql, parameters);
                //Saving the data to a list
                return data.ToList();
            }
        }

        //----------------------------------------------------------------//
        /// <summary>
        /// For saving/inserting data asuncrously to the database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task SaveData<T>(string sql, T parameters)
        {
            //getting and saving the connection string into a variable
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            //Creating a connection to the database
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                //Executes the query
                await connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
//----------------------- ooo000 END OF FILE 000ooo -----------------------//