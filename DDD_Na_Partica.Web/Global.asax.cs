﻿using DDD_Na_Partica.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DDD_Na_Partica.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(new GlobalFilterCollection);
            BundleConfig.RegisterBundle(new System.Web.Optimization.BundleCollection());

        }
    }
}