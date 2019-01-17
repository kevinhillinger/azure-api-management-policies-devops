using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Azure.ApiManagement.Policies.Variables
{
    public class IRequest
    {
        IMessageBody Body { get; }
        X509Certificate2 Certificate { get; }
        IReadOnlyDictionary<string, string[]> Headers { get; }
        string IpAddress { get; }
        IReadOnlyDictionary<string, string> MatchedParameters { get; }
        string Method { get; }
        IUrl OriginalUrl { get; }
        IUrl Url { get; }
    }
}
