using AutoMapper;
using DataService.DBEntity;
using DataService.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Service.ServiceAPI
{
    public interface ISinhVienService : IBaseService<SinhVien, SinhVienViewModel>
    {
        IEnumerable<SinhVienViewModel> GetSinhViens();
    }
    public class SinhVienService : BaseService<SinhVien, SinhVienViewModel>, ISinhVienService
    {
        public SinhVienService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public IEnumerable<SinhVienViewModel> GetSinhViens()
        {
            var result = this.GetAll();
            return result;
        }
    }
}
