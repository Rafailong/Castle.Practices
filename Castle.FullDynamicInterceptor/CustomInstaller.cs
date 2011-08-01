// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomInstaller.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Custom components installer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.FullDynamicInterceptor
{
    using Castle.Core;
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;
    
    /// <summary>
    /// Custom components installer.
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
            container.Kernel.ProxyFactory.AddInterceptorSelector(new CustomInterceptorsSelector());

            container.Register(
                Component.For<InterceptorOne>()
                .LifeStyle.Transient);

            container.Register(
                Component.For<InterceptorTwo>()
                .Named("Two")
                .LifeStyle.Transient);
            
            container.Register(
                Component.For<InterceptorThree>()
                .Named("Three")
                .LifeStyle.Transient);
            
            container.Register(
                Component.For<IService>()
                .ImplementedBy<SimpleService>()
                .Interceptors(InterceptorReference.ForKey("Two")).Anywhere
                .LifeStyle.Transient);
        }

        #endregion
    }
}
