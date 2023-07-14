using Restaurant_Management_System.Class;
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
    public partial class Price : Form
    {
        
        public Price()
        {
            InitializeComponent();
            AutoComboBox autoCate = new AutoComboBox("select * from Category", cboCate, "categoryName", "categoryId");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insert insert = new insert("insert into Price (type, price, foodItemId) values ('" + txtFoodType.Text + "', '" + txtPrice.Text + "', '" + Convert.ToInt32(cboFood.SelectedValue) + "')");
        }

        private void cboCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoComboBox auto = new AutoComboBox("select FoodItem.foodItemId, FoodItem.foodName, Category.categoryName from Category inner join FoodItem on FoodItem.categoryId = Category.categoryId where categoryName = '" + cboCate.Text + "'", cboFood, "foodName", "foodItemId");
        }
    }
}
