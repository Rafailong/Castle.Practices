// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OperationsInstaller.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Install al the services based on <see cref="IOperation" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.BasicInterseptor.Installers
{
    using Castle.Core;
    using Castle.DynamicProxy;
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    /// <summary>
    /// Install al the services based on <see cref="IOperation"/>.
    /// </summary>
    public class OperationsInstaller : IWindsorInstaller
    {
        #region Implementation of IWindsorInstaller

        /// <summary>
        /// Performs the installation in the <see cref="T:Castle.Windsor.IWindsorContainer"/>.
        /// </summary>
        /// <param name="container">The container.</param><param name="store">The configuration store.</param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<CustomNotification>());
            container.Register(Component.For<IOperation>().ImplementedBy<Operations.Add>()
                .Interceptors<CustomNotification>().LifeStyle.Transient);
        }

        #endregion
    }
}
