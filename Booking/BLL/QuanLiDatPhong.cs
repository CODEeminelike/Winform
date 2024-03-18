using Booking.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.BLL
{
    public class QuanLiDatPhong
    {
        DAO dao = new DAO();
        public List<String> taoDanhSachDiaChi(String ThanhPho)
        {
            List<String> list = new List<String>();
            list = dao.LayDanhSach<String>("DiaChi", ThanhPho);
            return list;
        }
    }
}
