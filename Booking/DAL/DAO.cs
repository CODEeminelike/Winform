using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Booking.DAL
{
    public class DAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public List<T> LayDanhSach<T>(string tenBang, string tenCot)
        {
            try
            {
                conn.Open();
                string query = String.Format("Select {0} From {1}", tenCot, tenBang);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                List<T> result = new List<T>();
                while (reader.Read())
                {
                    result.Add((T)reader[tenCot]);
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
                return new List<T>();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


    }
}
