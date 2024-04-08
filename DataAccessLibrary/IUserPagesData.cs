

//Imports
using DataAccessLibrary.Models;

//Namespace
namespace DataAccessLibrary
{
    //Interface
    public interface IUserPagesData
    {
        /// <summary>
        /// Gets the data from the database and stores it in a list using an interface
        /// </summary>
        /// <returns>The query result / result of the stored procedure</returns>
        Task<List<UserPagesModel>> GetUserPages();
    }
}
//----------------------- ooo000 END OF FILE 000ooo -----------------------//