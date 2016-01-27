using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
   public class BLLAccounts_Journal_entry
    {
        public int  InsertIntoTable(DateTime date, string voucher_type, int new_id, int existing_id, string account_name, string dr_cr, decimal amount,string narration){
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@date",date),
                new SqlParameter("@voucher_type",voucher_type),
                new SqlParameter("@new_id",new_id),
                new SqlParameter("@existing_id",existing_id),
                new SqlParameter("@account_name",account_name),
                new SqlParameter("@dr_cr",dr_cr),
                new SqlParameter("@amount",amount),
                new SqlParameter("@narration",narration)
               

            };
            return DOA.IDU("insert into tbl_account_journal_entry values(@date,@voucher_type,@new_id,@existing_id,@account_name,@dr_cr,@amount,@narration)", parm);
            
            
            }

        public DataTable showalldata() {
           // return DOA.getdata("select  voucher_type as VoucherType, date as DateOfEntry , dr_cr as DrCr ,account_name as AccountName, amount as Amount , narration as Narration, debit as Debit , credit as Credit from tbl_account_journal_entry", null);
            return DOA.getdata("select * from  tbl_account_journal_entry",null);
        }
    }
}
