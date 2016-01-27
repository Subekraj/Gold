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

               int cbo_customerId_pass = Convert.ToInt32(dgv_customerdetails.CurrentRow.Cells[0].Value);
                string cbo_title_pass = dgv_customerdetails.CurrentRow.Cells[1].Value.ToString();
            
               string cbo_name_pass = dgv_customerdetails.CurrentRow.Cells[2].Value.ToString();
               string txt_spouse_pass = dgv_customerdetails.CurrentRow.Cells[3].Value.ToString();
                string txt_adress_pass = dgv_customerdetails.CurrentRow.Cells[4].Value.ToString();
                string txt_city_pass = dgv_customerdetails.CurrentRow.Cells[5].Value.ToString();
                DateTime dtp_birthdate_pass = Convert.ToDateTime(dgv_customerdetails.CurrentRow.Cells[6].Value);
                DateTime dtp_anniversary_pass = Convert.ToDateTime(dgv_customerdetails.CurrentRow.Cells[7].Value);
                int txt_phone_pass = Convert.ToInt32(dgv_customerdetails.CurrentRow.Cells[8].Value);
                int txt_mobile_pass = Convert.ToInt32(dgv_customerdetails.CurrentRow.Cells[9].Value);
                int txt_fax_pass = Convert.ToInt32(dgv_customerdetails.CurrentRow.Cells[10].Value);
                string txt_email_pass = dgv_customerdetails.CurrentRow.Cells[11].Value.ToString();

                int InsertValuetoCustomerDetailsTable = cusdetail.InsertIntoCustomersDetails(cbo_customerId_pass,cbo_title_pass,cbo_name_pass,txt_spouse_pass,txt_adress_pass,dtp_birthdate_pass,dtp_anniversary_pass,txt_phone_pass,txt_mobile_pass,txt_fax_pass,txt_email_pass,txt_city_pass);
                if (InsertValuetoCustomerDetailsTable > 0)
                {
                    MessageBox.Show("data inserted");
                }
            }
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
          

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

     

        private void customerData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Customer_Details_Update cdu = new Customer_Details_Update();
            cdu.cbo_customerId.Text = Convert.ToInt32(dgv_customerdetails.CurrentRow.Cells[0].Value).ToString();
            cdu.cbo_title.Text = dgv_customerdetails.CurrentRow.Cells[1].Value.ToString();
            cdu.cbo_name.Text = dgv_customerdetails.CurrentRow.Cells[2].Value.ToString();
            cdu.txt_spouse.Text = dgv_customerdetails.CurrentRow.Cells[4].Value.ToString();
            cdu.txt_adress.Text = dgv_customerdetails.CurrentRow.Cells[5].Value.ToString();

            cdu.txt_phone.Text = dgv_customerdetails.CurrentRow.Cells[8].Value.ToString();
            cdu.txt_mobile.Text = dgv_customerdetails.CurrentRow.Cells[9].Value.ToString();
            cdu.txt_fax.Text = dgv_customerdetails.CurrentRow.Cells[10].Value.ToString();
            cdu.txt_email.Text = dgv_customerdetails.CurrentRow.Cells[11].Value.ToString();
            cdu.txt_city.Text = dgv_customerdetails.CurrentRow.Cells[12].Value.ToString();
            cdu.Show();


        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ClearallTextbox(this);
            clearcombo(this);
            cleardate(this);    
        }
        public void ClearallTextbox(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();

                else
                    ClearallTextbox(c);
            }

        }
        public void clearcombo(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is ComboBox)
                    ((ComboBox)c).ResetText();
                else
                    clearcombo(c);


            }

        }
        public void cleardate(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is DateTimePicker)
                    ((DateTimePicker)c).ResetText();
                else
                    cleardate(c);



            }

        }
        int addrw = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cbo_name.Text==""||cbo_title.Text==""||txt_adress.Text==""||txt_city.Text==""||txt_email.Text==""||txt_fax.Text==""||txt_mobile.Text==""||txt_newCustomerID.Text==""||txt_phone.Text==""||txt_spouse.Text=="") {

                MessageBox.Show("The inputs are empty..");
            }
            else {
                dgv_customerdetails.Rows.Add();
                dgv_customerdetails.Rows[addrw].Cells["caltitle"].Value = cbo_title.Text;
                dgv_customerdetails.Rows[addrw].Cells["calid"].Value = txt_newCustomerID.Text;
                dgv_customerdetails.Rows[addrw].Cells["calname"].Value = cbo_name.Text;
                dgv_customerdetails.Rows[addrw].Cells["calspouse"].Value = txt_spouse.Text;
                dgv_customerdetails.Rows[addrw].Cells["caladress"].Value = txt_adress.Text;
                dgv_customerdetails.Rows[addrw].Cells["calcity"].Value = txt_city.Text;
                dgv_customerdetails.Rows[addrw].Cells["calbthdate"].Value = dtp_birthdate.Text;
                dgv_customerdetails.Rows[addrw].Cells["calanniversary"].Value = dtp_anniversary.Text;
                dgv_customerdetails.Rows[addrw].Cells["calphone"].Value = txt_phone.Text;
                dgv_customerdetails.Rows[addrw].Cells["calmobile"].Value = txt_mobile.Text;
                dgv_customerdetails.Rows[addrw].Cells["calfax"].Value = txt_fax.Text;
                dgv_customerdetails.Rows[addrw].Cells["calemail"].Value = txt_email.Text;
                addrw++;
                //ClearallTextbox(this);
                //clearcombo(this);
                //cleardate(this);


            }
        }
    }
}
