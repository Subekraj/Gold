using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public  class BLLSell
    {
        public int insertallsells(int bill_no,DateTime bill_date,string customer_name,int customer_no,string item_name,decimal weight,int quantity,decimal sell_price,decimal labour_charge,decimal stone_charge, decimal total,string sells_by)
        {
            SqlParameter[] parm = new SqlParameter[]
                {
                    new SqlParameter("@bill_no",bill_no),
                    new SqlParameter("@bill_date",bill_date),
                    new SqlParameter("@customer_name",customer_name),
                    new SqlParameter("@customer_no",customer_no),
                    new SqlParameter("@item_name",item_name),
                    new SqlParameter("@weight",weight),
                    new SqlParameter("@quantity",quantity),
                    new SqlParameter("@sell_price",sell_price),
                    new SqlParameter("@total",total),
                    new SqlParameter("@labour_charge",labour_charge),
                    new SqlParameter("@stone_charge",stone_charge),
                    new SqlParameter("@sell_by",sells_by)

                };
            return DOA.IDU("insert into tbl_sells values(@bill_no,@bill_date,@customer_no,@customer_name,@item_name,@weight,@quantity,@sell_price,@stone_charge,@labour_charge,@total,@sell_by)", parm);
           
        }

        public int insert_sellenrty(int bill_no, DateTime bill_date, string customer_name, int customer_no, decimal sub_total,decimal cash_amount,decimal card_amount,decimal discount,decimal grand_total, string payment_recive,string payment_type)
        {
            SqlParameter[] parm = new SqlParameter[]
                {
                    new SqlParameter("@bill_no",bill_no),
                    new SqlParameter("@bill_date",bill_date),
                    new SqlParameter("@customer_name",customer_name),
                    new SqlParameter("@customer_no",customer_no),
                    new SqlParameter("@sub_total",sub_total),
                    new SqlParameter("@grand_total",grand_total),
                    new SqlParameter("@discount",discount),
                    new SqlParameter("@payment_recive",payment_recive),
                     new SqlParameter("@payment_type",payment_type),
                     new SqlParameter("@cash_amount",cash_amount),
                     new SqlParameter("@card_amount",card_amount)

                };
            return DOA.IDU("insert into tbl_sell_entryii values(@bill_no,@bill_date,@customer_name,@customer_no,@payment_type,@payment_recive,@cash_amount,@card_amount,@sub_total,@discount,@grand_total)", parm);

        }
    }
}
