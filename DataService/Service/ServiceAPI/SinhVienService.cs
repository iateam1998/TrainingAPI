using AutoMapper;
using DataService.DBEntity;
using DataService.Model.RequestModel;
using DataService.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.Service.ServiceAPI { 
    public interface ISinhVienService : IBaseService<SinhVien, SinhVienViewModel>
    {
        IEnumerable<SinhVienViewModel> GetSinhViens(SinhVienRequestModel requestModel);
    }
    public class SinhVienService : BaseService<SinhVien, SinhVienViewModel>, ISinhVienService
    {
        public SinhVienService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public IEnumerable<SinhVienViewModel> GetSinhViens(SinhVienRequestModel requestModel)
        {
            var result = this.Get(p =>
                (requestModel.ClassId == null || p.Id == requestModel.ClassId) && 
                (requestModel.MajorId == null || p.MajorId == requestModel.MajorId) && 
                (requestModel.MSSV == null || p.Mssv == requestModel.MSSV) &&
                (requestModel.TeacherId == null || p.Class.TeacherClasses.FirstOrDefault(q => q.TeacherId == requestModel.TeacherId) != null) 
                
                );
            return result;
        }

        
    }
}
