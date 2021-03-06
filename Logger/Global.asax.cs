﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Logger
{
    public class Global : HttpApplication
    {
        log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Global));  //Declaring Log4Net   
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            log4net.Config.XmlConfigurator.Configure();
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
            }
            catch(DivideByZeroException ex)
            {
                logger.Error(ex);
            }
        }
    }
}