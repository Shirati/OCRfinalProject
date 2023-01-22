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
        public static string ToString<T>(this T obj)
        {
            string str = "";
            foreach (var item in obj.GetType().GetProperties())
            {

                if (item.PropertyType.IsArray)
                {
                    str += item.Name + ":";
                    var q = item.GetValue(obj);
                    string s = String.Join(',', q as string[]);
                    str += "\n" + s;
                }
                else str += item.Name + ":" + item?.GetValue(obj) + ",";
            }
            return str.Remove(str.Length - 1);
        }
    }

}

