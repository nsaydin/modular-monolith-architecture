using System;

namespace Protein.Modules.Profiles.Core.Profile;

public class Profile
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Profile(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}