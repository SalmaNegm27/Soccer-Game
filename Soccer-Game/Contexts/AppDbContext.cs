namespace Soccer_Game.Contexts
{
    using Coaches.Entities;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Players.Entities;
    using Teams.Entities;

    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Player).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Coach).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Club).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NationalTeam).Assembly);
        }

    }
}
