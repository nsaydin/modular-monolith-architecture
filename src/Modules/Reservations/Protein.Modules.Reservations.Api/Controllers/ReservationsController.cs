using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Protein.Modules.Reservations.Application.Commands.CreateReservation;
using Protein.Modules.Reservations.Application.Queries.GetReservationById;
using Protein.Modules.Reservations.Shared.Dto;
using Protein.Shared.Abstractions.Dispatchers;

namespace Protein.Modules.Reservations.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationsController : ControllerBase
    {
        private readonly IDispatcher _dispatcher;

        public ReservationsController(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpGet("{reservationId:guid}")]
        public async Task<ActionResult<ReservationDto>> Get(Guid reservationId)
        {
            var reservation = await _dispatcher.QueryAsync(new GetReservationByIdQuery { ReservationId = reservationId });
            if (reservation is not null)
                return Ok(reservation);

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateReservationCommand command)
        {
            await _dispatcher.SendAsync(command);
            return Ok();
        }
    }
}