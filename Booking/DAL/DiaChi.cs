using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DAL
{
    public class DiaChi
    {
        public int MaKS { get; set; }
        public string ThanhPho { get; set; }
        public string Quan { get; set; }
        public string Phuong { get; set; }

        public DiaChi(string thanhPho, string quan, string phuong)
        {
            ThanhPho = thanhPho;
            Quan = quan;
            Phuong = phuong;
        }
    }
}
