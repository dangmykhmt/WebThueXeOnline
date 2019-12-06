using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKT2tr5.Models.Entities
{
    public class ChiTietThueXe
    {
        public int ChiTietThueXeId { get; set; }
        public int KhachHangId { get; set; }
        public int XeId { get; set; }
        public Xe Xe { get; set; }
        public KhachHang KhachHang { get; set; }
    }
}
