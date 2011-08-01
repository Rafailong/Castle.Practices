// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleService.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Simple implementation of <see cref="IService" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.SimpleDynamicInterceptor
{
    using System;

    using Castle.Core;

    /// <summary>
    /// Simple implementation of <see cref="IService"/>.
    /// </summary>
    [Interceptor(typeof(OtherSimpleInterceptor))]
    public class SimpleService : IService
    {
        #region Implementation of IService

        /// <summary>
        /// Actions to perform.
        /// </summary>
        public void ActionToPerform()
        {
            Console.WriteLine("An exception is thrown ]:) ");
            throw new NotImplementedException("this is what you don't want to happend !");
        }

        #endregion
    }
}
