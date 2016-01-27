using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewellery_management_system
{
    public partial class EditCategory : Form
    {
        public EditCategory()
        {
            InitializeComponent();
        }
       
        BLLCategory blcat = new BLLCategory();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txteditcategoryname.Text == "")
            {
                MessageBox.Show("Please Input Category Name");
            }
            else
            {
                int i = blcat.editcategory(txteditcategoryname.Text,Convert.ToInt32(label3.Text));
                if (i > 0)
                {
                    MessageBox.Show("Category Has Been Update");
                    this.Hide();
                }
            }
        }

        private void EditCategory_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }
    }
}
