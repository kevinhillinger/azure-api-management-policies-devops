using Azure.ApiManagement.Policies.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.ApiManagement.Policies
{
    public class PolicyExpressionEvaluator
    {
        public virtual T Evaluate<T>(IContext context)
        {
            return default(T);
        }
    }
}
