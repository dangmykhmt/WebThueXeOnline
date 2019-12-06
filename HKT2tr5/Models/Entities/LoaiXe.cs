using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKT2tr5.Models.Entities
{
    public class LoaiXe
    {
        public int LoaiXeId { get; set; }
        public string TenLoaiXe { get; set; }
        public List<Xe> Xe { get; set; }
    }
}
