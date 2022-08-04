using System;
using System.Threading.Tasks;
using Protein.Modules.Profiles.Application.Queries.GetProfileById;
using Protein.Modules.Profiles.Shared;
using Protein.Modules.Profiles.Shared.Dto;
using Protein.Shared.Abstractions.Dispatchers;

namespace Protein.Modules.Profiles.Application.Integration
{
    internal sealed class ProfilesModuleApi : IProfilesModuleApi
    {
        private readonly IDispatcher _dispatcher;

        public ProfilesModuleApi(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public Task<ProfileDto> GetProfileById(Guid profileId)
        {
            return _dispatcher.QueryAsync(new GetProfileByIdQuery { ProfileId = profileId });
        }
    }
}