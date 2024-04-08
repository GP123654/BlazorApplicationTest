
//Imports
using DataAccessLibrary.Models;
using System.Data;

//Namespace
namespace DataAccessLibrary
{
    //UserData class that inherits from the IUserData interface
    public class UserData : IUserData
    {
        //Creating a variable for the interface
        private readonly ISqlDataAccess _dataAccess;

        //----------------------------------------------------------------//
        /// <summary>
        /// Constructor that initializes the interface
        /// </summary>
        /// <param name="dataAccess"></param>
        public UserData(ISqlDataAccess dataAccess)
        {
            //
            _dataAccess = dataAccess;
        }

        //----------------------------------------------------------------//
        /// <summary>
        /// Gets the data from the data base and stores it in a list
        /// </summary>
        /// <returns>result</returns>
        public Task<List<UserModel>> GetUsers()
        {
            //Sql query that gets all the data that will be available
            string sql = "SELECT * FROM AspNetUsers";
            //Loads the data into UserPagesModel and creates a new instance
            var result = _dataAccess.LoadData<UserModel, dynamic>(sql, new { });
            //Returns the result
            return result;
        }
    }
}
//----------------------- ooo000 END OF FILE 000ooo -----------------------//