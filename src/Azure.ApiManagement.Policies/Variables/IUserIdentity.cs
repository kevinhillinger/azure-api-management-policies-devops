namespace Azure.ApiManagement.Policies.Variables
{
    public interface IUserIdentity
    {
        string Id { get; }
        string Provider { get; }
    }
}