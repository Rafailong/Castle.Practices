// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LogOnModel.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   ViewModel for LogIn.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CastleWindsor02.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// ViewModel for LogIn.
    /// </summary>
    public class LogOnModel
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [remember me].
        /// </summary>
        /// <value><c>true</c> if [remember me]; otherwise, <c>false</c>.</value>
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}