using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Protein.Modules.Profiles.Application.Integration;
using Protein.Modules.Profiles.Shared;

[assembly: InternalsVisibleTo("Protein.Modules.Profiles.Infrastructure")]

namespace Protein.Modules.Profiles.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<IProfilesModuleApi, ProfilesModuleApi>();

            return services;
        }
    }
}