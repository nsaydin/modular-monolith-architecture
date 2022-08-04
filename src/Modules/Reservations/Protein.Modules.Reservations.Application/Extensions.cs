using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Protein.Modules.Reservations.Application.Integration;
using Protein.Modules.Reservations.Shared;

[assembly: InternalsVisibleTo("Protein.Modules.Reservations.Infrastructure")]

namespace Protein.Modules.Reservations.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<IReservationsModuleApi, ReservationsModuleApi>();

            return services;
        }
    }
}