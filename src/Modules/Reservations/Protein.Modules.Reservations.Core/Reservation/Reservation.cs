using System;

namespace Protein.Modules.Reservations.Core.Reservation;

public class Reservation
{
    public Guid Id { get; set; }
    public Guid ProfileId { get; set; }

    public DateTime ArrivalDate { get; set; }
    public DateTime DepartureDate { get; set; }

    public Guid? RoomId { get; set; }
    public ReservationStatus Status { get; set; }

    public Reservation(DateTime arrivalDate, DateTime departureDate, Guid profileId)
    {
        Id = Guid.NewGuid();
        Status = ReservationStatus.Reserved;
    }

    public void CheckIn(Guid roomId)
    {
        Status = ReservationStatus.CheckIn;
        RoomId = roomId;
    }
}