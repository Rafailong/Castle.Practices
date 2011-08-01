// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomInstaller.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Custom installer to isolate the registration of the components
//   of the application's starting point.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.SimpleDynamicInterceptor.Installers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Castle.Core;
    using Castle.DynamicProxy;
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    /// <summary>
    /// Custom installer to isolate the registration of the components 
    /// of the application's starting point.
    /// </summary>
    public class CustomInstaller : IWindsorInstaller
    {
        #region Implementation of IWindsorInstaller

        /// <summary>
        /// Performs the installation in the <see cref="T:Castle.Windsor.IWindsorContainer"/>.
        /// </summary>
        /// <param name="container">The container.</param><param name="store">The configuration store.</param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<OtherSimpleInterceptor>()
                .Named("Other")
                .LifeStyle.Transient);

            container.Register(
                Component.For<SimpleInterceptor>()
                .Named("SimpleOne")
                .LifeStyle.Transient);

            container.Register(
                Component.For<IService>()
                .ImplementedBy<SimpleService>()
                .Interceptors(InterceptorReference.ForKey("SimpleOne")).Anywhere
                .LifeStyle.Transient);
        }

        #endregion
    }
}
