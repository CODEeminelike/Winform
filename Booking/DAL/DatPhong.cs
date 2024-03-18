using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DAL
{
    public class DatPhong
    {
        public int MaKH { get; set; }
        public int MaPhong { get; set; }
        public int SoNguoi { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
        public decimal TienDatTruoc { get; set; }

        public DatPhong(int soNguoi, DateTime ngayBD, DateTime ngayKT, decimal tienDatTruoc)
        {
            SoNguoi = soNguoi;
            NgayBD = ngayBD;
            NgayKT = ngayKT;
            TienDatTruoc = tienDatTruoc;
        }
    }
}
