

//Imports
using DataAccessLibrary.Models;

//Namespace
namespace DataAccessLibrary
{
    //Interface
    public interface IUserPageViewsData
    {

        /// <summary>
        /// Gets the data from the database and stores it in a list using an interface
        /// </summary>
        /// <returns>The query result / result of the stored procedure</returns>
        Task<List<UserPageViewsModel>> GetSystemUsage();

        /// <summary>
        /// Gets the data from the database and stores it in a list using an interface
        /// </summary>
        /// <returns>The query result / result of the stored procedure</returns>
        Task<List<UserPageViewsModel>> GetFinalPivotedData();

        /// <summary>
        /// Gets the data from the database and stores it in a list using an interface
        /// </summary>
        /// <returns>The query result / result of the stored procedure</returns>
        Task<List<UserPageViewsModel>> GetDarrensPivotedData();

        /// <summary>
        /// Gets the data from the database and stores it in a list using an interface
        /// </summary>
        /// <returns>The query result / result of the stored procedure</returns>
        Task<List<UserPageViewsModel>> SelectAllFromPivotedData();

        /// <summary>
        /// Gets the data from the database and stores it in a list using an interface
        /// </summary>
        /// <returns>The query result / result of the stored procedure</returns>
        Task<List<UserPageViewsModel>> GetSystemsBeingUsed();
    }
}
//----------------------- ooo000 END OF FILE 000ooo -----------------------//