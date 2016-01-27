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
         
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_save_Click(object sender, EventArgs e)
        {
           

            string supplier_type_pass = supply_dataGridView.CurrentRow.Cells[1].Value.ToString();
            int new_supplier_id_pass = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[2].Value);
            string title_pass = supply_dataGridView.CurrentRow.Cells[3].Value.ToString();
            string name_pass = supply_dataGridView.CurrentRow.Cells[4].Value.ToString();
            int contact_pass = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[5].Value);
            string adress_pass = supply_dataGridView.CurrentRow.Cells[6].Value.ToString();
            int phone_pass = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[7].Value);
            int mobile_pass = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[8].Value);
            int fax_pass= Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[9].Value);
            string email_pass = supply_dataGridView.CurrentRow.Cells[10].Value.ToString();
            string city_pass = supply_dataGridView.CurrentRow.Cells[11].Value.ToString();
            int ecc_no_pass= Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[12].Value);
            int cst_no_pass = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[13].Value);
            string division_pass = supply_dataGridView.CurrentRow.Cells[14].Value.ToString();
            int pan_no_pass = Convert.ToInt32(supply_dataGridView.CurrentRow.Cells[15].Value);


            if (supply_dataGridView.Rows.Count>0) {
                int supply = supp.InsertIntoSupplierDetails(supplier_type_pass,new_supplier_id_pass,title_pass,name_pass,contact_pass,adress_pass,phone_pass,mobile_pass,fax_pass,email_pass,city_pass,ecc_no_pass,cst_no_pass,division_pass,pan_no_pass);
                if (supply > 0) {
                    MessageBox.Show("data inserted");
                }
            }
            else {

                MessageBox.Show("there is no data to save...");
            }


        }
        

        private void supply_dataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            cbo_supplierId.Text = supply_dataGridView.CurrentRow.Cells[0].Value.ToString();
            cbo_supplier_type.Text = supply_dataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_newSupplierID.Text = supply_dataGridView.CurrentRow.Cells[2].Value.ToString();
            cbo_title.Text = supply_dataGridView.CurrentRow.Cells[3].Value.ToString();
            cbo_name.Text = supply_dataGridView.CurrentRow.Cells[4].Value.ToString();
            txt_contact.Text = supply_dataGridView.CurrentRow.Cells[5].Value.ToString();
            txt_adress.Text = supply_dataGridView.CurrentRow.Cells[6].Value.ToString();
            txt_phone.Text = supply_dataGridView.CurrentRow.Cells[7].Value.ToString();
            txt_mobile.Text = supply_dataGridView.CurrentRow.Cells[8].Value.ToString();
            txt_fax.Text = supply_dataGridView.CurrentRow.Cells[9].Value.ToString();
            txt_email.Text = supply_dataGridView.CurrentRow.Cells[10].Value.ToString();
            txt_city.Text = supply_dataGridView.CurrentRow.Cells[11].Value.ToString();
            txt_eccno.Text = supply_dataGridView.CurrentRow.Cells[12].Value.ToString();
            txt_cst.Text = supply_dataGridView.CurrentRow.Cells[13].Value.ToString();
            txt_division.Text = supply_dataGridView.CurrentRow.Cells[14].Value.ToString();
            txt_pan.Text = supply_dataGridView.CurrentRow.Cells[15].Value.ToString();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void clearAllTextbox(Control Con) {
            foreach (Control c in Con.Controls) {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    clearAllTextbox(c);
                               
            }


        }
        public void clearAllCombobox(Control con) {
            foreach (Control c in con.Controls) {
                if (c is ComboBox)
                    ((ComboBox)c).ResetText();
                else
                    clearAllCombobox(c);

            }

        }

        int rowadd = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            int parsedvalue;                                                                              //(int supplier_id,string supplier_type , int new_supplier_id, string title, string name,  int contact, string adress ,int phone, int mobile, int fax, string email, string city, int ecc_no, int cst_no, string division, int pan_no)
            if (txt_adress.Text == "" || txt_city.Text == "" || txt_contact.Text == "" || txt_cst.Text == "" || txt_division.Text == "" || txt_eccno.Text == "" || txt_email.Text == "" || txt_fax.Text == "" || txt_mobile.Text == "" || txt_pan.Text == "" || txt_phone.Text == "" || cbo_name.Text == "" || cbo_supplier_type.Text == "" || cbo_title.Text == "" || cbo_supplierId.Text == "" || txt_newSupplierID.Text == "")
            {
                MessageBox.Show("the inputs are empty. the * box must be filled to Proceed");
            }
            else if (!int.TryParse(txt_contact.Text, out parsedvalue) || !int.TryParse(txt_cst.Text, out parsedvalue) || !int.TryParse(txt_eccno.Text, out parsedvalue) || !int.TryParse(txt_fax.Text, out parsedvalue) || !int.TryParse(txt_mobile.Text, out parsedvalue) || !int.TryParse(cbo_supplierId.Text, out parsedvalue) || !int.TryParse(txt_newSupplierID.Text, out parsedvalue))
            {
                MessageBox.Show("The input type is incorrect check again...");
            }
            else
            {
                supply_dataGridView.Rows.Add();
              supply_dataGridView.Rows[rowadd].Cells["calsupplier_id"].Value = cbo_supplierId.Text;
                supply_dataGridView.Rows[rowadd].Cells["calsupplier_type"].Value = cbo_supplier_type.Text;
                supply_dataGridView.Rows[rowadd].Cells["calnew_supplier_id"].Value = txt_newSupplierID.Text;
                supply_dataGridView.Rows[rowadd].Cells["caltitle"].Value = cbo_title.Text;
                supply_dataGridView.Rows[rowadd].Cells["calname"].Value = cbo_name.Text;
                supply_dataGridView.Rows[rowadd].Cells["calcontact"].Value = txt_contact.Text;
                supply_dataGridView.Rows[rowadd].Cells["caladress"].Value = txt_adress.Text;
                supply_dataGridView.Rows[rowadd].Cells["calphone"].Value = txt_phone.Text;
                supply_dataGridView.Rows[rowadd].Cells["calmobile"].Value = txt_mobile.Text;
                supply_dataGridView.Rows[rowadd].Cells["calfax"].Value = txt_fax.Text;
                supply_dataGridView.Rows[rowadd].Cells["calemail"].Value = txt_email.Text;
                supply_dataGridView.Rows[rowadd].Cells["calcity"].Value = txt_city.Text;
                supply_dataGridView.Rows[rowadd].Cells["calecc_no"].Value = txt_eccno.Text;
                supply_dataGridView.Rows[rowadd].Cells["calcst_no"].Value = txt_cst.Text;
                supply_dataGridView.Rows[rowadd].Cells["caldivision"].Value = txt_division.Text;
                supply_dataGridView.Rows[rowadd].Cells["calpan_no"].Value = txt_pan.Text;

                rowadd++;
                clearAllCombobox(this);
                clearAllTextbox(this);

            }
            }

        private void btn_reset_Click(object sender, EventArgs e)
        {

        }
    }
    }

