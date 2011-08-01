// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OtherSimpleInterceptor.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   This another interceptor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.SimpleDynamicInterceptor
{
    using System;

    using Castle.DynamicProxy;

    /// <summary>
    /// This another interceptor.
    /// </summary>
    public class OtherSimpleInterceptor : IInterceptor
    {
        #region Implementation of IInterceptor

        /// <summary>
        /// Intercepts the specified invocation.
        /// </summary>
        /// <param name="invocation">The invocation.</param>
        public void Intercept(IInvocation invocation)
        {
            try
            {
                Console.WriteLine("Something before the method.");
                invocation.Proceed();
            }
            catch (Exception exception)
            {
                Console.WriteLine(invocation.MethodInvocationTarget.Name);
                Console.WriteLine("This is the OtherSimpleInterceptor");
            }
        }

        #endregion
    }
}