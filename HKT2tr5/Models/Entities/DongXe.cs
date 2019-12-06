using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKT2tr5.Models.Entities
{
    public class DongXe
    {
        public int DongXeId { get; set; }
        public string TenDongXe { get; set; }
        public List<MauDongXe> MauDongXe { get; set; }
        public NhaSanXuat NhaSanXuat { get; set; }
        public int NhaSanXuatId { get; set; }
        public List<Xe> Xe { get; set; }
    }
}
