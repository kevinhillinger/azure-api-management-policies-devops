using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.ApiManagement.Policies.Variables
{
    public interface ILastError
    {
        string Source { get; }
        string Reason { get; }
        string Message { get; }
        string Scope { get; }
        string Section { get; }
        string Path { get; }
        string PolicyId { get; }
    }
}
