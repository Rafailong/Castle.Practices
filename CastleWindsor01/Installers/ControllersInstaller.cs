// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ControllersInstaller.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   The installer for all the controller in the given conditions.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CastleWindsor01.Installers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    using CastleWindsor01.Controllers;

    /// <summary>
    /// The installer for all the controller in the given conditions.
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
                .If(Component.IsInSameNamespaceAs(typeof(HomeController), true))
                .If(controller => controller.Name.EndsWith("Controller"))
                .Configure(controller => controller.LifeStyle.Transient));
        }

        #endregion
    }
}