using AutoMapper;
using DataService.DBEntity;
using DataService.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Service.ServiceAPI
{
    public interface IMajorService : IBaseService<Major, MajorViewModel>
    {
        IEnumerable<MajorViewModel> GetMajors();
    }
    public class MajorService : BaseService<Major, MajorViewModel>, IMajorService
    {
        public MajorService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public IEnumerable<MajorViewModel> GetMajors()
        {
            var result = this.GetAll();
            return result;
        }
    }
}
