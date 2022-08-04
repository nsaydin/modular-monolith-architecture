using System;
using System.Threading.Tasks;
using Protein.Modules.Reservations.Core.Reservation.DTO;

namespace Protein.Modules.Reservations.Core.Reservation;

public class ReservationDomainService : IReservationDomainService
{
    private readonly IReservationRepository _repository;

    public ReservationDomainService(IReservationRepository repository)
    {
        _repository = repository;
    }

    public Task<Reservation> Add(CreateReservationDto dto)
    {
        var reservation = new Reservation(dto.ArrivalDate, dto.DepartureDate, dto.ProfileId);

        return _repository.Add(reservation);
    }


    public async Task CheckIn(Guid id, Guid roomId)
    {
        var entity = await _repository.GetById(id);
        entity.CheckIn(roomId);

        await _repository.Update(entity);
    }
}