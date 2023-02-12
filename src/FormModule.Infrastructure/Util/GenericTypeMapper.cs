namespace CloudyWing.FormModule.Infrastructure.Util {
    /// <summary>
    /// Provides a generic type mapper that maps type names to their corresponding .NET types.
    /// </summary>
    public class GenericTypeMapper {
        private readonly Dictionary<string, Type> typeMaps = new();

        /// <summary>
        /// Adds a type map that associates the specified type name with the given .NET type.
        /// </summary>
        /// <param name="typeName">The name of the type to map.</param>
        /// <param name="type">The .NET type to associate with the type name.</param>
        public void AddTypeMap(string typeName, Type type) {
            typeMaps[typeName] = type;
        }

        /// <summary>
        /// Adds a type map that maps the generic type arguments of the specified generic basic type to the generic type arguments of the current type.
        /// </summary>
        /// <param name="genericBasicType">The generic basic type with generic arguments to map.</param>
        /// <param name="currentType">The current type from which to extract the generic type arguments.</param>
        public void AddTypeMap(Type genericBasicType, Type currentType) {
            Type[] genericBasicTypeArgs = genericBasicType.GetGenericArguments();
            Type[] currentTypeArgs = FindGenericBasicType(genericBasicType, currentType).GetGenericArguments();
            AddGenericTypeMaps(typeMaps, genericBasicTypeArgs, currentTypeArgs);
        }

        private static Type FindGenericBasicType(Type genericBasicType, Type currentType) {
            Type? type = currentType;
            while (type != null) {
                var currentGenericType = type.IsGenericType ? type.GetGenericTypeDefinition() : null;
                if (currentGenericType != null && currentGenericType == genericBasicType) {
                    return type;
                }
                type = type.BaseType;
            }

            throw new ArgumentException($"The type {currentType.Name} does not inherit from the specified type {genericBasicType.Name}.");
        }

        private static void AddGenericTypeMaps(Dictionary<string, Type> maps, Type[] genericBasicTypeArgs, Type[] currentTypeArgs) {
            for (int i = 0; i < genericBasicTypeArgs.Length; i++) {
                maps[genericBasicTypeArgs[i].Name] = currentTypeArgs[i];
            }
        }

        /// <summary>
        /// Makes a generic type by substituting the type arguments of the specified generic type with the corresponding types from the type map.
        /// </summary>
        /// <param name="genericType">The generic type for which to make a specialized type.</param>
        /// <returns>The specialized type with the substituted type arguments.</returns>
        public Type MakeGenericType(Type genericType) {
            Type[] currentTypeArgs = new Type[genericType.GetGenericArguments().Length];
            for (int i = 0; i < genericType.GetGenericArguments().Length; i++) {
                currentTypeArgs[i] = typeMaps[genericType.GetGenericArguments()[i].Name];
            }

            return genericType.MakeGenericType(currentTypeArgs);
        }

        /// <summary>
        /// Makes a generic type by substituting the type arguments of the specified generic type with the corresponding types from the type map, based on the service type.
        /// </summary>
        /// <param name="genericType">The generic type for which to make a specialized type.</param>
        /// <param name="serviceType">The service type from which to extract the generic type arguments.</param>
        /// <returns>The specialized type with the substituted type arguments.</returns>
        public Type MakeGenericType(Type genericType, Type serviceType) {
            Type genericBasicType = serviceType.GetGenericTypeDefinition();
            Type[] genericBasicTypeArgs = genericBasicType.GetGenericArguments();
            Type[] serviceTypeArgs = FindGenericBasicType(genericBasicType, serviceType).GetGenericArguments();
            Dictionary<string, Type> _typeMaps = typeMaps.ToDictionary(x => x.Key, x => x.Value);
            AddGenericTypeMaps(_typeMaps, genericBasicTypeArgs, serviceTypeArgs);

            Type[] currentTypeArgs = new Type[genericType.GetGenericArguments().Length];
            for (int i = 0; i < genericType.GetGenericArguments().Length; i++) {
                currentTypeArgs[i] = _typeMaps[genericType.GetGenericArguments()[i].Name];
            }

            return genericType.MakeGenericType(currentTypeArgs);
        }

        /// <summary>
        /// Makes a generic type by substituting the type arguments of the specified generic type with the corresponding types from the type map, based on the provided argument types.
        /// </summary>
        /// <param name="genericType">The generic type for which to make a specialized type.</param>
        /// <param name="argumentTypes">The names of the types to substitute the type arguments with.</param>
        /// <returns>The specialized type with the substituted type arguments.</returns>
        public Type MakeGenericType(Type genericType, params string[] argumentTypes) {
            Type[] currentTypeArgs = argumentTypes.Select(x => typeMaps[x]).ToArray();
            return genericType.MakeGenericType(currentTypeArgs);
        }
    }
}
