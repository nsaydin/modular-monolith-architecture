using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Protein.Modules.Profiles.Application;
using Protein.Modules.Profiles.Core;
using Protein.Modules.Profiles.Infrastructure;

namespace Protein.Modules.Profiles.Api
{
    public static class Extensions
    {
        public static IServiceCollection AddProfilesModule(this IServiceCollection services)
        {
            services.AddCoreLayer();
            services.AddApplicationLayer();
            services.AddInfrastructureLayer();

            return services;
        }

        public static IApplicationBuilder UseProfilesModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}