using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class SubjectTeacher
    {
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
