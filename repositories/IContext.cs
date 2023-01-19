using Microsoft.EntityFrameworkCore;
using repositories.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action = repositories.entities.Action;

namespace repositories
{
    public interface IContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Picture> pictures { get; set; }
        public DbSet<Action> actions { get; set; }
        public DbSet<ActionType> actionTypes { get; set; }
        public DbSet<Permission> permissions { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
