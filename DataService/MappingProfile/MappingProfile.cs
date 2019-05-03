using AutoMapper;
using DataService.DBEntity;
using DataService.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.MappingProfileModel
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ///<summary>
            /// Mapping Object <=> View Model
            /// </summary>
            this.CreateMap<Classes, ClassesViewModel>();
            this.CreateMap<SinhVien, SinhVienViewModel>();
            this.CreateMap<Subject, SubjectViewModel>();
            this.CreateMap<Teacher, TeacherViewModel>();
            this.CreateMap<Major, MajorViewModel>();
            this.CreateMap<SubjectTeacher, SubjectTeacherViewModel>();
            this.CreateMap<TeacherClasses, TeacherClassesViewModel>();
            //For Missing Type
            this.AllowNullCollections = true;
            this.AllowNullDestinationValues = true;
            this.CreateMissingTypeMaps = true;
        }
    }
}
