// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Main entry point of the application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.SimpleDynamicInterceptor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Castle.Windsor;
    using Castle.Windsor.Installer;

    /// <summary>
    /// Main entry point of the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Mains the specified args.
        /// </summary>
        /// <param name="args">The args.</param>
        public static void Main(string[] args)
        {
            using (IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This()))
            {
                IService service = container.Resolve<IService>();
                service.ActionToPerform();
            }

            Console.ReadLine();
        }
    }
}
