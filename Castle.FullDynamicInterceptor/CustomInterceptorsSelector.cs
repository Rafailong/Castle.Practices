// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomInterceptorsSelector.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Custom Interceptors Selector Model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Castle.FullDynamicInterceptor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Castle.Core;
    using Castle.MicroKernel.Proxy;

    /// <summary>
    /// Custom Interceptors Selector Model.
    /// </summary>
    public class CustomInterceptorsSelector : IModelInterceptorsSelector
    {
        #region Implementation of IModelInterceptorsSelector

        /// <summary>
        /// Determine whatever the specified has interceptors.
        /// The selector should only return true from this method if it has determined that is
        /// a model that it would likely add interceptors to.
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns>
        /// Whatever this selector is likely to add interceptors to the specified model
        /// </returns>
        public bool HasInterceptors(ComponentModel model)
        {
            // Looks like We must prevent to add interceptor to elements that are added
            // in SelectedInterceptors method becouse a cycle is produces and an exception
            // is thown.
            return model.Implementation == typeof(InterceptorThree) ? false : true;
        }

        /// <summary>
        /// Select the appropriate interceptor references.
        /// The interceptor references aren't necessarily registered in the model.Intereceptors
        /// </summary>
        /// <param name="model">The model to select the interceptors for</param><param name="interceptors">
        /// The interceptors selected by previous selectors in the pipeline or 
        /// <see cref="P:Castle.Core.ComponentModel.Interceptors"/> 
        /// if this is the first interceptor in the pipeline.</param>
        /// <returns>
        /// The interceptor for this model (in the current context) or a null reference
        /// </returns>
        /// <remarks>
        /// If the selector is not interested in modifying the interceptors for this model, it 
        /// should return <paramref name="interceptors"/> and the next selector in line would be executed.
        /// If the selector wants no interceptors to be used it can either return <c>null</c> or empty array.
        /// However next interceptor in line is free to override this choice.
        /// </remarks>
        public InterceptorReference[] SelectInterceptors(ComponentModel model, InterceptorReference[] interceptors)
        {
            // This clear is done becouse if not, when line 64 is execute we duplicate
            // the existing interceptor (One and Two).
            model.Interceptors.Clear();

            // we are just adding one interceptor more.
            interceptors.ToList().ForEach(i => model.Interceptors.Add(i));
            model.Interceptors.Add(InterceptorReference.ForType<InterceptorThree>());
            return model.Interceptors.ToArray();
        }

        #endregion
    }
}
