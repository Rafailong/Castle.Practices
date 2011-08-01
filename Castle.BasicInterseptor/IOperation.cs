// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOperation.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   This is just a service to register in the container to apply the interceptor to.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.BasicInterseptor
{
    using Castle.Core;

    /// <summary>
    /// This is just a service to register in the container to apply the interceptor to.
    /// </summary>
    public interface IOperation
    {
        /// <summary>
        /// Performs the operation.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="raight">The raight.</param>
        /// <returns>
        /// The result of the operation.
        /// </returns>
        int PerformOperation(int left, int raight);
    }
}
