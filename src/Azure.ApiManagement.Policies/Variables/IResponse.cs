using System.Collections.Generic;

namespace Azure.ApiManagement.Policies.Variables
{
    public interface IResponse
    {
        IMessageBody Body { get; }

        IReadOnlyDictionary<string, string[]> Headers { get; }

        int StatusCode { get; }

        string StatusReason { get; }
    }
}
