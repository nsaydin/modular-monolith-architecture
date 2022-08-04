using Protein.Modules.Profiles.Shared.Dto;

namespace Protein.Modules.Profiles.Shared
{
    public interface IProfilesModuleApi
    {
        Task<ProfileDto> GetProfileById(Guid profileId);
    }
}