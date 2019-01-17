using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.ApiManagement.Policies.Variables
{
    public class BasicAuthCredentials
    {
        public virtual string Password { get; }
        public virtual string UserId { get; }

        public BasicAuthCredentials()
        {
        }

        public BasicAuthCredentials(string userId, string password)
        {
            Password = password;
            UserId = userId;
        }
    }
}
