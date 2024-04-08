using Microsoft.AspNetCore.Mvc;
using Syncfusion.Blazor.Data;
using System.Data;
using System.Data.SqlClient;

namespace BlazorApp3.Data
{
    public class DataTable
    {

        //public ActionResult Index()
        //{
        //    Utils.Utils2 util = new Utils.Utils2(); // My class for connection
        //    string conString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        //    string connetionString = null;
        //    SqlConnection connection;
        //    SqlDataAdapter adapter;
        //    SqlCommand command = new SqlCommand();
        //    DataSet dataset = new DataSet();

        //    connetionString = conString;
        //    connection = new SqlConnection(connetionString);

        //    connection.Open();
        //    command.Connection = connection;
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.CommandText = "spPivotTest";

        //    adapter = new SqlDataAdapter(command);
        //    adapter.Fill(dataset);
        //    connection.Close();

        //    DataTable table = new DataTable();

        //    table = dataset.Tables[0];


        //    ViewData["PivotDataTable"] = table;

        //    return View();
        //}

    }
}
