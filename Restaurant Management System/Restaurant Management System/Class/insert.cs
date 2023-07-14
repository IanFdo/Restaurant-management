using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System.Class
{
    public class insert : Sqlconnection
    {
        string commandInsert;
        public insert(string commandInsert) { 
            this.commandInsert = commandInsert;
            Insert(this.commandInsert);
        }
        void Insert(string commandInsert)
        {
            try
            {
                conn = new SqlConnection(connectionstring);
                comm = new SqlCommand(commandInsert, conn);
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Record Added Succesfully");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
