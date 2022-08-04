using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Protein.Modules.Profiles.Api;
using Protein.Modules.Reservations.Api;
using Protein.Shared.Abstractions;

namespace Protein.Bootstrapper
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddReservationsModule();
            services.AddProfilesModule();

            services.AddSharedFramework(_configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSharedFramework();

            app.UseReservationsModule();
            app.UseProfilesModule();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGet("/", ctx => ctx.Response.WriteAsync("Protein API"));
            });
        }
    }
}