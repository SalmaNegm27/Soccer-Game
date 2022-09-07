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
            //modelBuilder.Entity<Player>().HasData(new List <Player>{
            //    new Player{ Id = new Guid("cd2fe540-1126-4a64-9hha-54fa7480da4c"), Name = "Mo Salah", Nationality = "Egypt", BirthDate = new DateTime(2000-09-06), ClubId = new Guid("cd2fe540-1126-4a64-9hha-54fa7480nx88") },
            //    new Player { Id = new Guid("ab2fe540-1126-2av8-9hha-54fa7480da4c"), Name = "Messi", Nationality = "Alexandria", BirthDate = new DateTime(1999-02-01), ClubId = new Guid("cd2fe540-1126-4a64-9hha-54fa7555da4c")},
           
            //});
            //modelBuilder.Entity<Coach>().HasData(new List<Coach>{
            //    new Coach{ Id = new Guid("ac6se540-1126-4a64-5eea-54fa7480da4c"),CreationData=new DateTime(2022-09-06T16:49:48.001Z), FirstName = "Hossam", LastName = "Hassan", PhoneNumber="012235" },
            //    new Coach { Id = new Guid("ac2fe550-1126-4a64-assa-54fa7480da4c"), CreationData=new DateTime(2022-09-06L18:49:48.001Z),FirstName = "Ebrahiem", LastName = "Hassan", PhoneNumber="01882235"},
            //    new Coach { Id = new Guid("ab2fe540-1126-4a64-9hha-54fa7480da4c"),  FirstName = "Hassan", LastName = "Shehata", PhoneNumber="01299235"}
            //});

            //modelBuilder.Entity<NationalTeam>().HasData(new List<NationalTeam>{
            //    new NationalTeam{ Id = new Guid(), Name= "Eygypt", Country = "Eygpt",FoundationDate= new DateTime() },
            //    new NationalTeam { Id = new Guid(), Name = "Borkina faso", Country = "Africa", FoundationDate= new DateTime()}
                
            //});
            //modelBuilder.Entity<Club>().HasData(new List<Club>{
            //    new Club{ Id = new Guid("cd2fe540-1126-4a64-9hha-54fa7480nx88"), Name = "Barca", Country = "Spain", FoundationDate= new DateTime() },
            //    new Club { Id = new Guid("cd2fe540-1126-4a64-9hha-54fa7555da4c"),Name = "RealMadrid", Country = "Spain", FoundationDate= new DateTime()}
                
            //});








            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Player).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Coach).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Club).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NationalTeam).Assembly);
        }

    }
}
