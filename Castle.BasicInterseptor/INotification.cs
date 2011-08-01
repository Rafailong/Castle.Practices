// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INotification.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Contract to the notifications.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.BasicInterseptor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Contract to the notifications.
    /// </summary>
    public interface INotification
    {
        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        void Send(string message);
    }
}
