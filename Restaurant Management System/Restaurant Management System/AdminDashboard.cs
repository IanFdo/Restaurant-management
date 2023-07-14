using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        public void showchildform(Object Form)
        {
            if (this.pnlMenu.Controls.Count > 0)
            {
                this.pnlMenu.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnlMenu.Controls.Add(form);
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            showchildform(new ChildForm.AddItem());
            lblDashboard.Text = btnAddItem.Text;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            showchildform(new ChildForm.Dashboard());
            lblDashboard.Text = btnDashboard.Text;
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            this.Hide();
            Billing frm = new Billing();
            frm.Show();
        }
    }
}
