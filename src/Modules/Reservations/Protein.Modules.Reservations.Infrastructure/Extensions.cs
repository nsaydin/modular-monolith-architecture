using Microsoft.Extensions.DependencyInjection;
using Protein.Modules.Reservations.Core.Reservation;
using Protein.Modules.Reservations.Infrastructure.EF.Repositories;

namespace Protein.Modules.Reservations.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services)
        {
            // services.AddPostgres<ReservationDbContext>();
            services.AddScoped<IReservationRepository, ReservationRepository>();

            return services;
        }
    }
}