using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanlybanhangFAHASA
{
    class ketnoi
    {
        /*Data Source = truongtn - db.database.windows.net; Initial Catalog = BANHANGFAHASA; Persist Security Info=True;User ID = truongtn; Password=Admin@1999*/
        private string connectString = "Data Source=truongtn-db.database.windows.net;Initial Catalog=BANHANGFAHASA;Persist Security Info=True;User ID=truongtn;Password=Admin@1999";
        private SqlConnection conn = null;
        public SqlConnection getConnect()
        {
             conn = new SqlConnection(connectString);
            conn.Open();
            return conn;
        }

        public void closeConnect()
        {
            if (conn != null)
                conn.Close();
        }

        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection ketnoi = new SqlConnection(connectString))
            {
                ketnoi.Open();
                SqlCommand thucthi = new SqlCommand(query, ketnoi);
                data = thucthi.ExecuteNonQuery();
                ketnoi.Close();
            }
            return data;
        }


        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection KetNoi = new SqlConnection(connectString))
            {
                KetNoi.Open();
                SqlCommand ThucThi = new SqlCommand(query, KetNoi);
                SqlDataAdapter LayDuLieu = new SqlDataAdapter(ThucThi);
                LayDuLieu.Fill(dt);

                KetNoi.Close();
            }
            return dt;
        }
        
    }
}
