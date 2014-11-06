using ServiceStack;
using ServiceStackUrlTests.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceStackUrlTests.Services
{
    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("URL Tests for ServiceStack", typeof(UrlService).Assembly)
        { }

        public override void Configure(Funq.Container container)
        {
            
        }
    }
}