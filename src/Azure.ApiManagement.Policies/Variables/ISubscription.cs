using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.ApiManagement.Policies.Variables
{
    public interface ISubscription
    {
        DateTime CreatedTime { get; }

        DateTime? EndDate { get; }

        string Id { get; }

        string Key { get; }

        string Name { get; }

        string PrimaryKey { get; }

        string SecondaryKey { get; }

        DateTime? StartDate { get; }
    }
}
