using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKT2tr5.Models.Entities
{
    public class Tinh
    {
        public int TinhId { get; set; }
        public string TenTinh { get; set; }
        public List<Xe> Xe { get; set; }
    }
}
