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
    public partial class Supplier_details_update : Form
    {
        public Supplier_details_update()
        {
            InitializeComponent();
        }
        BLLSupplier_details supp = new BLLSupplier_details();
        private void btn_reset_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Supplier_details_update_Load(object sender, EventArgs e)
        {
            DataTable dt = supp.Fectching_All_Table_data();
            if (dt.Rows.Count > 0)
            {
                supply_dataGridView.DataSource = dt;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
        
       
            int UpdateCustomerDetailsTable = supp.UpdateIntoSupplierDetails(cbo_supplier_type.Text, Convert.ToInt32(txt_newSupplierID.Text),cbo_title.Text,cbo_name.Text,Convert.ToInt32(txt_contact.Text),txt_adress.Text,Convert.ToInt32(txt_phone.Text),Convert.ToInt32(txt_mobile),Convert.ToInt32(txt_fax),txt_email.Text,txt_city.Text,Convert.ToInt32(txt_eccno.Text),Convert.ToInt32(txt_cst.Text),txt_division.Text,Convert.ToInt32(txt_pan.Text));
            if (UpdateCustomerDetailsTable > 0)
            {

                MessageBox.Show("data Updated");
            }
            else
            {
                MessageBox.Show("no updated");
            }
        }
    }
}
