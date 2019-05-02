using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using DataService.MappingProfileModel;
using Microsoft.EntityFrameworkCore;
using DataService.Service;
using DataService.DBEntity;
using DataService.Service.ServiceAPI;

namespace DataService
{
    public static class RootConfig
    {
        public static void Entry(IServiceCollection services, IConfiguration configuration)
        {
            #region DB Config
            services.AddDbContext<TrainingAPIContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("TrainingDB")));
            services.AddScoped(typeof(DbContext), typeof(TrainingAPIContext));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            #endregion
            services.AddScoped(typeof(ISinhVienService), typeof(SinhVienService));
            #region Mapper Config
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            #endregion
        }
        private static void ConfigAutoMapper(IMapperConfigurationExpression config)
        {
            config.CreateMissingTypeMaps = true;
            config.AllowNullDestinationValues = false;
        }
    }
}