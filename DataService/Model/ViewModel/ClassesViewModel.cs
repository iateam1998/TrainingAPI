using DataService.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Model.ViewModel
{
    public class ClassesViewModel : BaseViewModel<Classes>
    {
        public int Id { get; set; }
        public string ClassName { get; set; }

        public virtual ICollection<SinhVienViewModel> SinhVien { get; set; }
        public virtual ICollection<TeacherClassesViewModel> TeacherClasses { get; set; }
    }
}
