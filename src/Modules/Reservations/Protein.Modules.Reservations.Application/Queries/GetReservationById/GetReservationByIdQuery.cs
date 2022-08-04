using System;
using Protein.Modules.Reservations.Shared.Dto;
using Protein.Shared.Abstractions.Queries;

namespace Protein.Modules.Reservations.Application.Queries.GetReservationById;

public class GetReservationByIdQuery : IQuery<ReservationDto>
{
    public Guid ReservationId { get; set; }
}