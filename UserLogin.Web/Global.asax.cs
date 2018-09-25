﻿using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using UserLogin.Infrastructure.Migrations;

namespace UserLogin.Web
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}