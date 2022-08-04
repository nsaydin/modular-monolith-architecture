using System.Threading;
using System.Threading.Tasks;
using Protein.Modules.Reservations.Core.Reservation;
using Protein.Modules.Reservations.Core.Reservation.DTO;
using Protein.Shared.Abstractions.Commands;

namespace Protein.Modules.Reservations.Application.Commands.CreateReservation
{
    internal sealed class CreateReservationCommandHandler : ICommandHandler<CreateReservationCommand>
    {
        private readonly IReservationDomainService _reservationDomainService;

        public CreateReservationCommandHandler(IReservationDomainService reservationDomainService)
        {
            _reservationDomainService = reservationDomainService;
        }

        public async Task HandleAsync(CreateReservationCommand command, CancellationToken cancellationToken = default)
        {
            await _reservationDomainService.Add(new CreateReservationDto
            {
                ArrivalDate = command.ArrivalDate,
                DepartureDate = command.DepartureDate,
                ProfileId = command.ProfileId
            });
        }
    }
}