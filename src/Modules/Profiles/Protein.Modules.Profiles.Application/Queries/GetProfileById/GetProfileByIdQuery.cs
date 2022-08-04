using System;
using Protein.Modules.Profiles.Shared.Dto;
using Protein.Shared.Abstractions.Queries;

namespace Protein.Modules.Profiles.Application.Queries.GetProfileById;

public class GetProfileByIdQuery : IQuery<ProfileDto>
{
    public Guid ProfileId { get; set; }
}