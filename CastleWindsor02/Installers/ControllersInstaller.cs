// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ControllersInstaller.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Installer whch look for all the controller and specify the
//   criterions to fetch component.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CastleWindsor02.Installers
{
    using System.Web.Mvc;

    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    using CastleWindsor02.Controllers;

    /// <summary>
    /// Installer whch look for all the controller and specify the
    /// criterions to fetch component.
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
                AllTypes.FromThisAssembly().BasedOn(typeof(IController)) // The component need to be implementation of.
                .If(Component.IsInSameNamespaceAs(typeof(HomeController), true)) // The component must be inside this namespace.
                .If(component => component.Name.EndsWith("Controller")) // The component's name must ends with 'Controller' or sufix.
                .Configure(c => c.LifeStyle.Transient)); // life style of the component, we specified it 'cuz Singleton if assigned by defualt.
        }

        #endregion
    }
}