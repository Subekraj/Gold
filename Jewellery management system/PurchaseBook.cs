using BLL;
using System;
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
    public partial class PurchaseBook : Form
    {
        public PurchaseBook()
        {
            InitializeComponent();
        }

        BLLInvoice blinv = new BLLInvoice();
        BLLCategory blcat = new BLLCategory();
        BLLItem blitm = new BLLItem();
        BLLPurchase blpur = new BLLPurchase();
        BLLStock blsto = new BLLStock();

        private void PurchaseBook_Load(object sender, EventArgs e)
        {
            invoiceno();
            itemcategory();
        }
        //invoice no generated
        public void invoiceno()
        {
            DataTable dt = blinv.getinvoiceno();
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString() == "")
                {
                    txtinvoiceno.Text = "100";
                }

                else
                {
                    int getinvoiceno = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;
                    txtinvoiceno.Text = getinvoiceno.ToString();
                }
            }
        }
        public void itemcategory()
        {
            DataTable dt = blcat.getalldata();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                dr["category_name"] = "Choose One";
                dt.Rows.InsertAt(dr, 0);
                cboitemcategory.DataSource = dt;
                cboitemcategory.DisplayMember = "category_name";
                cboitemcategory.ValueMember = "category_id";
            }
        }

        private void cboitemcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboitemcategory.SelectedIndex > 0)
            {
                DataTable dt = blitm.getitembycategoryid(Convert.ToInt32(cboitemcategory.SelectedValue.ToString()));
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.NewRow();
                    dr["item_name"] = "Choose One";
                    dt.Rows.InsertAt(dr, 0);
                    cboitemname.DataSource = dt;
                    cboitemname.DisplayMember = "item_name";
                    cboitemname.ValueMember = "item_name";
                }


            }
        }
        int i;

        private void btnadd_Click(object sender, EventArgs e)
        {

            int parsedvalue;
            decimal parse;
            if (txtinvoiceno.Text == "" || cboitemcategory.Text == "Choose One" || txtitembarcode.Text == "" || txtitemcode.Text == "" || cboitemname.Text == "Choose One" || txtsuppilerbillno.Text == "" || txtquantity.Text == "")
            {
                MessageBox.Show("inputs are may be empty..");
            }
            else if (!int.TryParse(txtinvoiceno.Text, out parsedvalue) || !int.TryParse(txtquantity.Text, out parsedvalue) || !decimal.TryParse(txtitembarcode.Text, out parse) || !decimal.TryParse(txtitemcode.Text, out parse))
            {
                MessageBox.Show("the inpur are invalid. type integer where required");

            }

            else
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["cdlinvoiceno"].Value = txtinvoiceno.Text;
                dataGridView1.Rows[i].Cells["cdlsuppilername"].Value = cbosuppilername.Text;
                dataGridView1.Rows[i].Cells["cdlinvoicedate"].Value = dtpdate.Text;
                dataGridView1.Rows[i].Cells["cdlsuppbillno"].Value = txtsuppilerbillno.Text;
                dataGridView1.Rows[i].Cells["cdlitemcode"].Value = txtitemcode.Text;
                dataGridView1.Rows[i].Cells["cdlitembarcode"].Value = txtitembarcode.Text;
                dataGridView1.Rows[i].Cells["cdlitemcategory"].Value = cboitemcategory.Text;
                dataGridView1.Rows[i].Cells["cdlitemname"].Value = cboitemname.Text;
                dataGridView1.Rows[i].Cells["cdlquantity"].Value = txtquantity.Text;
                dataGridView1.Rows[i].Cells["cdlmarketprice"].Value = txtmp.Text;
                dataGridView1.Rows[i].Cells["cdlcostprice"].Value = txtcp.Text;
                dataGridView1.Rows[i].Cells["cdldiscount"].Value = txtdiscount.Text;
                dataGridView1.Rows[i].Cells["cdlmargpercent"].Value = txtmargper.Text;
                dataGridView1.Rows[i].Cells["cdlmargdiscount"].Value = txtmargdis.Text;
                dataGridView1.Rows[i].Cells["cdlsellprice"].Value = txtsellingprice.Text;
                dataGridView1.Rows[i].Cells["cdlcolour"].Value = txtcolour.Text;
                dataGridView1.Rows[i].Cells["cdlweight"].Value = txtweignt.Text;
                dataGridView1.Rows[i].Cells["cdlcarat"].Value = cbocarat.Text;
                dataGridView1.Rows[i].Cells["cdltotal"].Value = txttotal.Text;

                i++;
            }

        }
        public void purchaseentry()
        {

            int i = blinv.insertinvoicenodate(Convert.ToInt32(txtinvoiceno.Text), Convert.ToDateTime(dtpdate.Text));
            if (i > 0)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    int invoice_no = Convert.ToInt32(dataGridView1.Rows[j].Cells["cdlinvoiceno"].Value.ToString());
                    string supplier_name = dataGridView1.Rows[j].Cells["cdlsuppilername"].Value.ToString();
                    DateTime invoice_date = Convert.ToDateTime(dataGridView1.Rows[j].Cells["cdlinvoicedate"].Value.ToString());
                    int supplier_bill_no = Convert.ToInt32(dataGridView1.Rows[j].Cells["cdlsuppbillno"].Value.ToString());
                    int item_code = Convert.ToInt32(dataGridView1.Rows[j].Cells["cdlitemcode"].Value.ToString());
                    int item_bar_code = Convert.ToInt32(dataGridView1.Rows[j].Cells["cdlitembarcode"].Value.ToString());
                    string item_category = dataGridView1.Rows[j].Cells["cdlitemcategory"].Value.ToString();
                    string item_name = dataGridView1.Rows[j].Cells["cdlitemname"].Value.ToString();
                    int quantity = Convert.ToInt32(dataGridView1.Rows[j].Cells["cdlquantity"].Value.ToString());
                    decimal market_price = Convert.ToDecimal(dataGridView1.Rows[j].Cells["cdlmarketprice"].Value.ToString());
                    decimal cost_price = Convert.ToDecimal(dataGridView1.Rows[j].Cells["cdlcostprice"].Value.ToString());
                    decimal discount = Convert.ToDecimal(dataGridView1.Rows[j].Cells["cdldiscount"].Value.ToString());
                    decimal margin_percent = Convert.ToDecimal(dataGridView1.Rows[j].Cells["cdlmargpercent"].Value.ToString());
                    decimal margin_discount = Convert.ToDecimal(dataGridView1.Rows[j].Cells["cdlmargdiscount"].Value.ToString());
                    decimal sell_price = Convert.ToDecimal(dataGridView1.Rows[j].Cells["cdlsellprice"].Value.ToString());
                    string colour = dataGridView1.Rows[j].Cells["cdlcolour"].Value.ToString();
                    decimal weight = Convert.ToDecimal(dataGridView1.Rows[j].Cells["cdlweight"].Value.ToString());
                    int carat = Convert.ToInt32(dataGridView1.Rows[j].Cells["cdlcarat"].Value.ToString());
                    decimal total = Convert.ToDecimal(dataGridView1.Rows[j].Cells["cdltotal"].Value.ToString());

                    int k = blpur.insertintopurchase(invoice_no, invoice_date, item_category, item_name, quantity, weight, market_price, cost_price, discount, margin_percent, margin_discount, sell_price, colour, item_code, item_bar_code, supplier_bill_no, supplier_name, carat, total);
                }
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = blsto.checkquantity(cboitemname.Text);
            if (dt.Rows.Count == 0)
            {
                for (int a = 0; a < dataGridView1.Rows.Count; a++)
                {
                    string product_name = (dataGridView1.Rows[a].Cells["cdlitemname"].Value.ToString());
                    int quantity = Convert.ToInt32(dataGridView1.Rows[a].Cells["cdlquantity"].Value.ToString());

                    int b = blsto.addquantity(Convert.ToInt32(quantity), product_name);
                }
                purchaseentry();
                purchase_by();
                MessageBox.Show("Quantity Has been Added");

            }
            else
            {
                purchaseentry();
                purchase_by();
                stockentry();
                MessageBox.Show("Purchase Data Has Been Save To Database");
            }
            
        }

        public void purchase_by()
        {
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                int invoice_no = Convert.ToInt32(dataGridView1.Rows[j].Cells["cdlinvoiceno"].Value.ToString());
                DateTime invoice_date = Convert.ToDateTime(dataGridView1.Rows[j].Cells["cdlinvoicedate"].Value.ToString());
                string item_name = dataGridView1.Rows[j].Cells["cdlitemname"].Value.ToString();

                int k = blpur.purchasetype(invoice_no, invoice_date, item_name, Convert.ToDecimal(txtpaidamount.Text), txtpurchasetype.Text, txtpurchaseby.Text);

            }
        }
        public void stockentry()
        {
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                string item_code = (dataGridView1.Rows[j].Cells["cdlitemcode"].Value.ToString());
                string item_bar_code = dataGridView1.Rows[j].Cells["cdlitembarcode"].Value.ToString();
                string item_name = dataGridView1.Rows[j].Cells["cdlitemname"].Value.ToString();
                int quantity = Convert.ToInt32(dataGridView1.Rows[j].Cells["cdlquantity"].Value.ToString());
                decimal sell_price = Convert.ToDecimal(dataGridView1.Rows[j].Cells["cdlsellprice"].Value.ToString());
                decimal weight = Convert.ToDecimal(dataGridView1.Rows[j].Cells["cdlweight"].Value.ToString());
            
                

                    int k = blsto.purchaseintryinstock(item_code, item_bar_code, item_name, quantity, weight, sell_price);
                
            }
        }
        public void forbarcode()
        {
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                string item_code = (dataGridView1.Rows[j].Cells["cdlitemcode"].Value.ToString());
                string item_bar_code = dataGridView1.Rows[j].Cells["cdlitembarcode"].Value.ToString();
                string item_name = dataGridView1.Rows[j].Cells["cdlitemname"].Value.ToString();
                decimal sell_price = Convert.ToDecimal(dataGridView1.Rows[j].Cells["cdlsellprice"].Value.ToString());
                decimal weight = Convert.ToDecimal(dataGridView1.Rows[j].Cells["cdlweight"].Value.ToString());
                int quantity = 1;
                decimal stone = 1000;

                int k = blsto.forbarcode(item_code, item_bar_code, item_name, weight, sell_price, quantity, stone);
            }
        }
    }
}




