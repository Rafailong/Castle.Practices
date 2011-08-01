// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleService.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Defines the SimpleService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.FullDynamicInterceptor
{
    using System;

    using Castle.Core;

    /// <summary>
    /// Defines the SimpleService type.
    /// </summary>
    [Interceptor(typeof(InterceptorOne))]
    public class SimpleService : IService
    {
        #region Implementation of IService

        /// <summary>
        /// Does something.
        /// </summary>
        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
        }

        #endregion
    }
}