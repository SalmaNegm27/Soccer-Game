namespace Players.Installers
{
    using Comman.AssemplyScaning;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Players.Validators;

    public class PlayerInstallers : IInstaller
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<IPlayerUnitOfWork, PlayerUnitOfWork>();
            services.AddScoped<IValidator<PlayerViewModel>, PlayerValidator>();
        }
    }
}
