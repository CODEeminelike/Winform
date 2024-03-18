using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DAL
{
    public class DanhGia
    {
        public int MaHD { get; set; }
        public int MaKH { get; set; }
        public int SoSao { get; set; }
        public string NhanXet { get; set; }

        public DanhGia(int maKH, int soSao, string nhanXet)
        {
            MaKH = maKH;
            SoSao = soSao;
            NhanXet = nhanXet;
        }
    }
}
