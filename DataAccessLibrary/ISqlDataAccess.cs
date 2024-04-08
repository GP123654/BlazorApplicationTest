

//Namespace
namespace DataAccessLibrary
{
    //Interface
    public interface ISqlDataAccess
    {
        /// <summary>
        /// The name of the connection string
        /// </summary>
        string ConnectionStringName { get; set; }

        /// <summary>
        /// Loading/Retrieving data asyncrously from the database using an interface
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<List<T>> LoadData<T, U>(string sql, U parameters);

        /// <summary>
        /// For saving/inserting data asuncrously to the database using an interface
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task SaveData<T>(string sql, T parameters);
    }
}
//----------------------- ooo000 END OF FILE 000ooo -----------------------//