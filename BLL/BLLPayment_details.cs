using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class BLLPayment_details
    {
        public int insertintotable(int payment_no, DateTime payment_date, DateTime payments_dates, string supplier, int bill_no, string mode, string bank, int chk_dr_no,DateTime chk_dr_date,  decimal amount, decimal pay_amount, string remarks) {
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@payment_no",payment_no),
                new SqlParameter("@payment_date",payment_date),
                     new SqlParameter("@payments_dates",payments_dates),
                      new SqlParameter("@supplier",supplier),
                      new SqlParameter("@bill_no",bill_no),
                       new SqlParameter("@mode",mode),
                        new SqlParameter("@bank",bank),
                          new SqlParameter("@chk_dr_no",chk_dr_no),
                            new SqlParameter("@chk_dr_date",chk_dr_date),
                              new SqlParameter("@amount",amount),
                                new SqlParameter("@pay_amount",pay_amount),
                                  new SqlParameter("@remarks",remarks)

            };

            return DOA.IDU("insert into payment_details values(@payment_no,@payment_date,@payments_dates,@supplier,@bill_no,@mode,@chk_dr_no,@chk_dr_date,@bank,@amount,@pay_amount,@remarks)", parm);
        }

        //public DataTable (){
        //    return DOA.getdata("",null);


        //}

    }
}
