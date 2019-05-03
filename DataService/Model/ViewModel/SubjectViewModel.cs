using DataService.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Model.ViewModel
{
    public class SubjectViewModel : BaseViewModel<Subject>
    {
        public int Id { get; set; }
        public string Subject1 { get; set; }
        public string MajorId { get; set; }
        public string Description { get; set; }

        public virtual Major Major { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeacher { get; set; }
    }
}
