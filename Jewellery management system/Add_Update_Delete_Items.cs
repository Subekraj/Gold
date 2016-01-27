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
    public partial class add_update : Form
    {
        public add_update()
        {
            InitializeComponent();
        }
        BLLItem_Add_Update biau = new BLLItem_Add_Update();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Update_Delete_Items_Load(object sender, EventArgs e)
        {
            
        }
       

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            decimal parsevalue;
            int integerparsedvalue;
            if (txt_barcode.Text == "" || txt_item_code.Text == "" || cbo_category.Text == "" || txt_item.Text == "" || txt_labour.Text == "" || txt_quantity.Text == "" || txt_sell_price.Text == "" || txt_weight.Text == "")
            {
                MessageBox.Show("the inputs are may be empty..");
            }

            else if (!int.TryParse(txt_barcode.Text, out integerparsedvalue) || !decimal.TryParse(txt_sell_price.Text, out parsevalue) || !int.TryParse(txt_quantity.Text, out integerparsedvalue) || !int.TryParse(txt_weight.Text, out integerparsedvalue) || !decimal.TryParse(txt_labour.Text, out parsevalue))
            {
                MessageBox.Show("the inputs are invalid...");
            }

            else
            {
             for (int row = 0; row < ADU_dataGridView.Rows.Count; row++)
                {

                    //getting value from gridview and assigning it
                    string item_code_pass = ADU_dataGridView.CurrentRow.Cells[0].Value.ToString();
                    int barcode_pass = Convert.ToInt32(ADU_dataGridView.CurrentRow.Cells[1].Value);
                    string category_pass = ADU_dataGridView.CurrentRow.Cells[2].Value.ToString();
                    string item_pass = ADU_dataGridView.CurrentRow.Cells[3].Value.ToString();
                    int weight_pass = Convert.ToInt32(ADU_dataGridView.CurrentRow.Cells[4].Value);
                    int quantity_pass = Convert.ToInt32(ADU_dataGridView.CurrentRow.Cells[5].Value);
                    decimal labour_charge_pass = Convert.ToDecimal(ADU_dataGridView.CurrentRow.Cells[6].Value);
                    decimal selling_price_pass = Convert.ToDecimal(ADU_dataGridView.CurrentRow.Cells[7].Value);



                    int inserttion = biau.InsertIntoTable(barcode_pass, category_pass, item_pass, selling_price_pass, quantity_pass, item_code_pass, weight_pass, labour_charge_pass);
                    if (inserttion > 0)
                    {
                        MessageBox.Show("data inserted...");
                    }
                }

            }
        }
            
        int i = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            int integers;
            decimal decimals;

            if (txt_barcode.Text == "" || txt_item.Text == "" || cbo_category.Text == "" || txt_item_code.Text == "" || txt_labour.Text == "" || txt_quantity.Text == "" || txt_sell_price.Text == "" || txt_weight.Text == "")
            {
                MessageBox.Show("the inputs are empty...");

            }
            else if (!int.TryParse(txt_item_code.Text, out integers) || !int.TryParse(txt_weight.Text, out integers) || !int.TryParse(txt_quantity.Text, out integers) || !decimal.TryParse(txt_labour.Text, out decimals) || !decimal.TryParse(txt_sell_price.Text, out decimals))
            {
                lbl_code.Text = "wrong input type....";
                //lbl_w.Text = "wrong input type....";
                //lbl_q.Text = "wrong input type";
                //lbl_l.Text = "wrong input type";
                //lbl_sp.Text = "wrong input type";

            }
            //if (int.TryParse(txt_item_code.Text, out integers) || int.TryParse(txt_weight.Text, out integers) || int.TryParse(txt_quantity.Text, out integers) || decimal.TryParse(txt_labour.Text, out decimals) || decimal.TryParse(txt_sell_price.Text, out decimals)) {
            //      lbl_code.Text = "*";
            //      lbl_w.Text = "*";
            //      lbl_q.Text = "*";
            //      lbl_l.Text = "*";
            //      lbl_sp.Text = "*";

            //  }
            else
            {

                ADU_dataGridView.Rows.Add();
                //adding rows on the datdridview when adding 
                ADU_dataGridView.Rows[i].Cells["calitem_code"].Value = txt_item_code.Text;
                ADU_dataGridView.Rows[i].Cells["calbar_code"].Value = txt_barcode.Text;
                ADU_dataGridView.Rows[i].Cells["calcategory"].Value = cbo_category.Text;
                ADU_dataGridView.Rows[i].Cells["calitem"].Value = txt_item.Text;
                ADU_dataGridView.Rows[i].Cells["calweight"].Value = txt_weight.Text;
                ADU_dataGridView.Rows[i].Cells["calquantity"].Value = txt_quantity.Text;
                ADU_dataGridView.Rows[i].Cells["callabour_charge"].Value = txt_labour.Text;
                ADU_dataGridView.Rows[i].Cells["calselling_price"].Value = txt_sell_price.Text;

                i++;

                               

            }
            ClearAllcboitem(this);
            ClearAllText(this);
        }

        public void ClearAllText(Control con)//to clear all the text in the textboxes

        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
        //to clear all the texts in combo box
        public void ClearAllcboitem(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is ComboBox)
                    ((ComboBox)c).ResetText();
                else
                    ClearAllcboitem(c);
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ClearAllcboitem(this);
            ClearAllText(this);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }
    }
}

  
      
     