// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Initial point of the app.
//   This application is the example to static and wall known Interceptors.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.BasicInterseptor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Castle.Windsor;
    using Castle.Windsor.Installer;

    /// <summary>
    /// Initial point of the app.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Mains the specified args.
        /// </summary>
        /// <param name="args">The args.</param>
        public static void Main(string[] args)
        {
            IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This());
            IOperation operation = container.Resolve<IOperation>();
            int i = operation.PerformOperation(1, 2);
            Console.WriteLine(string.Empty + i);
            Console.ReadLine();
            container.Dispose();
        }
    }
}
