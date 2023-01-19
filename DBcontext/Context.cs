using Microsoft.EntityFrameworkCore;
using repositories;
using repositories.entities;

namespace DBcontext
{
    public class Context : DbContext, IContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Picture> pictures { get; set; }
        public DbSet<repositories.entities.Action> actions { get; set; }
        public DbSet<ActionType> actionTypes { get; set; }
        public DbSet<Permission> permissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog='----------------------- shiratiHodRacheliBenpoFinalProject';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
           throw new NotImplementedException();
        }


    }

}
