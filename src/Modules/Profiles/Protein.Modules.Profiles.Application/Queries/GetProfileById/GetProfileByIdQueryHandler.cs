using System.Threading;
using System.Threading.Tasks;
using Protein.Modules.Profiles.Shared.Dto;
using Protein.Shared.Abstractions.Queries;

namespace Protein.Modules.Profiles.Application.Queries.GetProfileById;

public class GetProfileByIdQueryHandler : IQueryHandler<GetProfileByIdQuery, ProfileDto>
{
    public Task<ProfileDto> HandleAsync(GetProfileByIdQuery query, CancellationToken cancellationToken = default)
    {
        throw new System.NotImplementedException();
    }
}