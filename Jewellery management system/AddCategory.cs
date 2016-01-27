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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }
        BLLCategory bllcat = new BLLCategory();
   

        private void btnaddcategory_Click(object sender, EventArgs e)
        {
            if (txtcategoryname.Text == "")
            {
                MessageBox.Show("insert reuqired field..");
               

            }
            else
            {
                if (MessageBox.Show("Are you sure want to Add?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int i = bllcat.addnewcategory(txtcategoryname.Text);
                    if (i > 0)
                    {
                        MessageBox.Show("New Category Has Been Add To Your Database");
                        this.Refresh();
                    }
                }
            }
        }
        public void showingridwiew()
        {
            DataTable dt = bllcat.getalldata();
                if(dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
                
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            showingridwiew();
            

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditCategory edtcat = new EditCategory();
            edtcat.txteditcategoryname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            edtcat.label3.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();

            edtcat.Show();
            showingridwiew();

        }
    }
}
