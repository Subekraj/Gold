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
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }


        BLLCustomerDetails cusdetail = new BLLCustomerDetails();
        private void btn_save_Click(object sender, EventArgs e)
        { int parsedValue;
            //string new_customer_id, string customer_id, string title, string name, string spouse, string adress, string birthdate, string anniversary, int phone, int mobile, int fax, string email, string city

            
            if (txt_newCustomerID.Text == "" || cbo_title.Text == "" || cbo_name.Text == "" || txt_spouse.Text == "" || txt_adress.Text == "" || dtp_birthdate.Text == "" || dtp_anniversary.Text == "" || txt_phone.Text == "" || txt_mobile.Text == "" || txt_fax.Text == "" || txt_email.Text == "" || txt_city.Text == "")
            {
                MessageBox.Show("inputs are empty");
            }
            else if (!int.TryParse(txt_phone.Text, out parsedValue) || !int.TryParse(txt_mobile.Text, out parsedValue) || !int.TryParse(txt_fax.Text, out parsedValue))
            {
                MessageBox.Show("type numbers in required fields");
            }
            else {
                int InsertValuetoCustomerDetailsTable = cusdetail.InsertIntoCustomersDetails(Convert.ToInt32(txt_newCustomerID.Text), cbo_title.Text, cbo_name.Text, txt_spouse.Text, txt_adress.Text, Convert.ToDateTime(dtp_birthdate.Text), Convert.ToDateTime(dtp_anniversary.Text), Convert.ToInt32(txt_phone.Text), Convert.ToInt32(txt_mobile.Text), Convert.ToInt32(txt_fax.Text), txt_email.Text, txt_city.Text);
                if (InsertValuetoCustomerDetailsTable>0) {
                    MessageBox.Show("data inserted");
                }
            }
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            DataTable dt = cusdetail.Fectching_All_Table_data();
            if (dt.Rows.Count > 0)
            {
                customerData.DataSource = dt;
            }
            else
            {
                MessageBox.Show("cant load gridview");

            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //Customer_Details_Update cus_up = new Customer_Details_Update();
            //cus_up.Show();
            this.Hide();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerData_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            
        }

        private void customerData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Customer_Details_Update cdu = new Customer_Details_Update();
            //cdu.cbo_customerId.Text = Convert.ToInt32(customerData.CurrentRow.Cells[0].Value).ToString();
            //cdu.txt_newCustomerID.Text = customerData.CurrentRow.Cells[1].Value.ToString();
            //cdu.cbo_title.Text = customerData.CurrentRow.Cells[2].Value.ToString();
            //cdu.cbo_name.Text = customerData.CurrentRow.Cells[3].Value.ToString();
            //cdu.txt_spouse.Text = customerData.CurrentRow.Cells[4].Value.ToString();
            //cdu.txt_adress.Text = customerData.CurrentRow.Cells[5].Value.ToString();

            //cdu.txt_phone.Text = customerData.CurrentRow.Cells[8].Value.ToString();
            //cdu.txt_mobile.Text = customerData.CurrentRow.Cells[9].Value.ToString();
            //cdu.txt_fax.Text = customerData.CurrentRow.Cells[10].Value.ToString();
            //cdu.txt_email.Text = customerData.CurrentRow.Cells[11].Value.ToString();
            //cdu.txt_city.Text = customerData.CurrentRow.Cells[12].Value.ToString();
            //cdu.Show();


        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.Refresh();    
        }
    }
}
