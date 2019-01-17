using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.ApiManagement.Policies.Variables
{
    public interface IOperation
    {
        string Id { get; }
        string Method { get; }
        string Name { get; }
        string UrlTemplate { get; }
    }
}
