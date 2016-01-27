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
    public class BLLItem
    {
        public int additem(int category_id, string item_name,int item_code)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@category_id",category_id),
                new SqlParameter("@item_name",item_name),
                new SqlParameter("@item_code",item_code)
            };

            return DOA.IDU("insert into tbl_item values(@category_id,@item_name,@item_code)", parm);
        }

        public DataTable getallitem()
        {
            DataTable dt = new DataTable();
            dt = DOA.getdata("select * from tbl_item", null);
            return dt;
        }
        public int updateitem(int category_id, string item_name,int item_id,int item_code)
        {
            SqlParameter[] parm = new SqlParameter[]
                {
                    new SqlParameter("@category_id",category_id),
                    new SqlParameter("@item_name",item_name),
                    new SqlParameter("@item_id",item_id),
                    new SqlParameter("@item_code",item_code)
                
                };
            return DOA.IDU("update tbl_item set category_id=@category_id,item_name=@item_name,item_code=@item_code where item_id=@item_id", parm);
        }
        public DataTable getitembycategoryid(int category_id)
        {
            SqlParameter[] parm = new SqlParameter[]
             {
            new SqlParameter ("@category_id", category_id)
             };
            DataTable dt = new DataTable();
            dt = DOA.getdata("select * from tbl_item where category_id=@category_id", parm);
            return dt;
        }
    }
}
