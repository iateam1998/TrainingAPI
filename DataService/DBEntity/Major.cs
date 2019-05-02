using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Major
    {
        public Major()
        {
            SinhVien = new HashSet<SinhVien>();
            Subject = new HashSet<Subject>();
        }

        public string Id { get; set; }
        public string Major1 { get; set; }

        public virtual ICollection<SinhVien> SinhVien { get; set; }
        public virtual ICollection<Subject> Subject { get; set; }
    }
}
