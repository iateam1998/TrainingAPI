using AutoMapper;
using DataService.DBEntity;
using DataService.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Service.ServiceAPI
{
    public interface ISubjectService : IBaseService<Subject, SubjectViewModel>
    {
        IEnumerable<SubjectViewModel> GetSubjects();
    }
    public class SubjectService : BaseService<Subject, SubjectViewModel>, ISubjectService
    {
        public SubjectService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public IEnumerable<SubjectViewModel> GetSubjects()
        {
            var result = this.GetAll();
            return result;
        }
    }
}
