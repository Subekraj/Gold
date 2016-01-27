using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public  class BLLSells
    {
        public int sellsenter(int bill_no,DateTime bill_date,int customer_no,string customer_name,string item_name,decimal weight,int quantity,decimal sell_price,decimal stone_charge,decimal labour_charge,decimal total,string sell_by)
        {
            SqlParameter[] parm = new SqlParameter[]
                {
                    new SqlParameter("@bill_no",bill_no),
                     new SqlParameter("@bill_date",bill_date),
                      new SqlParameter("@customer_no",customer_no),
                      new SqlParameter("@customer_name",customer_name),
                       new SqlParameter("@item_name",item_name),
                        new SqlParameter("@weight",weight),
                        new SqlParameter("@quantity",quantity),
                        new SqlParameter("@sell_price",sell_price),
                        new SqlParameter("@stone_charge",stone_charge),
                        new SqlParameter("@labour_charge",labour_charge),
                        new SqlParameter("@total",total),
                         new SqlParameter("@sell_by",sell_by)

                };
            return DOA.IDU("insert into tbl_sells values(@bill_no,@bill_date,@customer_no,@customer_name,@item_name,@weight,@quantity,@sell_price,@stone_charge,@labour_charge,@total,@sell_by)", parm);

        }
    }
}
