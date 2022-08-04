using Microsoft.Extensions.DependencyInjection;
using Protein.Modules.Profiles.Core.Profile;
using Protein.Modules.Profiles.Infrastructure.EF.Repositories;

namespace Protein.Modules.Profiles.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services)
        {
            // services.AddPostgres<ProfileDbContext>();
            services.AddScoped<IProfileRepository, ProfileRepository>();

            return services;
        }
    }
}