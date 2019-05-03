using DataService.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Model.ViewModel
{
    public class MajorViewModel : BaseViewModel<Major>
    {
        public string Id { get; set; }
        public string Major1 { get; set; }

        public virtual ICollection<SinhVien> SinhVien { get; set; }
        public virtual ICollection<Subject> Subject { get; set; }
    }
}
