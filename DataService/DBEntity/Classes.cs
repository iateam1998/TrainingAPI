using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Classes
    {
        public Classes()
        {
            SinhVien = new HashSet<SinhVien>();
            TeacherClasses = new HashSet<TeacherClasses>();
        }

        public int Id { get; set; }
        public string ClassName { get; set; }

        public virtual ICollection<SinhVien> SinhVien { get; set; }
        public virtual ICollection<TeacherClasses> TeacherClasses { get; set; }
    }
}
