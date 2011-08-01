// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityBase.cs" company="Rafa Avila">
//   2011
// </copyright>
// <summary>
//   Base type for all the entities.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CastleWindsor02.Models
{
    /// <summary>
    /// Base type for all the entities.
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public virtual int Id { get; set; }
    }
}