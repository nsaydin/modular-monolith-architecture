using System;
using System.Threading.Tasks;

namespace Protein.Modules.Reservations.Core.Reservation;

public interface IReservationRepository
{
    Task<Reservation> Add(Reservation reservation);
    Task<Reservation> Update(Reservation reservation);
    Task<Reservation> GetById(Guid id);

    Task<bool> IsExistByProfileId(Guid profileId);
}