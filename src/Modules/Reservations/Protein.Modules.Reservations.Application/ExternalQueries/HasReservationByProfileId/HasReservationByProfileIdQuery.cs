using System;
using Protein.Shared.Abstractions.Queries;

namespace Protein.Modules.Reservations.Application.ExternalQueries.HasReservationByProfileId;

public class HasReservationByProfileIdQuery : IQuery<bool>
{
    public Guid ProfileId { get; set; }
}