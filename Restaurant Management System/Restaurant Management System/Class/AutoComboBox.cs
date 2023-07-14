using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System.Class
{
    public class AutoComboBox : Sqlconnection
    {
        string query;
        ComboBox cbo;
        string displayMember;
        string valueMember; 

        public AutoComboBox(string query, ComboBox cbo, string displayMember, string valueMember)
        {
            this.query = query;
            this.cbo = cbo;
            this.displayMember = displayMember;
            this.valueMember = valueMember;
            autoCbo(this.query, this.cbo, this.displayMember, this.valueMember);
        }
        void autoCbo(string query, ComboBox cbo, string displayMember, string valueMember)
        {
            try
            {
                databaseConnection = new SqlConnection(connectionstring);
                databaseConnection.Open();
                commandDatabase = new SqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                sdr = new SqlDataAdapter(commandDatabase);
                dt = new DataTable();
                sdr.Fill(dt);
                cbo.DisplayMember = displayMember;
                cbo.ValueMember = valueMember;
                cbo.DataSource = dt;
                cbo.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbo.AutoCompleteSource = AutoCompleteSource.ListItems;
                databaseConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
