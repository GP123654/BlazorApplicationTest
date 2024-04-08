

//Namespace
namespace DataAccessLibrary.Models
{
    //Class
    public class UserPagesModel
    {
        /// <summary>
        /// Id for record - primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Stores the UserId from the database
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Stores the WebPage from the database
        /// </summary>
        public string? WebPage { get; set; }

        /// <summary>
        /// Stores the CreateDate from the database
        /// </summary>
        public DateTime? CreateDate { get; set; }

    }
}
//----------------------- ooo000 END OF FILE 000ooo -----------------------//