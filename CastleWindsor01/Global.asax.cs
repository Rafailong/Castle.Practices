namespace CastleWindsor01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    using Castle.Windsor;
    using Castle.Windsor.Installer;

    using CastleWindsor01.Plumbing;

    /// <summary>
    /// Application Global configuration and Start/End class.
    /// </summary>
    public class MvcApplication : HttpApplication
    {
        /// <summary>
        /// The container to replace the Controllers factory by default.
        /// </summary>
        private static IWindsorContainer _container;

        /// <summary>
        /// Registers the global filters.
        /// </summary>
        /// <param name="filters">The filters.</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        /// <summary>
        /// Registers the routes.
        /// </summary>
        /// <param name="routes">The routes.</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("favicon.ico");
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } /* Parameter defaults */);
        }

        /// <summary>
        /// Application_s the start.
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            // Replace the ControllerFactory with ours.
            BootstrapContainer();
        }

        /// <summary>
        /// Application_s the end.
        /// </summary>
        protected void Application_End()
        {
            _container.Dispose();
        }

        /// <summary>
        /// Bootstraps the container.
        /// </summary>
        private static void BootstrapContainer()
        {
            _container = new WindsorContainer()
                .Install(FromAssembly.This());
            ControllerFactory factory = new ControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(factory);
        }
    }
}