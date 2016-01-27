using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLInvoice
    {
        public int insertinvoicenodate(int invoice_no, DateTime invoice_date)
        {
            SqlParameter[] parm = new SqlParameter[]
                {
                    new SqlParameter("invoice_no",invoice_no),
                    new SqlParameter("invoice_date",invoice_date)
                };
            return DOA.IDU("insert into tbl_invoices values(@invoice_no,@invoice_date)", parm);
        }
        public DataTable getinvoiceno()
        {
            return DOA.getdata("select * from tbl_invoices", null);
        }
    }
}
