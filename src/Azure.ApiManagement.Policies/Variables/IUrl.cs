using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.ApiManagement.Policies.Variables
{
    public interface IUrl
    {
        string Host { get; }
        string Path { get; }
        int Port { get; }
        IReadOnlyDictionary<string, string[]> Query { get; }
        string QueryString { get; }
        string Scheme { get; }
    }
}
