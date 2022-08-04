using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("Protein.Modules.Profiles.Application")]
[assembly: InternalsVisibleTo("Protein.Modules.Profiles.Infrastructure")]

namespace Protein.Modules.Profiles.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddCoreLayer(this IServiceCollection services)
        {
            return services;
        }
    }
}