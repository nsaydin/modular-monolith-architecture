using System;
using Protein.Shared.Abstractions.Commands;

namespace Protein.Modules.Reservations.Application.Commands.CreateReservation
{
    public record CreateReservationCommand(DateTime ArrivalDate , DateTime DepartureDate , Guid ProfileId) : ICommand;
}