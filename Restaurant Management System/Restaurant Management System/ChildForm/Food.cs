using Restaurant_Management_System.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System.ChildForm
{
    public partial class Food : Form
    {
        
        public Food()
        {
            InitializeComponent();
            AutoComboBox auto = new AutoComboBox("select * from Category", cboCate, "categoryName", "categoryId"); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insert insert = new insert("insert into FoodItem (foodName, categoryId) values ('" + txtAddFood.Text + "', '" + Convert.ToInt32(cboCate.SelectedValue) + "')");
        }

        private void cboCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowFood.Controls.Clear();
            ButtonGenarate gen = new ButtonGenarate("select foodName from FoodItem where categoryId = '" + Convert.ToInt32(cboCate.SelectedValue) + "'", "foodName", flowFood, click);
        }

        void click(object sender, EventArgs e)
        {

        }
    }
}
