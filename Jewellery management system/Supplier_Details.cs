using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace Jewellery_management_system
{
    public partial class Supplier_Details : Form
    {
        public Supplier_Details()
        {
            InitializeComponent();
        }
        BLLSupplier_details supp = new BLLSupplier_details();

        private void Supplier_Details_Load(object sender, EventArgs e)
        {
            DataTable dt = supp.Fectching_All_Table_data();
            if (dt.Rows.Count > 0)
            {
                supply_dataGridView.DataSource = dt;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btn_save_Click(object sender, EventArgs e)
        { int parsedvalue;                                                                              //(int supplier_id,string supplier_type , int new_supplier_id, string title, string name,  int contact, string adress ,int phone, int mobile, int fax, string email, string city, int ecc_no, int cst_no, string division, int pan_no)
            if (txt_adress.Text == "" || txt_city.Text == "" || txt_contact.Text == "" || txt_cst.Text == "" || txt_division.Text == "" || txt_eccno.Text == "" || txt_email.Text == "" || txt_fax.Text == "" || txt_mobile.Text == "" || txt_pan.Text == "" || txt_phone.Text == "" || cbo_name.Text == "" || cbo_supplier_type.Text == "" || cbo_title.Text == "" || cbo_supplierId.Text == "" || txt_newSupplierID.Text == "") {
                MessageBox.Show("the inputs are empty. the * box must be filled to Proceed");
            }
            else if (!int.TryParse(txt_contact.Text, out parsedvalue)||!int.TryParse(txt_cst.Text, out parsedvalue)|| !int.TryParse(txt_eccno.Text, out parsedvalue)|| !int.TryParse(txt_fax.Text , out parsedvalue)|| !int.TryParse(txt_mobile.Text, out parsedvalue)|| !int.TryParse(cbo_supplierId.Text, out parsedvalue) ||!int.TryParse(txt_newSupplierID.Text, out parsedvalue)) {
                MessageBox.Show("The input type is incorrect check again...");
            }
            else {

                int supply = supp.InsertIntoSupplierDetails(cbo_supplier_type.Text, Convert.ToInt32(txt_newSupplierID.Text), cbo_title.Text, cbo_name.Text, Convert.ToInt32(txt_contact.Text), txt_adress.Text, Convert.ToInt32(txt_phone.Text), Convert.ToInt32(txt_mobile.Text), Convert.ToInt32(txt_fax.Text), txt_email.Text, txt_city.Text, Convert.ToInt32(txt_eccno.Text), Convert.ToInt32(txt_cst), txt_division.Text, Convert.ToInt32(txt_pan.Text));
                if (supply > 0) {
                    MessageBox.Show("data inserted");
                }
            }
        }

        private void supply_dataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Supplier_details_update ups = new Supplier_details_update();
          
            ups.cbo_supplierId.Text = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[0].Value).ToString();
            ups.cbo_supplier_type.Text = supply_dataGridView.CurrentRow.Cells[1].Value.ToString();
            ups.txt_newSupplierID.Text = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[2].Value).ToString();
            ups.cbo_title.Text = supply_dataGridView.CurrentRow.Cells[3].Value.ToString();
            ups.cbo_name.Text = supply_dataGridView.CurrentRow.Cells[4].Value.ToString();
            ups.txt_contact.Text = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[5].Value).ToString();
            ups.txt_adress.Text = supply_dataGridView.CurrentRow.Cells[6].Value.ToString();
            ups.txt_phone.Text = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[7].Value).ToString();
            ups.txt_mobile.Text = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[8].Value).ToString();
            ups.txt_fax.Text = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[9].Value).ToString();
            ups.txt_email.Text = supply_dataGridView.CurrentRow.Cells[10].Value.ToString();
            ups.txt_city.Text = supply_dataGridView.CurrentRow.Cells[11].Value.ToString();
            ups.txt_eccno.Text = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[12].Value).ToString();
            ups.txt_cst.Text = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[13].Value).ToString();
            ups.txt_division.Text = supply_dataGridView.CurrentRow.Cells[14].Value.ToString();
            ups.txt_pan.Text = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[15].Value).ToString();

            ups.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
