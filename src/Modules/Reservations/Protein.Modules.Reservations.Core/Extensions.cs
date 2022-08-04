using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("Protein.Modules.Reservations.Application")]
[assembly: InternalsVisibleTo("Protein.Modules.Reservations.Infrastructure")]

namespace Protein.Modules.Reservations.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddCoreLayer(this IServiceCollection services)
        {
            return services;
        }
    }
}