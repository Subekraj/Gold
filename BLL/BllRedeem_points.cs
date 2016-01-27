using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class BllRedeem_points
    {
        public int insertintotable(string customer, int redeem_point, DateTime redeem_date, string gifts, string redeem_mode) {
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@customer",customer),
                 new SqlParameter("@redeem_point",redeem_point),
                  new SqlParameter("@redeem_date",redeem_date),
                   new SqlParameter("@gifts",gifts),
                    new SqlParameter("@redeem_mode",redeem_mode)


            };
            return DOA.IDU("insert into tbl_redeem_points values(@customer,@redeem_point,@redeem_date,@gifts,@redeem_mode)", parm);

        }
    }
}
