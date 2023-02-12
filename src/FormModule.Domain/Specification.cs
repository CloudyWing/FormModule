using System.Linq.Expressions;

namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Represents a specification for querying entities of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of the entity.</typeparam>
    public class Specification<T> where T : class {
        /// <summary>
        /// Gets or sets the filter expression to apply.
        /// </summary>
        public Expression<Func<T, bool>>? Filter { get; set; }

        /// <summary>
        /// Gets or sets the order generator expression to apply.
        /// </summary>
        public Func<IQueryable<T>, IOrderedQueryable<T>>? OrderByGenerator { get; set; }

        /// <summary>
        /// Gets or sets the group by expression to apply.
        /// </summary>
        public Expression<Func<T, object>>? GroupBy { get; set; }

        /// <summary>
        /// Gets or sets the number of entities to take.
        /// </summary>
        public int? Take { get; set; }

        /// <summary>
        /// Gets or sets the number of entities to skip.
        /// </summary>
        public int? Skip { get; set; }
    }
}
