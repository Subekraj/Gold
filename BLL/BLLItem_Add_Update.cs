using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;


namespace BLL
{
   public class BLLItem_Add_Update
    {
        public DataTable FetchAllData() {
                  
          return  DOA.getdata("Select * from item_add_update", null);
        }


        public int InsertIntoTable(int barcode, string category , string item, decimal sell_price, int quantity, string item_code, int weight, decimal labour_charge) {

            SqlParameter [] parm = new SqlParameter[]{
                new SqlParameter("@barcode",barcode),
                new SqlParameter("@category",category),
                new SqlParameter("@item",item),
                new SqlParameter("@sell_price",sell_price),
                new SqlParameter("@quantity",quantity),
                new SqlParameter("@item_code",item_code),
                new SqlParameter("@weight",weight),
                new SqlParameter("@labour_charge",labour_charge)

            };

            return DOA.IDU("insert into item_add_update values(@barcode,@category,@item,@sell_price,@quantity,@item_code, @weight,@labour_charge)",parm);

        }

        public int UpdateIntoTable(int syn_no, int barcode, string category, string item, decimal cost_price, decimal sell_price, decimal mark_price, int unit, int stock, int minimum, int maximum)
        {

            SqlParameter[] parm = new SqlParameter[]{

                new SqlParameter("@syn_no",syn_no),
                new SqlParameter("@barcode",barcode),
                new SqlParameter("@category",category),
                new SqlParameter("@item",item),
                new SqlParameter("@cost_price",cost_price),
                new SqlParameter("@sell_price",sell_price),
                new SqlParameter("@mark_price",mark_price),
                new SqlParameter("@unit",unit),
                new SqlParameter("@stock",stock),
                new SqlParameter("@minimum",minimum),
                new SqlParameter("@maximum",maximum)
            };

            return DOA.IDU("update table item_add_update set syn_no=@syn_no,barcode=@barcode,category=@category,item=@item,cost_price=@cost_price,sell_price= @sell_price, mark_price=@mark_price,unit=@unit,stock=@stock,minimum= @minimum,maximum= @maximum", parm);

        }

    }
}
