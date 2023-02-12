using System.Reflection;
using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Provides mapping functionality between editor objects and entity objects for form modules.
    /// </summary>
    /// <typeparam name="TKey">The type of the key used in the entity.</typeparam>
    /// <typeparam name="TUserKey">The type of the user key used in the entity.</typeparam>
    public class FormModuleMapper<TKey, TUserKey> : IFormModuleMapper
        where TKey : struct, IEquatable<TKey>
        where TUserKey : IEquatable<TUserKey> {
        private readonly IIdConverter<TKey> idConverter;
        private readonly IUserIdConverter<TUserKey> userIdConverter;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormModuleMapper{TKey, TUserKey}"/> class.
        /// </summary>
        /// <param name="idConverter">The ID converter.</param>
        /// <param name="userIdConverter">The user ID converter.</param>
        public FormModuleMapper(IIdConverter<TKey> idConverter, IUserIdConverter<TUserKey> userIdConverter) {
            ExceptionUtils.ThrowIfNull(() => idConverter);
            ExceptionUtils.ThrowIfNull(() => userIdConverter);

            this.idConverter = idConverter;
            this.userIdConverter = userIdConverter;
        }

        /// <inheritdoc/>
        public TEntity Map<TEditor, TEntity>(TEditor editor)
            where TEntity : new() {
            TEntity entity = new();
            Map(editor, entity);

            return entity;
        }

        /// <inheritdoc/>
        public void Map<TEditor, TEntity>(TEditor editor, TEntity entity)
            where TEntity : new() {
            IEnumerable<PropertyInfo> editorProps = typeof(TEditor)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(x => x.CanRead);
            IEnumerable<PropertyInfo> entityProps = typeof(TEntity)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(x => x.CanRead && x.CanWrite);

            foreach (PropertyInfo editorProp in editorProps) {
                PropertyInfo? entityProp = entityProps.SingleOrDefault(x => x.Name.Equals(editorProp.Name, StringComparison.OrdinalIgnoreCase));
                if (entityProp is not null) {
                    MapProperty(editor, editorProp, entity, entityProp);
                } else if (editorProp.Name == "ExecutedBy") {
                    string? executedBy = editorProp.GetValue(editor)?.ToString();
                    MapExecutedProperties(entity, executedBy, entityProps);
                }
            }
        }

        private void MapProperty<TEditor, TEntity>(TEditor editor, PropertyInfo editorProperty, TEntity entity, PropertyInfo entityProperty) {
            object? editorPropValue = editorProperty.GetValue(editor);

            if (editorProperty.PropertyType.IsGenericType
                && typeof(ValueWatcher<>).IsAssignableFrom(editorProperty.PropertyType.GetGenericTypeDefinition())
            ) {
                bool hasValue = (bool)editorProperty.PropertyType.GetProperty("HasValue")!.GetValue(editorPropValue)!;
                if (hasValue) {
                    object? value = editorProperty.PropertyType.GetProperty(name: "Value")!.GetValue(editorPropValue);

                    if (entityProperty.Name.EndsWith("Id")
                        && editorProperty.PropertyType.GetGenericArguments()[0] == typeof(string)
                        && (entityProperty.PropertyType == typeof(TKey) || entityProperty.PropertyType == typeof(TKey?))
                    ) {
                        TKey? id = idConverter.ConvertIdFromString((string?)editorPropValue);
                        entityProperty.SetValue(entity, id);
                    } else {
                        entityProperty.SetValue(entity, value);
                    }
                }
            } else if (editorProperty.PropertyType == entityProperty.PropertyType) {
                entityProperty.SetValue(entity, editorPropValue);
            } else if (entityProperty.Name.EndsWith("Id")
                && editorProperty.PropertyType == typeof(string)
                && (entityProperty.PropertyType == typeof(TKey) || entityProperty.PropertyType == typeof(TKey?))
            ) {
                TKey? id = idConverter.ConvertIdFromString((string?)editorPropValue);
                entityProperty.SetValue(entity, id);
            }
        }

        private void MapExecutedProperties<TEntity>(TEntity entity, string? executedBy, IEnumerable<PropertyInfo> entityProps)
            where TEntity : new() {
            PropertyInfo? createdByProp = entityProps.SingleOrDefault(x => x.Name == "CreatedBy");
            PropertyInfo? createdAtProp = entityProps.SingleOrDefault(x => x.Name == "CreatedAt");
            PropertyInfo? updatedByProp = entityProps.SingleOrDefault(x => x.Name == "UpdatedBy");
            PropertyInfo? updatedAtProp = entityProps.SingleOrDefault(x => x.Name == "UpdatedAt");
            TUserKey? convertedExecutedBy = userIdConverter.ConvertUserIdFromString(executedBy);

            if (createdAtProp is not null) {
                DateTimeOffset now = DateTimeOffsetUtils.GetTaipeiNow();

                if (executedBy is not null) {
                    updatedByProp?.SetValue(entity, convertedExecutedBy);
                }
                updatedAtProp?.SetValue(entity, now);

                if ((DateTimeOffset)createdAtProp.GetValue(entity)! == default) {
                    if (executedBy is not null) {
                        createdByProp?.SetValue(entity, convertedExecutedBy);
                    }
                    createdAtProp?.SetValue(entity, now);
                }
            }
        }
    }
}
