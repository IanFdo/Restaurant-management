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
    public partial class Category : Form
    {
        
        public Category()
        {
            InitializeComponent();
            ButtonGenarate gen = new ButtonGenarate("select categoryName from Category", "categoryName", flowCate, click);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            insert insert = new insert("insert into Category (categoryName) values ('" + txtAddCate.Text + "')");
        }

        void click(object sender, EventArgs e)
        {

        }

    }
}
