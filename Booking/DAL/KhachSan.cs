using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DAL
{
    public class KhachSan
    {
        public int MaKS { get; set; }
        public string TenKS { get; set; }
        public string MoTa { get; set; }
        public string DiaChiTiet { get; set; }
        public bool DangHoatDong { get; set; }
        public string SDTKS { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }

        public KhachSan(string tenKS, string moTa, string diaChiTiet, bool dangHoatDong, string sDTKS, string email, string matKhau)
        {
            TenKS = tenKS;
            MoTa = moTa;
            DiaChiTiet = diaChiTiet;
            DangHoatDong = dangHoatDong;
            SDTKS = sDTKS;
            Email = email;
            MatKhau = matKhau;
        }
    }
}
