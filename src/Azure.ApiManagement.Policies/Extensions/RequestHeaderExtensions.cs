using System.Collections.Generic;

namespace Azure.ApiManagement.Policies.Extensions
{
    public static class RequestHeaderExtensions
    {
        /// <summary>
        /// stubbed implementation of the GetValueOrDefault method exposed in api management policy expression engine
        /// </summary>
        /// <param name="headers"></param>
        /// <param name="headerName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string GetValueOrDefault(this IReadOnlyDictionary<string, string[]> headers, string headerName, string defaultValue)
        {
            if (headers != null)
            {
                if  (headers.TryGetValue(headerName, out var values))
                {
                    return string.Join(",", values);
                }
            }
            return defaultValue;
        }
    }
}
