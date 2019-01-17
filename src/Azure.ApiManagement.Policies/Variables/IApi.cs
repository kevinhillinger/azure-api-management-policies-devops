using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.ApiManagement.Policies.Variables
{
    public interface IApi
    {
        string Id { get; }
        string Name { get; }
        string Path { get; }
        IEnumerable<string> Protocols { get; }
        IUrl ServiceUrl { get; }
        ISubscriptionKeyParameterNames SubscriptionKeyParameterNames { get; }
    }
}
