using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DOA
    {
        public static string connectionstr = "Data Source=Localhost;Initial Catalog=Gold;Integrated Security=True";

        public static SqlConnection getconnection()
        {
           
        SqlConnection scon = new SqlConnection(connectionstr);


            if (scon.State != ConnectionState.Open)
            {

                scon.Open();

            }
            return scon;


        }
        public static int IDU(string sql, SqlParameter[] parm)
        {

            using (SqlConnection scon = getconnection())
            {
                SqlCommand scmd = new SqlCommand(sql, scon);
                scmd.Parameters.AddRange(parm);
                try
                {

                    return scmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }



        }
        public static DataTable getdata(string sql, SqlParameter[] parm)
        {

            using (SqlConnection scon = getconnection())
            {
                SqlCommand scmd = new SqlCommand(sql, scon);

                if (parm != null)
                {
                    scmd.Parameters.AddRange(parm);
                }

                SqlDataAdapter sda = new SqlDataAdapter(scmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;


            }

        }
        public static SqlDataReader getreader(string sql, SqlParameter[] parm)
        {
            using (SqlConnection scon = getconnection())
            {

                SqlCommand scmd = new SqlCommand(sql, scon);

                if (parm != null)
                {
                    scmd.Parameters.AddRange(parm);
                }

                SqlDataReader dr = scmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
        }
    }

}
