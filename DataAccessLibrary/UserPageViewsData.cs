
//Imports
using DataAccessLibrary.Models;

//Namespace
namespace DataAccessLibrary
{
    //UserPageViewsData class that inherits from the IUserPageViewsData interface
    public class UserPageViewsData : IUserPageViewsData
    {
        //Creating a variable for the interface
        private readonly ISqlDataAccess _dataAccess;

        //----------------------------------------------------------------//
        /// <summary>
        /// Constructor that initializes the interface
        /// </summary>
        /// <param name="dataAccess"></param>
        public UserPageViewsData(ISqlDataAccess dataAccess)
        {
            //
            _dataAccess = dataAccess;
        }


        //----------------------------------------------------------------//
        /// <summary>
        /// Gets the data from the data base and stores it in a list
        /// </summary>
        /// <returns>result</returns>
        public Task<List<UserPageViewsModel>> GetSystemUsage()
        {
            //Sql query that gets all the data that will be available
            string sql = "EXEC admin_SystemUsageReport;";
            //Loads the data into UserPagesModel and creates a new instance
            var result = _dataAccess.LoadData<UserPageViewsModel, dynamic>(sql, new { });
            //Returns the result
            return result;
        }


        //----------------------------------------------------------------//
        /// <summary>
        /// Gets the data from the data base and stores it in a list
        /// </summary>
        /// <returns>result</returns>
        public Task<List<UserPageViewsModel>> GetFinalPivotedData()
        {
            //Sql query that gets all the data that will be available
            string sql = "EXEC GregsFinalFinalPivotTableHopefullyForNow;";
            //Loads the data into UserPagesModel and creates a new instance
            var result = _dataAccess.LoadData<UserPageViewsModel, dynamic>(sql, new { });
            //Returns the result
            return result;
        }




        //----------------------------------------------------------------//
        /// <summary>
        /// Gets the data from the data base and stores it in a list
        /// </summary>
        /// <returns>result</returns>
        public Task<List<UserPageViewsModel>> GetDarrensPivotedData()
        {
            //Sql query that gets all the data that will be available
            string sql = "EXEC DarensPivotForBlazor;";
            //Loads the data into UserPagesModel and creates a new instance
            var result = _dataAccess.LoadData<UserPageViewsModel, dynamic>(sql, new { });
            //Returns the result
            return result;
        }



        //----------------------------------------------------------------//
        /// <summary>
        /// Gets the data from the data base and stores it in a list
        /// </summary>
        /// <returns>result</returns>
        public Task<List<UserPageViewsModel>> SelectAllFromPivotedData()
        {
            //Sql query that gets all the data that will be available
            string sql = "select * from GregsSystemPageViewPivot;";
            //Loads the data into UserPagesModel and creates a new instance
            var result = _dataAccess.LoadData<UserPageViewsModel, dynamic>(sql, new { });
            //Returns the result
            return result;
        }



        //----------------------------------------------------------------//
        /// <summary>
        /// Gets the data from the data base and stores it in a list
        /// </summary>
        /// <returns>result</returns>
        public Task<List<UserPageViewsModel>> GetSystemsBeingUsed()
        {
            //Sql query that gets all the data that will be available
            string sql = "EXEC SystemsBeingUsed;";
            //Loads the data into UserPagesModel and creates a new instance
            var result = _dataAccess.LoadData<UserPageViewsModel, dynamic>(sql, new { });
            //Returns the result
            return result;
        }


    }
}
//----------------------- ooo000 END OF FILE 000ooo -----------------------//