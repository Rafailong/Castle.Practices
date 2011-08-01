// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotificationsInstaller.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Install all the INotification base interceptor
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.BasicInterseptor.Installers
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    /// <summary>
    /// Install all the INotification base interceptor
    /// </summary>
    public class NotificationsInstaller : IWindsorInstaller
    {
        #region Implementation of IWindsorInstaller

        /// <summary>
        /// Performs the installation in the <see cref="T:Castle.Windsor.IWindsorContainer"/>.
        /// </summary>
        /// <param name="container">The container.</param><param name="store">The configuration store.</param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                AllTypes.FromThisAssembly().BasedOn<INotification>()
                .Configure(x => x.LifeStyle.Transient));
        }

        #endregion
    }
}
