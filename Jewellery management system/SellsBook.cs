using BLL;
using System;
using System.Collections;
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
    public partial class SellsBook : Form
    {
        public SellsBook()
        {
            InitializeComponent();
        }
        BLLStock blsto = new BLLStock();
        BLLSell bllsel = new BLLSell();

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {





        }

        private void SellsBook_Load(object sender, EventArgs e)
        {






        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        decimal stone_charge = 1000;
        decimal labour_charge = 1000;
        int i = 0;
        private void atnadd_Click(object sender, EventArgs e)
        {


            //scan cell value 
            //then copy
            DataTable dt = new DataTable();
            dt = blsto.getallstockbyname(txtcode.Text);
            if (dt.Rows.Count > 0)
            {

                decimal weight = Convert.ToDecimal(dt.Rows[0]["weight"].ToString());
                int quantity = Convert.ToInt32(dt.Rows[0]["quantity"].ToString());
                decimal rate = Convert.ToDecimal(dt.Rows[0]["sell_price"].ToString());
                decimal totalcost = weight * rate * quantity;


                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["calitem_name"].Value = dt.Rows[0]["item_name"].ToString();
                dataGridView1.Rows[i].Cells["calweight"].Value = dt.Rows[0]["weight"].ToString();
                dataGridView1.Rows[i].Cells["calqty"].Value = dt.Rows[0]["quantity"].ToString();
                dataGridView1.Rows[i].Cells["calrate"].Value = dt.Rows[0]["sell_price"].ToString();
                dataGridView1.Rows[i].Cells["caltotal"].Value = totalcost;

                i++;
                txtsubtotal.Text = (Convert.ToDecimal(txtsubtotal.Text) + totalcost + stone_charge +labour_charge).ToString();

            }
            else
            {
                MessageBox.Show("Error :: Code Not Found");
            }


            }

        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtgrandtotal.Text =(( Convert.ToDecimal(txtsubtotal.Text)) - (Convert.ToDecimal(txtsubtotal.Text) * Convert.ToDecimal(txtdiscount.Text))/ 100).ToString();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                for (int a = 0; a < dataGridView1.Rows.Count; a++)
                {
                    string item_name = (dataGridView1.Rows[a].Cells["calitem_name"].Value.ToString());
                    decimal weight = Convert.ToDecimal(dataGridView1.Rows[a].Cells["calweight"].Value.ToString());
                    int quantity = Convert.ToInt32(dataGridView1.Rows[a].Cells["calqty"].Value.ToString());
                    decimal sell_price = Convert.ToInt32(dataGridView1.Rows[a].Cells["calrate"].Value.ToString());
                    decimal total = Convert.ToInt32(dataGridView1.Rows[a].Cells["caltotal"].Value.ToString());

                    int b = bllsel.insertallsells(Convert.ToInt32(txtbillno.Text), Convert.ToDateTime(dtpbilldate.Text), cbocustomername.Text, Convert.ToInt32(cbocustomerno.Text), item_name, weight, quantity, sell_price, labour_charge, stone_charge, total, txtpaymentrecive.Text);
                    sells_entry();
                    MessageBox.Show("Sell Has Been Save To Your Database");
                }

            }
            else
            {
                MessageBox.Show("Sell Cant be Save To Your Database");
            }
        }

        public void sells_entry()
        {
            int b = bllsel.insert_sellenrty(Convert.ToInt32(txtbillno.Text), Convert.ToDateTime(dtpbilldate.Text), cbocustomername.Text, Convert.ToInt32(cbocustomerno.Text),Convert.ToDecimal(txtsubtotal.Text),Convert.ToDecimal(txtcashamount.Text),Convert.ToDecimal(txtcardamount.Text),Convert.ToDecimal(txtdiscount.Text),Convert.ToDecimal(txtgrandtotal.Text), txtpaymentrecive.Text,txtpymenttype.Text);
        }

        private void txtcashamount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcardamount.Text =(Convert.ToDecimal( txtgrandtotal.Text) -Convert.ToDecimal( txtcashamount.Text)).ToString();
            }
        }

        private void txtcardamount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcashamount.Text = (Convert.ToDecimal(txtgrandtotal.Text) - Convert.ToDecimal(txtcardamount.Text)).ToString();
            }
        }
    }
    }





    
    
    


   


    

