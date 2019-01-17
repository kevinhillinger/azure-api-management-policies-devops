using System;
using System.Collections.Generic;

namespace Azure.ApiManagement.Policies.Variables
{
    public class Api : IApi
    {
        public virtual string Id { get; }

        public virtual bool IsCurrentRevision { get; }

        public virtual string Name { get; }

        public virtual string Path { get; }

        public virtual string Revision { get; }

        public virtual IEnumerable<string> Protocols { get; }

        public virtual IUrl ServiceUrl { get; }

        public virtual string Version { get; }

        public virtual ISubscriptionKeyParameterNames SubscriptionKeyParameterNames { get; }
    }
}
