using Microsoft.EntityFrameworkCore;
using repositories;
using repositories.entities;

namespace DBcontext
{
    public class Context : DbContext, IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<repositories.entities.Action> Actions { get; set; }

        public DbSet<ActionType> ActionTypes { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=sqlsrv;Initial Catalog='----------------------- shiratiHodRacheliBenpoFinalProject';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }




    }

}
