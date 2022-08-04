using Protein.Modules.Reservations.Core.Reservation;

namespace Protein.Modules.Reservations.Infrastructure.EF.Repositories;

public class ReservationRepository : IReservationRepository
{
    public Task<Reservation> Add(Reservation reservation)
    {
        throw new NotImplementedException();
    }

    public Task<Reservation> Update(Reservation reservation)
    {
        throw new NotImplementedException();
    }

    public Task<Reservation> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsExistByProfileId(Guid profileId)
    {
        throw new NotImplementedException();
    }
}