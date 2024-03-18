using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DAL
{
    public class LapHD
    {
        public int MaHD { get; set; }
        public int MaPhong { get; set; }

        public LapHD(int maPhong)
        {
            MaPhong = maPhong;
        }
    }
}
