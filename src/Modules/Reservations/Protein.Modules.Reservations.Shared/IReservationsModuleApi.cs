using Protein.Modules.Reservations.Shared.Dto;

namespace Protein.Modules.Reservations.Shared
{
    public interface IReservationsModuleApi
    {
        Task<ReservationDto> GetReservationById(Guid reservationId);
        
        Task<bool> HasReservationByProfileId(Guid profileId);
    }
}