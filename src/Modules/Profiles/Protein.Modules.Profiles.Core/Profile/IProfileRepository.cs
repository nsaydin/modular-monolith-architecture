using System;
using System.Threading.Tasks;

namespace Protein.Modules.Profiles.Core.Profile;

public interface IProfileRepository
{
    Task<Profile> Add(Profile profile);
    Task<Profile> Update(Profile profile);
    Task<Profile> GetById(Guid id);

    Task Delete(Profile profile);
}