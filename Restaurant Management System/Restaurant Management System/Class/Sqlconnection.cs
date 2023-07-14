using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Class
{
    public class Sqlconnection
    {
        protected string connectionstring = "Data Source=DESKTOP-S5LHH43\\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";

        protected SqlConnection conn;
        protected SqlCommand comm;
        protected SqlConnection databaseConnection;
        protected SqlCommand commandDatabase;
        protected SqlDataAdapter sdr;
        protected DataTable dt;
        protected SqlDataReader dr;

    }
}
