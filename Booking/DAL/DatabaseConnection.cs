using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DAL
{
    public static class DatabaseConnection
    {
        public static SqlConnection Conn { get; set; }

        static DatabaseConnection()
        {
            
            Conn = new SqlConnection(Properties.Settings.Default.connStr);
        }
    }

}
