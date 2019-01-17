using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.ApiManagement.Policies.Variables
{
    public interface IProduct
    {
        IEnumerable<IApi> Apis { get; }
        bool ApprovalRequired { get; }
        string Id { get; }
        string Name { get; }
        ProductState State { get; }
        int? SubscriptionLimit { get; }
        bool SubscriptionRequired { get; }
    }
}
