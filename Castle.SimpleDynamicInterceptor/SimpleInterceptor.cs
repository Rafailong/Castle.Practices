// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleInterceptor.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   A simple interceptor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.SimpleDynamicInterceptor
{
    using System;

    using Castle.DynamicProxy;

    /// <summary>
    /// A simple interceptor.
    /// </summary>
    public class SimpleInterceptor : IInterceptor
    {
        #region Implementation of IInterceptor

        /// <summary>
        /// Intercepts the specified invocation.
        /// </summary>
        /// <param name="invocation">The invocation.</param>
        public void Intercept(IInvocation invocation)
        {
            // Doing the next, we can simulate a tracer like app.
            try
            {
                invocation.Proceed();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        #endregion
    }
}
