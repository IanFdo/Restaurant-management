using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System.Class
{
    public class Update : Sqlconnection
    {
        string commandUpdate;
        public Update(string commandUpdate)
        {
            this.commandUpdate = commandUpdate;
            update(this.commandUpdate);
        }
        void update(string commandUpdate)
        {
            try
            {
                conn = new SqlConnection(connectionstring);
                comm = new SqlCommand(commandUpdate, conn);
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
