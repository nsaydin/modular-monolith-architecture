using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Protein.Modules.Reservations.Application;
using Protein.Modules.Reservations.Core;
using Protein.Modules.Reservations.Infrastructure;

namespace Protein.Modules.Reservations.Api
{
    public static class Extensions
    {
        public static IServiceCollection AddReservationsModule(this IServiceCollection services)
        {
            services.AddCoreLayer();
            services.AddApplicationLayer();
            services.AddInfrastructureLayer();

            return services;
        }

        public static IApplicationBuilder UseReservationsModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}