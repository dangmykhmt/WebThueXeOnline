using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKT2tr5.Models
{
    public class SearchXeViewModel
    {
        public int DongXeId { get; set; }
        public int MauXeId { get; set; }
        public int TinhId { get; set; }
        public int LoaiXeId { get; set; }
        public int NhaSanXuatId { get; set; }
        public bool SearchAll { get; set; }
    }
}
