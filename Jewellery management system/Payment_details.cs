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
    public partial class payment_details : Form
    {
        public payment_details()
        {
            InitializeComponent();
        }

        BLLPayment_details pyds = new BLLPayment_details();
        private void cbo_mode_Load(object sender, EventArgs e)
        {

        }
        int pay = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            int checkIntegers;
            decimal checkDecimal;
            if (txt_pay_no.Text == "" || cbo_supplier.Text == "" || txt_bill_no.Text == "" || cbo_modes.Text == "" || txt_chk_dr.Text == "" || txt_bank.Text == "" || txt_actual_amount.Text == "" || txt_pay_amount.Text == "")
            {
                MessageBox.Show("the inputs are empty...");
            }

            else if (!int.TryParse(txt_pay_no.Text, out checkIntegers) || !int.TryParse(txt_bill_no.Text, out checkIntegers) || !int.TryParse(txt_chk_dr.Text, out checkIntegers) || !decimal.TryParse(txt_actual_amount.Text, out checkDecimal) || !decimal.TryParse(txt_pay_amount.Text, out checkDecimal))
            {
                MessageBox.Show("the input are invalid...");


            }
            else
            {

                dgv_payment_details.Rows.Add();
                dgv_payment_details.Rows[pay].Cells["calpayment_no"].Value = txt_pay_no.Text;
                dgv_payment_details.Rows[pay].Cells["calp_date"].Value = dtp_date.Text;
                dgv_payment_details.Rows[pay].Cells["calpayment_dates"].Value = dtp_payments_dates.Text;
                dgv_payment_details.Rows[pay].Cells["calsupplier"].Value = cbo_supplier.Text;
                dgv_payment_details.Rows[pay].Cells["calbillno"].Value = txt_bill_no.Text;
                dgv_payment_details.Rows[pay].Cells["calmode"].Value = cbo_modes.Text;
                dgv_payment_details.Rows[pay].Cells["calchk_dr_no"].Value = txt_chk_dr.Text;
                dgv_payment_details.Rows[pay].Cells["calchk_dr_date"].Value = dtp_chk_dr.Text;
                dgv_payment_details.Rows[pay].Cells["calbank"].Value = txt_bank.Text;
                dgv_payment_details.Rows[pay].Cells["calactual_pay"].Value = txt_actual_amount.Text;
                dgv_payment_details.Rows[pay].Cells["calpay_amount"].Value = txt_pay_amount.Text;
                dgv_payment_details.Rows[pay].Cells["calremarks"].Value = txt_remarks.Text;
                pay++;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void dgv_payment_details_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_pay_no.Text = dgv_payment_details.CurrentRow.Cells[0].Value.ToString();
           dtp_date.Text = dgv_payment_details.CurrentRow.Cells[1].Value.ToString();
            dtp_payments_dates.Text = dgv_payment_details.CurrentRow.Cells[2].Value.ToString();
            cbo_supplier.Text = dgv_payment_details.CurrentRow.Cells[3].Value.ToString();
            txt_bill_no.Text = dgv_payment_details.CurrentRow.Cells[4].Value.ToString();
            cbo_modes.Text = dgv_payment_details.CurrentRow.Cells[5].Value.ToString();
            txt_bank.Text = dgv_payment_details.CurrentRow.Cells[6].Value.ToString();
            txt_chk_dr.Text = dgv_payment_details.CurrentRow.Cells[7].Value.ToString();
            dtp_chk_dr.Text = dgv_payment_details.CurrentRow.Cells[8].Value.ToString();
            txt_actual_amount.Text = dgv_payment_details.CurrentRow.Cells[9].Value.ToString();
            txt_pay_amount.Text = dgv_payment_details.CurrentRow.Cells[10].Value.ToString();
            txt_remarks.Text = dgv_payment_details.CurrentRow.Cells[11].Value.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            int txt_pay_no_pass = Convert.ToInt32(dgv_payment_details.CurrentRow.Cells[0].Value);
            DateTime dtp_date_pass = Convert.ToDateTime(dgv_payment_details.CurrentRow.Cells[1].Value);
            DateTime dtp_payments_dates_pass = Convert.ToDateTime(dgv_payment_details.CurrentRow.Cells[2].Value);
           string  cbo_supplier_pass= dgv_payment_details.CurrentRow.Cells[3].Value.ToString();
            int txt_bill_no_pass = Convert.ToInt32(dgv_payment_details.CurrentRow.Cells[4].Value);
            string cbo_modes_pass = dgv_payment_details.CurrentRow.Cells[5].Value.ToString();
            string txt_bank_pass = dgv_payment_details.CurrentRow.Cells[6].Value.ToString();
            int txt_chk_dr_pass = Convert.ToInt32(dgv_payment_details.CurrentRow.Cells[7].Value);
           DateTime dtp_chk_dr_pass = Convert.ToDateTime(dgv_payment_details.CurrentRow.Cells[8].Value);
            decimal txt_actual_amount_pass= Convert.ToDecimal(dgv_payment_details.CurrentRow.Cells[9].Value);
            decimal txt_pay_amount_pass = Convert.ToDecimal(dgv_payment_details.CurrentRow.Cells[10].Value);
           string txt_remarks_pass = dgv_payment_details.CurrentRow.Cells[11].Value.ToString();


                int insert = pyds.insertintotable(txt_pay_no_pass, dtp_date_pass, dtp_payments_dates_pass, cbo_supplier_pass, txt_bill_no_pass, cbo_modes_pass, txt_bank_pass, txt_chk_dr_pass, dtp_chk_dr_pass, txt_pay_amount_pass, txt_pay_amount_pass, txt_remarks_pass);
            if (insert > 0)
            {
                MessageBox.Show("data inserted into the database...");
            }
        }
    }
}