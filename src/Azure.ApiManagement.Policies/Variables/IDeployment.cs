using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Azure.ApiManagement.Policies.Variables
{
    public interface IDeployment
    {
        string Region { get; }
        string ServiceName { get; }
        IReadOnlyDictionary<string, X509Certificate2> Certificates { get; }
    }
}
