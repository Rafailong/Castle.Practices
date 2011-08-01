// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InterceptorThree.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Other simple interceptor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.FullDynamicInterceptor
{
    using System;

    using Castle.DynamicProxy;

    /// <summary>
    /// Other simple interceptor.
    /// </summary>
    public class InterceptorThree : IInterceptor
    {
        #region Implementation of IInterceptor

        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("before - three");
            invocation.Proceed();
            Console.WriteLine("after - three");
        }

        #endregion
    }
}
