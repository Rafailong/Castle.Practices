// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Defines the HomeController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CastleWindsor02.Controllers
{
    using System.Web.Mvc;

    using Castle.Core.Logging;

    /// <summary>
    /// Home page.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>Landing page.</returns>
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View();
        }

        /// <summary>
        /// Abouts this instance.
        /// </summary>
        /// <returns>About page.</returns>
        public ActionResult About()
        {
            return View();
        }
    }
}
