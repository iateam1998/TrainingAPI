using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class TeacherClasses
    {
        public int TeacherId { get; set; }
        public int ClassId { get; set; }

        public virtual Classes Class { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
