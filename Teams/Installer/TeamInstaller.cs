namespace Teams.Installer
{

    using Comman.AssemplyScaning;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Teams.Validators;

    public class TeamInstaller : IInstaller
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IClubRepository, ClubRepository>();
            services.AddScoped<IClubUnitOfWork, ClubUnitOfWork>();
            services.AddScoped<IValidator<ClubViewModel>, ClubValidator>();


            services.AddScoped<INationlTeamRepository, NationalTeamRepository>();
            services.AddScoped<INationalTeamUnitOfWork, NationalTeamUnitOfWork>();
            services.AddScoped<IValidator<NationalTeamViewModel>, NationalTeamValidator>();
        }
    }
}
