using Protein.Shared.Abstractions.Commands;

namespace Protein.Modules.Profiles.Application.Commands.CreateProfile
{
    public record CreateProfileCommand(string FirstName , string LastName) : ICommand;
}