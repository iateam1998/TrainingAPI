using DataService.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Model.ViewModel
{
    public class SubjectTeacherViewModel : BaseViewModel<SubjectTeacher>
    {
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        public virtual SubjectViewModel Subject { get; set; }
        public virtual TeacherViewModel Teacher { get; set; }
    }
}
