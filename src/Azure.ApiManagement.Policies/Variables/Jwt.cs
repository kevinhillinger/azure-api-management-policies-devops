using System;
using System.Collections.Generic;

namespace Azure.ApiManagement.Policies.Variables
{
    public class Jwt
    {
        public string Algorithm { get; set; }
        public IEnumerable<string> Audience { get; set; }
        public IReadOnlyDictionary<string, string[]> Claims { get; set; }

        DateTime? ExpirationTime { get; set; }

        string Id { get; set; }

        string Issuer { get; set; }

        DateTime? NotBefore { get; set; }

        string Subject { get; set; }

        string Type { get; set; }
    }
}
