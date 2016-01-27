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
    public class BLLStock
    {
        public int purchaseintryinstock(string item_code, string bar_code, string item_name, int quantity, decimal weight, decimal cost)
        {
            SqlParameter[] parm = new SqlParameter[]
                {
                    new SqlParameter("@item_code",item_code),
                      new SqlParameter("@bar_code",bar_code),
                        new SqlParameter("@item_name",item_name),
                          new SqlParameter("@quantity",quantity),
                            new SqlParameter("@weight",weight),
                              new SqlParameter("@cost",cost)
                };
            return DOA.IDU("insert into tbl_stock values(@item_code,@bar_code,@item_name,@quantity,@weight,@cost)", parm);

        }
        public DataTable checkquantity(string item_name)
        {
            SqlParameter[] parm = new SqlParameter[]
                {
                    new SqlParameter("@item_name",item_name)
                };
            return DOA.getdata("select * from tbl_stock where item_name=@item_name", parm);
        }

        public int addquantity(int quantity, string item_name)
        {
            SqlParameter[] parm = new SqlParameter[]
         {
         new SqlParameter("@quantity",quantity),
         new SqlParameter("@item_code",item_name)
         };
            return DOA.IDU("UPDATE tbl_stock SET quantity = @quantity + quantity WHERE item_code=@item_code", parm);
        }
        public DataTable getallstockbyname(string item_code)
        {
            SqlParameter[] parm = new SqlParameter[]
          {
             new SqlParameter("@item_code",item_code),
              //new SqlParameter("@item_name",item_name),
              //  new SqlParameter("@weight",weight),
              //    new SqlParameter("@cost",cost)
          };
            return DOA.getdata("SELECT * FROM tbl_barcode_info where item_code=@item_code", parm);
        }
        public int forbarcode(string item_code, string barcode, string item_name, decimal weight, decimal rate,int quantity,decimal stone)
        {
            SqlParameter[] parm = new SqlParameter[]
                {
                    new SqlParameter("@item_code",item_code),
                    new SqlParameter("@barcode",barcode),
                        new SqlParameter("@item_name",item_name),
                            new SqlParameter("@weight",weight),
                              new SqlParameter("@rate",rate),
                              new SqlParameter("@quantity",quantity),
                              new SqlParameter("@stone",stone)
                };
            return DOA.IDU("insert into tbl_barcode Values(@item_code,@barcode,@item_name,@weight,@rate,@quantity,@stone)", parm);
        }
    }

 }
 