using AutoMapper;
using DataService.DBEntity;
using DataService.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Service.ServiceAPI
{
    public interface ITeacherClassesService : IBaseService<TeacherClasses, TeacherClassesViewModel>
    {
        IEnumerable<TeacherClassesViewModel> GetTeacherClasses();
    }
    public class TeacherClassesService : BaseService<TeacherClasses, TeacherClassesViewModel>, ITeacherClassesService
    {
        public TeacherClassesService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public IEnumerable<TeacherClassesViewModel> GetTeacherClasses()
        {
            var result = this.GetAll();
            return result;
        }
    }
}
