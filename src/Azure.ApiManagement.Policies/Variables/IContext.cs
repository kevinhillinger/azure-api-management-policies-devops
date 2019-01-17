using System;
using System.Collections.Generic;

namespace Azure.ApiManagement.Policies.Variables
{
    /// <summary>
    /// interface of the context variable as documented 
    /// </summary>
    /// <see cref="https://docs.microsoft.com/en-us/azure/api-management/api-management-policy-expressions"/>
    public interface IContext
    {
        Api Api { get; }

        IDeployment Deployment { get; }

        TimeSpan Elapsed { get; }

        ILastError LastError { get; }

        IOperation Operation { get; }

        IProduct Product { get; }

        IRequest Request { get; }

        Guid RequestId { get; }

        IResponse Response { get; }

        ISubscription Subscription { get; }

        DateTime Timestamp { get; }
        bool Tracing { get; }

        IUser User { get; }

        IReadOnlyDictionary<string, object> Variables { get; }

        void Trace(string message);
    }
}
