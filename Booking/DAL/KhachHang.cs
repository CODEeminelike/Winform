using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DAL
{
    public class KhachHang
    {
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDTKH { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }

        public KhachHang(string tenKH, string sDTKH, string email, string matKhau)
        {
            TenKH = tenKH;
            SDTKH = sDTKH;
            Email = email;
            MatKhau = matKhau;
        }
    }
}
