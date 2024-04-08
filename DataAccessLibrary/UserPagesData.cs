
//Imports
using DataAccessLibrary.Models;

//Namespace
namespace DataAccessLibrary
{
    //UserPagesData class that inherits from the IUserPagesData interface
    public class UserPagesData : IUserPagesData
    {
        //Creating a variable for the interface
        private readonly ISqlDataAccess _dataAccess;

        //----------------------------------------------------------------//
        /// <summary>
        /// Constructor that initializes the interface
        /// </summary>
        /// <param name="dataAccess"></param>
        public UserPagesData(ISqlDataAccess dataAccess)
        {
            //
            _dataAccess = dataAccess;
        }

        //----------------------------------------------------------------//
        /// <summary>
        /// Gets the data from the data base and stores it in a list
        /// </summary>
        /// <returns>result</returns>
        public Task<List<UserPagesModel>> GetUserPages()
        {
            //Sql query that gets all the data that will be available
            string sql = "SELECT * FROM UserPageLog WHERE UserID = 100 AND WebPage = 'ViewCase' AND Host = '41.164.25.234' AND MONTH(CreateDate) = 1";
            //Loads the data into UserPagesModel and creates a new instance
            var result = _dataAccess.LoadData<UserPagesModel, dynamic>(sql, new { });
            //Returns the result
            return result;
        }
    }
}
//----------------------- ooo000 END OF FILE 000ooo -----------------------//