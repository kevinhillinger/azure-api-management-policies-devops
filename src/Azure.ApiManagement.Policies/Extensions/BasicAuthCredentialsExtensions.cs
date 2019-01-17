using Azure.ApiManagement.Policies.Variables;
using System;
using System.Text;

namespace Azure.ApiManagement.Policies.Extensions
{
    public static class BasicAuthCredentialsExtensions
    {
        public static bool TryParseBasic(this string value, out BasicAuthCredentials credentials)
        {
            if (!string.IsNullOrEmpty(value) && value.StartsWith("Basic"))
            {
                var values = value.Substring("Basic ".Length).Trim();
                var encoding = Encoding.GetEncoding("iso-8859-1");

                values = encoding.GetString(Convert.FromBase64String(values));
                var tuple = values.Split(':');

                credentials = new BasicAuthCredentials(tuple[0], tuple[1]);
                return true;
            }

            credentials = null;
            return false;
        }
    }
}
