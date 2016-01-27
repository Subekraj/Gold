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
    public partial class Add_Update_Delete_Items_update : Form
    {
        public Add_Update_Delete_Items_update()
        {
            InitializeComponent();
        }
        BLLItem_Add_Update iau = new BLLItem_Add_Update();
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Update_Delete_Items_update_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int update = iau.UpdateIntoTable(Convert.ToInt32(cbo_syn.Text),Convert.ToInt32(txt_barcode.Text),cbo_category.Text,cbo_item.Text,Convert.ToDecimal(txt_cost_price.Text),Convert.ToDecimal(txt_sell_price.Text),Convert.ToDecimal(txt_martket_price.Text),Convert.ToInt32(cbo_unit.Text),Convert.ToInt32(txt_stock.Text),Convert.ToInt32(txt_min.Text),Convert.ToInt32(txt_max));

            if (update > 0) {
                MessageBox.Show("Data Updated");
            }

        }
    }
}
