using System;

namespace Protein.Modules.Reservations.Core.Reservation.DTO;

public class CreateReservationDto
{
    public DateTime ArrivalDate { get; set; }
    public DateTime DepartureDate { get; set; }
    public Guid ProfileId { get; set; }
}