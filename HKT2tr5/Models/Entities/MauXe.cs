using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKT2tr5.Models.Entities
{
    public class MauXe
    {
        public int MauXeId { get; set; }
        public string TenMauXe { get; set; }
        public List<MauDongXe> MauDongXe { get; set; }
    }
}
