namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Provides mapping functionality between editor and entity objects.
    /// </summary>
    public interface IFormModuleMapper {
        /// <summary>
        /// Maps properties from an editor object to a new instance of an entity object.
        /// </summary>
        /// <typeparam name="TEditor">The type of the editor object.</typeparam>
        /// <typeparam name="TEntity">The type of the entity object.</typeparam>
        /// <param name="source">The source editor object.</param>
        /// <returns>A new instance of the mapped entity object.</returns>
        TEntity Map<TEditor, TEntity>(TEditor source) where TEntity : new();

        /// <summary>
        /// Maps properties from an editor object to an existing instance of an entity object.
        /// </summary>
        /// <typeparam name="TEditor">The type of the editor object.</typeparam>
        /// <typeparam name="TEntity">The type of the entity object.</typeparam>
        /// <param name="source">The source editor object.</param>
        /// <param name="dest">The destination entity object.</param>
        void Map<TEditor, TEntity>(TEditor source, TEntity dest) where TEntity : new();
    }
}
