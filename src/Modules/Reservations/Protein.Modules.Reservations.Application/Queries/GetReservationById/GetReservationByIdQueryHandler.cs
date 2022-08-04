using System.Threading;
using System.Threading.Tasks;
using Protein.Modules.Profiles.Shared;
using Protein.Modules.Reservations.Core.Reservation;
using Protein.Modules.Reservations.Shared.Dto;
using Protein.Shared.Abstractions.Queries;

namespace Protein.Modules.Reservations.Application.Queries.GetReservationById;

public class GetReservationByIdQueryHandler : IQueryHandler<GetReservationByIdQuery, ReservationDto>
{
    private readonly IProfilesModuleApi _profilesModuleApi;
    private readonly IReservationRepository _reservationRepository;

    public GetReservationByIdQueryHandler(IReservationRepository reservationRepository, IProfilesModuleApi profilesModuleApi)
    {
        _reservationRepository = reservationRepository;
        _profilesModuleApi = profilesModuleApi;
    }

    public async Task<ReservationDto> HandleAsync(GetReservationByIdQuery query, CancellationToken cancellationToken = default)
    {
        var reservation = await _reservationRepository.GetById(query.ReservationId);
        var profile = await _profilesModuleApi.GetProfileById(reservation.ProfileId);

        return new ReservationDto
        {
            ArrivalDate = reservation.ArrivalDate,
            DepartureDate = reservation.DepartureDate,
            Guest = new ReservationDto.GuestDto
            {
                FirstName = profile.FirstName,
                LastName = profile.LastName
            }
        };
    }
}