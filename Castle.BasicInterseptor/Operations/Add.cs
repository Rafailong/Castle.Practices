// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Add.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Implementation for the adding operation of two numbers.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.BasicInterseptor.Operations
{
    using Castle.Core;

    /// <summary>
    /// Implementation for the adding operation of two numbers.
    /// </summary>
    [Interceptor(typeof(CustomNotification))]
    public class Add : IOperation
    {
        #region Implementation of IOperation

        /// <summary>
        /// Performs the operation.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="raight">The raight.</param>
        /// <returns>
        /// The result of the operation.
        /// </returns>
        public int PerformOperation(int left, int raight)
        {
            return left + raight;
        }

        #endregion
    }
}
