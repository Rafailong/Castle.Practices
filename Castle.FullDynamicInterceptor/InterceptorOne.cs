// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InterceptorOne.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   A simple interceptor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.FullDynamicInterceptor
{
    using System;

    using Castle.DynamicProxy;

    /// <summary>
    /// A simple interceptor.
    /// </summary>
    public class InterceptorOne : IInterceptor
    {
        #region Implementation of IInterceptor

        /// <summary>
        /// Intercepts the specified invocation.
        /// </summary>
        /// <param name="invocation">The invocation.</param>
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("before - one");
            invocation.Proceed();
            Console.WriteLine("after - one");
        }

        #endregion
    }
}
