using AutoMapper;
using DataService.DBEntity;
using DataService.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Service.ServiceAPI
{
    public interface IClassesService1 : IBaseService<Classes, ClassesViewModel>
    {
        IEnumerable<ClassesViewModel> GetClasses();
    }
    public class ClassesService1 : BaseService<Classes, ClassesViewModel>, IClassesService1
    {
        public ClassesService1(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public IEnumerable<ClassesViewModel> GetClasses()
        {
            var result = this.GetAll();
            return result;
        }
    }
}
