// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InterceptorTwo.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Simple Interceptor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.FullDynamicInterceptor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Castle.DynamicProxy;

    /// <summary>
    /// Simple Interceptor.
    /// </summary>
    public class InterceptorTwo : IInterceptor
    {
        #region Implementation of IInterceptor

        /// <summary>
        /// Intercepts the specified invocation.
        /// </summary>
        /// <param name="invocation">The invocation.</param>
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("before - two");
            invocation.Proceed();
            Console.WriteLine("after - two");
        }

        #endregion
    }
}
