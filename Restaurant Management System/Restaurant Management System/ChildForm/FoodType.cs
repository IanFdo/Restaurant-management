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
using static System.Windows.Forms.LinkLabel;

namespace Restaurant_Management_System.ChildForm
{
    public partial class FoodType : Form
    {
        string clickbutton;
        public FoodType(string clickbutton)
        {
            InitializeComponent();
            this.clickbutton = clickbutton;
        }

        private void FoodType_Load(object sender, EventArgs e)
        {
            ButtonGenarate btns = new ButtonGenarate("select Price.id, Price.type, Price.price, FoodItem.foodName from Price inner join FoodItem on Price.foodItemId = FoodItem.foodItemId where foodName = '"+clickbutton+"'", "type", flowFoodType, click);
        }

        void click(object sender, EventArgs e)
        {

        }
    }
}
