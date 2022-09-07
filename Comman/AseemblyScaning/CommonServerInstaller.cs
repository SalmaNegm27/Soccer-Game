﻿namespace Comman

{
    using Comman.AssemplyScaning;
    using ECommerce.Application;
    using FluentValidation.AspNetCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public class CommonServerInstaller : IInstaller
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepositpry<>));
            services.AddScoped(typeof(IBaseUnitOfWork<>), typeof(BaseUnitOfWork<>));

            services.AddFluentValidation(options =>
            {
                options.AutomaticValidationEnabled = true;
                options.DisableDataAnnotationsValidation = true;
            });

        }

    }
}