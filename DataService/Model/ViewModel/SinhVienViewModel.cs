using DataService.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Model.ViewModel
{
    public class SinhVienViewModel : BaseViewModel<SinhVien>
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Mssv { get; set; }
        public string MajorId { get; set; }
        public int ClassId { get; set; }
        public string Note { get; set; }

        public virtual ClassesViewModel Class { get; set; }
        public virtual Major Major { get; set; }
    }
}
