using Protein.Modules.Profiles.Core.Profile;

namespace Protein.Modules.Profiles.Infrastructure.EF.Repositories;

public class ProfileRepository : IProfileRepository
{
    public Task<Profile> Add(Profile profile)
    {
        throw new NotImplementedException();
    }

    public Task<Profile> Update(Profile profile)
    {
        throw new NotImplementedException();
    }

    public Task<Profile> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Profile profile)
    {
        throw new NotImplementedException();
    }
}