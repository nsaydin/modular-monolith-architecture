using System;
using Protein.Shared.Abstractions.Commands;

namespace Protein.Modules.Profiles.Application.Commands.DeleteProfile
{
    public record DeleteProfileCommand(Guid ProfileId) : ICommand;
}