using common.DTOs;
using DBcontext;
using Microsoft.Extensions.DependencyInjection;
using repositories;
using Services.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IService<UserDTO>, UserService>();
            services.AddScoped<IService<ActionDTO>, ActionService>();
            services.AddScoped<IService<ActionTypeDTO>, ActionTypeService>();
            services.AddScoped<IService<PermissionDTO>, PermissionService>();
            services.AddScoped<IService<PictureDTO>, PictureService>();

            services.AddSingleton<IContext, Context>();
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }


    }
}
