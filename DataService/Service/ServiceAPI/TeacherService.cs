using AutoMapper;
using DataService.DBEntity;
using DataService.Model.RequestModel;
using DataService.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.Service.ServiceAPI
{
    public interface ITeacherService : IBaseService<Teacher, TeacherViewModel>
    {
        IEnumerable<TeacherViewModel> GetTeachers(TeacherRequestModel requestModel);
    }
    public class TeacherService : BaseService<Teacher, TeacherViewModel>, ITeacherService
    {
        public TeacherService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public IEnumerable<TeacherViewModel> GetTeachers(TeacherRequestModel requestModel)
        {
            var result = this.Get(p =>
                   (requestModel.TeacherId == null || p.Id == requestModel.TeacherId) &&
                   (requestModel.SubjectId == null || p.SubjectTeacher.FirstOrDefault(q => q.SubjectId == requestModel.SubjectId) != null) &&
                   (requestModel.MajorId == null || p.SubjectTeacher.FirstOrDefault(q => q.Subject.MajorId == requestModel.MajorId) != null) &&
                   (requestModel.SinhVienId == null || p.TeacherClasses.FirstOrDefault(q => q.Class.SinhVien.FirstOrDefault(a => a.Id == requestModel.SinhVienId)!= null) != null)
                );
            return result;
        }
    }
}
