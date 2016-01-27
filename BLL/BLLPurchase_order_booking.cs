using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class BLLPurchase_order_booking
    {
        public int insertintotable(DateTime order_date,int new_pob_id, int existing_pob_id,string supplier_name,string item_name,int quantity){
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@order_date",order_date),
                    new SqlParameter("@new_pob_id",new_pob_id),
                  new SqlParameter("@existing_pob_id",existing_pob_id),
                    new SqlParameter("@supplier_name",supplier_name),
                 new SqlParameter("@item_name",item_name),
                 new SqlParameter("@quantity",quantity)

            };
            return DOA.IDU("insert into tbl_purchase_order_booking values(@order_date,@new_pob_id,@existing_pob_id,@supplier_name,@item_name,@quantity)", parm);
            
            }
    }
}
