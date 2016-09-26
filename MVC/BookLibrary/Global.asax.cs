using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject;
using Ninject.Web.Common;
using System.Reflection;
using Business;
using Contracts;
using Ninject.Web.Mvc;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;
using DependencyResolver;

namespace BookLibrary
{
    public class MvcApplication : NinjectHttpApplication //HttpApplication
    {

        protected override void OnApplicationStarted()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            var modules = new List<INinjectModule>
            {
                new NinjectResolver()
            };
            kernel.Load(modules);
            return kernel;
        }
    }
}
