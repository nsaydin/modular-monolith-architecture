using System;
using System.Threading.Tasks;
using Protein.Modules.Reservations.Core.Reservation.DTO;

namespace Protein.Modules.Reservations.Core.Reservation;

public interface IReservationDomainService
{
    Task<Reservation> Add(CreateReservationDto dto);
    
    Task CheckIn(Guid id, Guid roomId);
}