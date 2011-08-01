// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoggerInstaller.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Facility injected to all the component registered in the container.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.Facilities.Installers
{
    using Castle.Facilities.Logging;
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    /// <summary>
    /// Facility injected to all the component registered in the container.
    /// </summary>
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