using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Teacher
    {
        public Teacher()
        {
            SubjectTeacher = new HashSet<SubjectTeacher>();
            TeacherClasses = new HashSet<TeacherClasses>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<SubjectTeacher> SubjectTeacher { get; set; }
        public virtual ICollection<TeacherClasses> TeacherClasses { get; set; }
    }
}
