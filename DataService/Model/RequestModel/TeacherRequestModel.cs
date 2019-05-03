using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Model.RequestModel
{
    public class TeacherRequestModel
    {
        public int? TeacherId { get; set; }
        //public int? TeacherId { get; set; }
        public string MajorId { get; set; }
        public int? SubjectId { get; set; }
        public int? SinhVienId { get; set; }
    }
}
