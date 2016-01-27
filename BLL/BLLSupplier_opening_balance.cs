using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLSupplier_opening_balance
    {
        public int insertintotable(int opening_id, DateTime opening_date, string account_name,decimal amount, char dt_cr) {
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@opening_id",opening_id),
                new SqlParameter("@opening_date",opening_date),
                new SqlParameter("@account_name",account_name),
                new SqlParameter("@amount",amount),
                new SqlParameter("@dt_cr",dt_cr)

            };
            return DOA.IDU("insert into tbl_supplier_account_opening values(@opening_id,@opening_date,@account_name,amount,@dt_cr)", param);
            
        }


        public DataTable FetchAllData() {
            DataTable dt = new DataTable();
            return DOA.getdata("select opening_date as Date, account_name as AccountName, amount as Amount , dt_cr as DebitCredit from tbl_supplier_account_opening ",null);

        }
    }
}
