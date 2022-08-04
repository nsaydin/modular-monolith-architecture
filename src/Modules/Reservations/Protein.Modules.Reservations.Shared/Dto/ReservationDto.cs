namespace Protein.Modules.Reservations.Shared.Dto;

public class ReservationDto
{
    public DateTime ArrivalDate { get; set; }
    public DateTime DepartureDate { get; set; }

    public GuestDto Guest { get; set; }

    public class GuestDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}