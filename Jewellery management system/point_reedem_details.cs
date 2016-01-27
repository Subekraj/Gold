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
    public partial class point_reedem_details : Form
    {
        public point_reedem_details()
        {
            InitializeComponent();
        }

        BllRedeem_points rp = new BllRedeem_points();

        private void point_reedem_details_Load(object sender, EventArgs e)
        {
            cbo_gift.SelectedIndex = 0;
            cbo_redeem.SelectedIndex = 0;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
            clearcombo(this);
            cleardate(this);

        }
        public void ClearAllText(Control con) {
            foreach (Control c in con.Controls) {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        
        }
        public void clearcombo(Control con) {
            foreach (Control c in con.Controls) {
                if (c is ComboBox)
                    ((ComboBox)c).ResetText();
                else
                    clearcombo(c);
            }

        }
        public void cleardate(Control con) {
            foreach (Control c in con.Controls) {
                if (c is DateTimePicker)
                    ((DateTimePicker)c).ResetText();
                else
                    cleardate(c);


            }

        }
        int r = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            int rp;
            if (cbo_customer.Text == "" || txt_point_reedem.Text == "" || cbo_gift.Text == "" || cbo_redeem.Text == "") {
                MessageBox.Show("the inputs are empty...");
            }
            else if ( !int.TryParse(txt_point_reedem.Text, out rp))
            {
                MessageBox.Show("the input are invalid");


            }

            else
            {
                dgv_redeem.Rows.Add();
                dgv_redeem.Rows[r].Cells["calcustomer"].Value = cbo_customer.Text;
                dgv_redeem.Rows[r].Cells["calredeempoint"].Value = txt_point_reedem.Text;
                dgv_redeem.Rows[r].Cells["calredeemdate"].Value = dtp_date.Text;
                dgv_redeem.Rows[r].Cells["calgift"].Value = cbo_gift.Text;
                dgv_redeem.Rows[r].Cells["calredeemmode"].Value = cbo_redeem.Text;
                r++;
            } }

        private void btn_save_Click(object sender, EventArgs e)
        {
           string  cbo_customer_pass = dgv_redeem.CurrentRow.Cells[0].Value.ToString();
          int  txt_point_reedem_pass = Convert.ToInt32(dgv_redeem.CurrentRow.Cells[2].Value);
            DateTime dtp_date_pass = Convert.ToDateTime(dgv_redeem.CurrentRow.Cells[1].Value);
            string cbo_gift_pass = dgv_redeem.CurrentRow.Cells[3].Value.ToString();
             string cbo_redeemmode_pass = dgv_redeem.CurrentRow.Cells[4].Value.ToString();
            int inserttion = rp.insertintotable(cbo_customer_pass,txt_point_reedem_pass,dtp_date_pass,cbo_gift_pass,cbo_redeemmode_pass);
                if (inserttion>0) {
                MessageBox.Show("Data inserted into database..."); 
                
                }
        }
       

        private void dgv_redeem_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cbo_customer.Text = dgv_redeem.CurrentRow.Cells[0].Value.ToString();
            txt_point_reedem.Text = dgv_redeem.CurrentRow.Cells[2].Value.ToString();
            dtp_date.Text = dgv_redeem.CurrentRow.Cells[1].Value.ToString();
            cbo_gift.Text = dgv_redeem.CurrentRow.Cells[3].Value.ToString();
            cbo_redeem.Text = dgv_redeem.CurrentRow.Cells[4].Value.ToString();
        }
    }
    }

