﻿using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class SinhVien
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Mssv { get; set; }
        public string MajorId { get; set; }
        public int ClassId { get; set; }
        public string Note { get; set; }

        public virtual Classes Class { get; set; }
        public virtual Major Major { get; set; }
    }
}
