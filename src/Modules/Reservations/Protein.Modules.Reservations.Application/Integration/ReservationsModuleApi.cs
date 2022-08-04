using System;
using System.Threading.Tasks;
using Protein.Modules.Reservations.Application.ExternalQueries.HasReservationByProfileId;
using Protein.Modules.Reservations.Application.Queries.GetReservationById;
using Protein.Modules.Reservations.Shared;
using Protein.Modules.Reservations.Shared.Dto;
using Protein.Shared.Abstractions.Dispatchers;

namespace Protein.Modules.Reservations.Application.Integration
{
    internal sealed class ReservationsModuleApi : IReservationsModuleApi
    {
        private readonly IDispatcher _dispatcher;

        public ReservationsModuleApi(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public Task<ReservationDto> GetReservationById(Guid reservationId)
        {
            return _dispatcher.QueryAsync(new GetReservationByIdQuery { ReservationId = reservationId });
        }

        public Task<bool> HasReservationByProfileId(Guid profileId)
        {
            return _dispatcher.QueryAsync(new HasReservationByProfileIdQuery { ProfileId = profileId });
        }
    }
}