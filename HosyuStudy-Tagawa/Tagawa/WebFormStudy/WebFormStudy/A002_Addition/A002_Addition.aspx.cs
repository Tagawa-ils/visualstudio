using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormStudy.A002_Addition
{
    public partial class A002_Addition : System.Web.UI.Page
    {
         protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["BookList"].ConnectionString;

            string BookTitle = txtBookTitle.Text;
            string TxtPrice = txtPrice.Text;
            string TxtISBN = txtISBN.Text;
            var Price = int.Parse(TxtPrice);
            var ISBN = decimal.Parse(TxtISBN);

            DateTime dt = DateTime.Now;
            String DTime = dt.ToString("yyyy/MM/dd HH:mm:ss.fff");

            var insertQuery = @"INSERT INTO BookList (ISBN, BookTitle, Price, DateTime) VALUES ( @ISBN, @BookTitle, @Price, @DateTime)";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(insertQuery, connection))
            {
                connection.Open();

                // パラメーターの追加
                command.Parameters.AddWithValue("@ISBN", ISBN);
                command.Parameters.AddWithValue("@BookTitle", BookTitle);
                command.Parameters.AddWithValue("@Price", Price);
                command.Parameters.AddWithValue("@DateTime", DTime);
                command.ExecuteNonQuery();

            }

        }
    }
}
