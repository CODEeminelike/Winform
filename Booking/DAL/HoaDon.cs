using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DAL
{
    public class HoaDon
    {
        public int MaHD { get; set; }
        public DateTime ThoiGianLapHD { get; set; }
        public string TrangThaiThanhToan { get; set; }

        public HoaDon(DateTime thoiGianLapHD, string trangThaiThanhToan)
        {
            ThoiGianLapHD = thoiGianLapHD;
            TrangThaiThanhToan = trangThaiThanhToan;
        }
    }
}
