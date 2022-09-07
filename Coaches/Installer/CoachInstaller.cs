namespace Coaches.Installer
{
    using Coaches.Validators;
    using Comman.AssemplyScaning;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CoachInstaller : IInstaller
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICoachRepository, CoachRepository>();
            services.AddScoped<ICoachUnitOfWork, CoachUnitOfWork>();
            services.AddScoped<IValidator<CoachViewModel>, CoachValidator>();
        }
    }
}
