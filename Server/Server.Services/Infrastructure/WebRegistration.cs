﻿using Falcon.Web.Mvc.Security;
using SimpleInjector;

namespace Phoenix.Server.Services.Infrastructure
{
    public class WebRegistration
    {
        public static void Register(Container container)
        {
            //web context
            container.Register<WebContext>(Lifestyle.Scoped);

        }
    }
}
