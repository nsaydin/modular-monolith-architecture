using System.Threading;
using System.Threading.Tasks;
using Protein.Modules.Reservations.Core.Reservation;
using Protein.Shared.Abstractions.Queries;

namespace Protein.Modules.Reservations.Application.ExternalQueries.HasReservationByProfileId;

public class HasReservationByProfileIdQueryHandler : IQueryHandler<HasReservationByProfileIdQuery, bool>
{
    private readonly IReservationRepository _reservationRepository;

    public HasReservationByProfileIdQueryHandler(IReservationRepository reservationRepository)
    {
        _reservationRepository = reservationRepository;
    }

    public Task<bool> HandleAsync(HasReservationByProfileIdQuery query, CancellationToken cancellationToken = default)
    {
        return _reservationRepository.IsExistByProfileId(query.ProfileId);
    }
}