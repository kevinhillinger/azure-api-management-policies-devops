using System;
using System.Collections.Generic;

namespace Azure.ApiManagement.Policies.Variables
{
    public interface IUser
    {
        string Email { get; }
        string FirstName { get; }
        IEnumerable<IGroup> Groups { get; }
        string Id { get; }
        IEnumerable<IUserIdentity> Identities { get; }
        string LastName { get; }
        string Note { get; }
        DateTime RegistrationDate { get; }
    }
}
