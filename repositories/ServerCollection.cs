using Microsoft.Extensions.DependencyInjection;
using repositories.entities;
using repositories.interfaces;
using repositories.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action = repositories.entities.Action;
namespace repositories
{
    public static class ServerCollection
    {
        public static void AddRepositories(this IServiceCollection service)
        {
            service.AddScoped<Ientity<Action>, ActionRepository>();
            service.AddScoped<Ientity<ActionType>, ActionTypeRepository>();
            service.AddScoped<Ientity<User>, UserRepsitory>();
            service.AddScoped<Ientity<Picture>, PictureRepositoty>();
            service.AddScoped<Ientity<Permission>, PermissionRepository>();

        }
    }
}
