using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Azure.ApiManagement.Policies.Variables
{
    public interface IMessageBody
    {
        /// <summary>
        /// The context.Request.Body.As<T> and context.Response.Body.As<T> methods are used to read a request and response message bodies in a specified type T. 
        /// By default the method uses the original message body stream and renders it unavailable after it returns. 
        /// To avoid that by having the method operate on a copy of the body stream, set the preserveContent parameter to true. 
        /// See <see cref="https://docs.microsoft.com/en-us/azure/api-management/api-management-transformation-policies#SetBody"/>
        /// </summary>
        /// <typeparam name="T">Where T: string, JObject, JToken, JArray, XNode, XElement, XDocument</typeparam>
        /// <param name="preserveContent"></param>
        /// <returns></returns>
        T As<T>(bool preserveContent = false);
    }
}
