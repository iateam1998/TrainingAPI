using AutoMapper;
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
            //For Missing Type
            this.AllowNullCollections = true;
            this.AllowNullDestinationValues = true;
            this.CreateMissingTypeMaps = true;
        }
    }
}
