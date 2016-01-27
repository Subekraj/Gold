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
    public partial class Supplier_opening_ballance : Form
    {
        public Supplier_opening_ballance()
        {
            InitializeComponent();
        }
        BLLSupplier_opening_balance sob = new BLLSupplier_opening_balance();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            decimal amounts;
           // char charac;


            if ( txt_ac_name.Text==""|| txt_amount.Text==""|| cbo_dt_cr.Text=="" ) {
                MessageBox.Show("the inputs cant be empty");
            }
            else if(!decimal.TryParse(txt_amount.Text, out amounts)){
                MessageBox.Show("the imputs are invalid... Check again");
            }
            else {
                int insert = sob.insertintotable(Convert.ToInt32(txt_opening_id.Text), Convert.ToDateTime(dtp_open_date.Text), txt_ac_name.Text, Convert.ToDecimal(txt_amount.Text), Convert.ToChar(cbo_dt_cr.Text));
                if (insert > 0) {
                    MessageBox.Show("data inserted ");
                } }
        }
        public void loaddataingrid() {
       DataTable dt = sob.FetchAllData();
            if (dt.Rows.Count > 0)
            {
                dataGridView_alldata.DataSource = dt;
            }
            else {
                MessageBox.Show("data grid not loaded");
            }
        }

        private void Supplier_opening_ballance_Load(object sender, EventArgs e)
        {
            loaddataingrid();
        }
    }
}
