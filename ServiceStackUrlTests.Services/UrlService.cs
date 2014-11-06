using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceStackUrlTests.Services
{
    [Route("/baseurl", "GET")]
    public class GetBaseUrl : IReturn<string>
    { }

    [Route("/handlerfactory", "GET")]
    public class GetHandlerFactory : IReturn<string>
    { }

    public class UrlService : Service
    {
        public string Get(GetBaseUrl req)
        {
            return Request.GetBaseUrl();
        }

        public string Get(GetHandlerFactory req)
        {
            return HostConfig.Instance.HandlerFactoryPath ?? "(null)";
        }
    }
}
