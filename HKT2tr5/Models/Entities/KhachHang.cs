using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKT2tr5.Models.Entities
{
    public class KhachHang
    {
        public int KhachHangId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public string Address { get; set; }
        public List<ChiTietThueXe> ChiTietThueXe { get; set; }
    }
}
