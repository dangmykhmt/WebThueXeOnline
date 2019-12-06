using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKT2tr5.Models.Entities
{
    public class NhaSanXuat
    {
        public int NhaSanXuatId { get; set; }
        public string TenNSX { get; set; }
        public List<DongXe> DongXe { get; set; }
    }
}
