﻿using HKT2tr5.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKT2tr5.Models
{
    public class IndexModelView
    {
        public Xe Xe { get; set; }
        public List<Xe> Xes { get; set; }
        public SearchXeViewModel SearchXeViewModel { get; set; }
        //public int LoaiXeId { get; set; }
        //public int DongXeId { get; set; }
        //public int NhaSanXuatId { get; set; }
    }
}
