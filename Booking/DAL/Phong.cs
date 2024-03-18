using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DAL
{
    public class Phong
    {
        public int MaPhong { get; set; }
        public decimal Gia { get; set; }
        public int SoNguoiToiDa { get; set; }
        public int SoGiuong { get; set; }

        public Phong(decimal gia, int soNguoiToiDa, int soGiuong)
        {
            Gia = gia;
            SoNguoiToiDa = soNguoiToiDa;
            SoGiuong = soGiuong;
        }
    }
}
