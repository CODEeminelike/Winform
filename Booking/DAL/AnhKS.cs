using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DAL
{
    public class AnhKS
    {
        public int MaKS { get; set; }
        public string DD { get; set; }

        public AnhKS(string dD)
        {
            DD = dD;
        }
    }
}
