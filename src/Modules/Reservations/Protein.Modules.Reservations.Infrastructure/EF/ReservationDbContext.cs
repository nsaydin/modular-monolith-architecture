using Microsoft.EntityFrameworkCore;
using Protein.Modules.Reservations.Core.Reservation;

namespace Protein.Modules.Reservations.Infrastructure.EF
{
    internal class ReservationDbContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }
        
        public ReservationDbContext(DbContextOptions<ReservationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("reservations");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}