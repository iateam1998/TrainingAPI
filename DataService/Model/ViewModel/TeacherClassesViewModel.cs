using DataService.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Model.ViewModel { 
    public class TeacherClassesViewModel : BaseViewModel<TeacherClasses>
    {
        public int TeacherId { get; set; }
        public int ClassId { get; set; }

        public virtual ClassesViewModel Class { get; set; }
        public virtual TeacherViewModel Teacher { get; set; }
    }
}
