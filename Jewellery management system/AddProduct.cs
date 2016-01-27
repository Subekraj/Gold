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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        
        BLLCategory blcat = new BLLCategory();
        BLLItem blitm = new BLLItem();
        public void category()
        {
            DataTable dt = blcat.getalldata();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                dr["category_name"] = "Choose One";
                dt.Rows.InsertAt(dr,0);
                cbocategory.DataSource = dt;
                cbocategory.DisplayMember = "category_name";
                cbocategory.ValueMember = "category_id";


            }
        }

        private void btnadditem_Click(object sender, EventArgs e)

        {
            if (txtedititem.Text == ""|| cbocategory.Text=="Choose One"|| txtitemcode.Text=="")
            {
                MessageBox.Show("input the required fields...");
            }
            else
            {
                int i = blitm.additem(Convert.ToInt32(cbocategory.SelectedValue.ToString()), txtedititem.Text,Convert.ToInt32(txtitemcode.Text));
                if (i > 0)
                {
                    MessageBox.Show("New Item Has Been Save To The Database");
                    getallingridview();
                    this.Hide();
                    AddProduct adp = new AddProduct();
                    adp.Show();
                    
             }
                       
            }
              

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            category();
            getallingridview();
            edititem.Hide();
            btnedit.Hide();
           
        }

        public void getallingridview()
        {
            DataTable dt = blitm.getallitem();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
                
        }
        public int item_id;

       

      

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            if (txtedititem.Text == "" || cbocategory.Text == "Choose One")
            {
                MessageBox.Show("input the required fields...");
            }
            else
            {
                int i = blitm.updateitem(Convert.ToInt32(cbocategory.SelectedValue.ToString()), txtedititem.Text,item_id,Convert.ToInt32(txtitemcode.Text));
                if (i > 0)
                {
                    MessageBox.Show("Product Has Been Update");
                }
            }


        }

        private void dataGridView1_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            edititem.Show();
            label1.Hide();
            btnadditem.Hide();
            btnedit.Show();
            txtedititem.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbocategory.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            item_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtitemcode.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

             DataTable dt = blcat.getalldata();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                dr["category_name"] = "Choose One";
                dt.Rows.InsertAt(dr,0);
                cbocategory.DataSource = dt;
                cbocategory.DisplayMember = "category_name";
                cbocategory.ValueMember = "category_id";


            }

        }
    }
}
