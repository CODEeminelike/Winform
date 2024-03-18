using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DAL
{
    public class ThanhToan
    {
        public int MaHD { get; set; }
        public int MaKH { get; set; }
        public string HinhThucThanhToan { get; set; }
        public decimal TongTien { get; set; }

        public ThanhToan(int maKH, string hinhThucThanhToan, decimal tongTien)
        {
            MaKH = maKH;
            HinhThucThanhToan = hinhThucThanhToan;
            TongTien = tongTien;
        }
    }
}
