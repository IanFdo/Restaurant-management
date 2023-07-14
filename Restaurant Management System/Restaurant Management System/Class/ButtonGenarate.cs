using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System.Class
{
    public class ButtonGenarate : Sqlconnection
    {
        string query;
        string text;
        FlowLayoutPanel flowpnl;
        EventHandler method;
        Button btn = new Button();

        public ButtonGenarate(string query, string text, FlowLayoutPanel flowpnl, EventHandler method)
        {
            this.query = query;
            this.text = text;
            this.flowpnl = flowpnl;
            this.method = method;
            Genarate(this.query, this.text, this.flowpnl, method);
        }

        public void Genarate(String query, String text, FlowLayoutPanel flowpnl, EventHandler method)
        {
            
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand comm = new SqlCommand(query, conn);
            conn.Open();
            dr = comm.ExecuteReader();
            while (dr.Read())
            {

                btn = new Button();
                btn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Width = 180;
                btn.Height = 100;
                btn.Text = Convert.ToString(dr[text]);

                flowpnl.Controls.Add(btn);
                btn.Click += new EventHandler(method);
            }
            dr.Close();
            conn.Close();
        }
    }

    
}
