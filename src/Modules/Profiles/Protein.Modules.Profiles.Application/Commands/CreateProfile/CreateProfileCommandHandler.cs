using System.Threading;
using System.Threading.Tasks;
using Protein.Modules.Profiles.Core.Profile;
using Protein.Shared.Abstractions.Commands;

namespace Protein.Modules.Profiles.Application.Commands.CreateProfile
{
    internal sealed class CreateProfileCommandHandler : ICommandHandler<CreateProfileCommand>
    {
        private readonly IProfileRepository _profileRepository;

        public CreateProfileCommandHandler(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

        public async Task HandleAsync(CreateProfileCommand command, CancellationToken cancellationToken = default)
        {
            var profileEntity = new Profile(command.FirstName, command.LastName);
            await _profileRepository.Add(profileEntity);
        }
    }
    
}