using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Subject
    {
        public Subject()
        {
            SubjectTeacher = new HashSet<SubjectTeacher>();
        }

        public int Id { get; set; }
        public string Subject1 { get; set; }
        public string MajorId { get; set; }
        public string Description { get; set; }

        public virtual Major Major { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeacher { get; set; }
    }
}
