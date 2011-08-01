// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomNotification.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Custom interceptor, to send notification.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.BasicInterseptor
{
    using System;

    using Castle.DynamicProxy;

    /// <summary>
    /// Custom interceptor, to send notification.
    /// </summary>
    public class CustomNotification : IInterceptor
    {
        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Send(string message)
        {
            Console.WriteLine("Sending Message...");
            Console.WriteLine(string.Format("Message: {0}", message));
            Console.WriteLine("Message Sent");
        }

        #region Implementation of IInterceptor

        /// <summary>
        /// Intercepts the specified invocation.
        /// </summary>
        /// <param name="invocation">The invocation.</param>
        public void Intercept(IInvocation invocation)
        {
            Send(invocation.MethodInvocationTarget.Name);
            invocation.Proceed();
        }

        #endregion
    }
}
