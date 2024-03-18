using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DAL
{
    public class AnhPhong
    {
        public int MaPhong { get; set; }
        public string DD { get; set; }

        public AnhPhong(string dD)
        {
            DD = dD;
        }
    }
}
