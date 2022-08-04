using System;
using System.Threading;
using System.Threading.Tasks;
using Protein.Modules.Profiles.Core.Profile;
using Protein.Modules.Reservations.Shared;
using Protein.Shared.Abstractions.Commands;

namespace Protein.Modules.Profiles.Application.Commands.DeleteProfile
{
    internal sealed class DeleteProfileCommandHandler : ICommandHandler<DeleteProfileCommand>
    {
        private readonly IProfileRepository _profileRepository;
        private readonly IReservationsModuleApi _reservationsModuleApi;

        public DeleteProfileCommandHandler(IProfileRepository profileRepository, IReservationsModuleApi reservationsModuleApi)
        {
            _profileRepository = profileRepository;
            _reservationsModuleApi = reservationsModuleApi;
        }

        public async Task HandleAsync(DeleteProfileCommand command, CancellationToken cancellationToken = default)
        {
            var hasReservation = await _reservationsModuleApi.HasReservationByProfileId(command.ProfileId);
            if (hasReservation)
                throw new Exception("Profile cannot deleted");

            var profile = await _profileRepository.GetById(command.ProfileId);
            await _profileRepository.Delete(profile);
        }
    }
}