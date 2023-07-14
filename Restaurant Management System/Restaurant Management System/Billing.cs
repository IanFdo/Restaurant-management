using Restaurant_Management_System.ChildForm;
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

namespace Restaurant_Management_System
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            ButtonGenarate btns = new ButtonGenarate("select categoryId, categoryName from Category", "categoryName", flowCateShow, click);
        }

        void click(object sender, EventArgs e)
        {
            flowMenu.Controls.Clear();
            Button currentbtn = (Button)sender;
            ButtonGenarate btns = new ButtonGenarate("select FoodItem.foodItemId, FoodItem.foodName, Category.categoryName from Category inner join FoodItem on FoodItem.categoryId = Category.categoryId where categoryName = '"+currentbtn.Text+"'", "foodName", flowMenu, typeclick);
        }

        void typeclick(object sender, EventArgs e)
        {
            Button clickbutton = (Button)sender;
            FoodType frm = new FoodType(clickbutton.Text);
            frm.Show();
            
        }

        public void test()
        {

        }

    }
}
