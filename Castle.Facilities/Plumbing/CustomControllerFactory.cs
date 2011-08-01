// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomControllerFactory.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Custom controller factory since our controller
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.Facilities.Plumbing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    using Castle.MicroKernel;

    /// <summary>
    /// Custom controller factory since our controller 
    /// </summary>
    public class CustomControllerFactory : DefaultControllerFactory
    {
        /// <summary>
        /// Internal instace of.
        /// </summary>
        private readonly IKernel _kernel;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomControllerFactory"/> class.
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        public CustomControllerFactory(IKernel kernel)
        {
            _kernel = kernel;
        }

        #region Overrides of DefaultControllerFactory

        /// <summary>
        /// Releases the specified controller.
        /// </summary>
        /// <param name="controller">The controller to release.</param>
        public override void ReleaseController(IController controller)
        {
            if (controller == null)
            {
                throw new ArgumentNullException("controller"); 
            }

            _kernel.ReleaseComponent(controller);
        }

        /// <summary>
        /// Retrieves the controller instance for the specified request context and controller type.
        /// </summary>
        /// <returns>
        /// The controller instance.
        /// </returns>
        /// <param name="requestContext">The context of the HTTP request, which includes the HTTP context and route data.</param><param name="controllerType">The type of the controller.</param><exception cref="T:System.Web.HttpException"><paramref name="controllerType"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="controllerType"/> cannot be assigned.</exception><exception cref="T:System.InvalidOperationException">An instance of <paramref name="controllerType"/> cannot be created.</exception>
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
            {
                throw new HttpException(
                    404,
                    string.Format(
                        "The controller for path '{0}' could not be found.", requestContext.HttpContext.Request.Path));
            }

            return (IController)_kernel.Resolve(controllerType);
        }

        #endregion
    }
}