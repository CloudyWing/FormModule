#### [CloudyWing.FormModule.Infrastructure](index.md 'index')
### [CloudyWing.FormModule.Infrastructure.Util](CloudyWing.FormModule.Infrastructure.Util.md 'CloudyWing.FormModule.Infrastructure.Util')

## GenericTypeMapper Class

Provides a generic type mapper that maps type names to their corresponding .NET types.

```csharp
public class GenericTypeMapper
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; GenericTypeMapper
### Methods

<a name='CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.AddTypeMap(string,System.Type)'></a>

## GenericTypeMapper.AddTypeMap(string, Type) Method

Adds a type map that associates the specified type name with the given .NET type.

```csharp
public void AddTypeMap(string typeName, System.Type type);
```
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.AddTypeMap(string,System.Type).typeName'></a>

`typeName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the type to map.

<a name='CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.AddTypeMap(string,System.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The .NET type to associate with the type name.

<a name='CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.AddTypeMap(System.Type,System.Type)'></a>

## GenericTypeMapper.AddTypeMap(Type, Type) Method

Adds a type map that maps the generic type arguments of the specified generic basic type to the generic type arguments of the current type.

```csharp
public void AddTypeMap(System.Type genericBasicType, System.Type currentType);
```
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.AddTypeMap(System.Type,System.Type).genericBasicType'></a>

`genericBasicType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The generic basic type with generic arguments to map.

<a name='CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.AddTypeMap(System.Type,System.Type).currentType'></a>

`currentType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The current type from which to extract the generic type arguments.

<a name='CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.MakeGenericType(System.Type)'></a>

## GenericTypeMapper.MakeGenericType(Type) Method

Makes a generic type by substituting the type arguments of the specified generic type with the corresponding types from the type map.

```csharp
public System.Type MakeGenericType(System.Type genericType);
```
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.MakeGenericType(System.Type).genericType'></a>

`genericType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The generic type for which to make a specialized type.

#### Returns
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The specialized type with the substituted type arguments.

<a name='CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.MakeGenericType(System.Type,string[])'></a>

## GenericTypeMapper.MakeGenericType(Type, string[]) Method

Makes a generic type by substituting the type arguments of the specified generic type with the corresponding types from the type map, based on the provided argument types.

```csharp
public System.Type MakeGenericType(System.Type genericType, params string[] argumentTypes);
```
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.MakeGenericType(System.Type,string[]).genericType'></a>

`genericType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The generic type for which to make a specialized type.

<a name='CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.MakeGenericType(System.Type,string[]).argumentTypes'></a>

`argumentTypes` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The names of the types to substitute the type arguments with.

#### Returns
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The specialized type with the substituted type arguments.

<a name='CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.MakeGenericType(System.Type,System.Type)'></a>

## GenericTypeMapper.MakeGenericType(Type, Type) Method

Makes a generic type by substituting the type arguments of the specified generic type with the corresponding types from the type map, based on the service type.

```csharp
public System.Type MakeGenericType(System.Type genericType, System.Type serviceType);
```
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.MakeGenericType(System.Type,System.Type).genericType'></a>

`genericType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The generic type for which to make a specialized type.

<a name='CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.MakeGenericType(System.Type,System.Type).serviceType'></a>

`serviceType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The service type from which to extract the generic type arguments.

#### Returns
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The specialized type with the substituted type arguments.