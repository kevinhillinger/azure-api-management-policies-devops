using Azure.ApiManagement.Policies.Variables;
using NSubstitute;
using System;

namespace Azure.ApiManagement.Policies
{
    /// <summary>
    /// Expression evaluator
    /// </summary>
    public class PolicyExpressionEvaluator
    {
        private IContext context;

        public PolicyExpressionEvaluator(IContext context)
        {
            this.context = context;
        }

        public PolicyExpressionEvaluator() : this(Substitute.For<IContext>())
        {

        }

        public PolicyExpressionEvaluator Using(IContext context)
        {
            this.context = context;
            return this;
        }

        public virtual T Evaluate<T>(Func<IContext, T> expression)
        {
            return expression(context);
        }
    }
}
