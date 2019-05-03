using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Model.RequestModel
{
    public class SinhVienRequestModel
    {
        public string MajorId { get; set; }
        public int? SubjectId { get; set; }
        public int? SinhVienId { get; set; }
        public int? ClassId { get; set; }
        public string MSSV { get; set; }
        public int? TeacherId { get; set; }
    }
}   
