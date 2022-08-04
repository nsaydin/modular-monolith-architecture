using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Protein.Modules.Profiles.Application.Commands.CreateProfile;
using Protein.Shared.Abstractions.Dispatchers;

namespace Protein.Modules.Profiles.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfilesController : ControllerBase
    {
        private readonly IDispatcher _dispatcher;

        public ProfilesController(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProfileCommand command)
        {
            await _dispatcher.SendAsync(command);
            return Ok();
        }
    }
}