using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DAL
{
    public class DangPhong
    {
        public int MaPhong { get; set; }
        public int MaKS { get; set; }
        public DateTime NgayDang { get; set; }

        public DangPhong(int maKS, DateTime ngayDang)
        {
            MaKS = maKS;
            NgayDang = ngayDang;
        }
    }
}
