using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System.ChildForm
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        public void showchildform(Object Form)
        {
            if (this.pnlWorkspace.Controls.Count > 0)
            {
                this.pnlWorkspace.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnlWorkspace.Controls.Add(form);
            form.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            showchildform(new ChildForm.Category());
        }

        private void btnFoodItem_Click(object sender, EventArgs e)
        {
            showchildform(new ChildForm.Food());
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            showchildform(new ChildForm.Price());
        }
    }
}
