// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ControllersInstaller.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   This is the custom installer for the controllers.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.Facilities.Installers
{
    using System.Web.Mvc;

    using Castle.Facilities.Controllers;
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    /// <summary>
    /// This is the custom installer for the controllers.
    /// </summary>
    public class ControllersInstaller : IWindsorInstaller
    {
        #region Implementation of IWindsorInstaller

        /// <summary>
        /// Performs the installation in the <see cref="T:Castle.Windsor.IWindsorContainer"/>.
        /// </summary>
        /// <param name="container">The container.</param><param name="store">The configuration store.</param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                AllTypes.FromThisAssembly()
                .BasedOn<IController>()
                .If(Component.IsInSameNamespaceAs(typeof(HomeController)))
                .If(componenet => componenet.Name.EndsWith("Controller"))
                .Configure(component => component.LifeStyle.Transient)
                );
        }

        #endregion
    }
}