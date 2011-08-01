namespace CastleWindsor01.Installers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    using Castle.Facilities.Logging;
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    public class LoggerInstaller : IWindsorInstaller
    {
        #region Implementation of IWindsorInstaller

        /// <summary>
        /// Performs the installation in the <see cref="T:Castle.Windsor.IWindsorContainer"/>.
        /// </summary>
        /// <param name="container">The container.</param><param name="store">The configuration store.</param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.AddFacility<LoggingFacility>(
                facility => facility.LogUsing(LoggerImplementation.Log4net).WithConfig("log4net.config"));
        }

        #endregion
    }
}