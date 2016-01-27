using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPurchase
    {
        public int insertintopurchase(int invoice_no, DateTime invoice_date, string item_category, string item_name, int quantity, decimal weight, decimal market_price, decimal cost_price, decimal discount, decimal margin_percent, decimal margin_discount, decimal sell_price, string colour, int item_code, int item_bar_code, int suppiler_bill_no, string supplier_name, int carat, decimal Total)

        {
            SqlParameter[] parm = new SqlParameter[]
            {
          new SqlParameter("@invoice_no",invoice_no),
          new  SqlParameter("@invoice_date",invoice_date),
           new SqlParameter("@item_category",item_category),
          new  SqlParameter("@item_name",item_name),
          new SqlParameter("@quantity",quantity),
          new  SqlParameter("@weight",quantity),
          new SqlParameter("@market_price",market_price),
          new SqlParameter("@cost_price",cost_price),
          new SqlParameter("@discount",discount),
          new SqlParameter("@margin_percent",margin_percent),
          new SqlParameter("@margin_discount",margin_discount),
           new SqlParameter("@sell_price",sell_price),
          new SqlParameter("@colour",colour),
           new SqlParameter("@item_code",item_code),
          new SqlParameter("@item_bar_code",item_bar_code),
           new SqlParameter("@suppiler_bill_no",suppiler_bill_no),
           new SqlParameter("@supplier_name",supplier_name),
           new SqlParameter("@carat",carat),
          new SqlParameter("@Total",Total)
          };
            return DOA.IDU("insert into tbl_purchase values(@invoice_no,@invoice_date,@item_category,@item_name,@quantity,@weight,@market_price,@cost_price,@discount,@margin_percent,@margin_discount,@sell_price,@colour,@item_code, @item_bar_code, @suppiler_bill_no,@supplier_name,@carat,@Total)", parm);
           
        }
        public int purchasetype(int invoice_no, DateTime purchase_date,string item_name, decimal paid_amount, string purchase_type, string purchase_by)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@invoice_no",invoice_no),
                  new SqlParameter("@purchase_date",purchase_date),
                    new SqlParameter("@item_name",item_name),
                      new SqlParameter("@paid_amount",paid_amount),
                        new SqlParameter("@purchase_type",purchase_type),
                          new SqlParameter("@purchase_by",purchase_by)
            };
            return DOA.IDU("insert into tbl_purchase_by values(@invoice_no,@item_name,@paid_amount,@purchase_type,@purchase_by,@purchase_date)", parm);
        }
        
    }
   

}
