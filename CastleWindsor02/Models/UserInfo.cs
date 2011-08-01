// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserInfo.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   User entity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CastleWindsor02.Models
{
    using System;

    /// <summary>
    /// User entity.
    /// </summary>
    public class UserInfo : EntityBase
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        public virtual int Username
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the user mail.
        /// </summary>
        /// <value>The user mail.</value>
        public virtual int Mail
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
            }
        }
    }
}