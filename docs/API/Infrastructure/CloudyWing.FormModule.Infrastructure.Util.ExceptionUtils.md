#### [CloudyWing.FormModule.Infrastructure](index.md 'index')
### [CloudyWing.FormModule.Infrastructure.Util](CloudyWing.FormModule.Infrastructure.Util.md 'CloudyWing.FormModule.Infrastructure.Util')

## ExceptionUtils Class

Provides utility methods for handling exceptions.

```csharp
internal static class ExceptionUtils
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ExceptionUtils
### Methods

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfInvalidAssignableType(System.Type,System.Type)'></a>

## ExceptionUtils.ThrowIfInvalidAssignableType(Type, Type) Method

Throws an [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') if the specified value type is not assignable to the specified assignable type.

```csharp
public static void ThrowIfInvalidAssignableType(System.Type assignableType, System.Type? valueType);
```
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfInvalidAssignableType(System.Type,System.Type).assignableType'></a>

`assignableType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type to assign to.

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfInvalidAssignableType(System.Type,System.Type).valueType'></a>

`valueType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type to check for assignment compatibility.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Thrown if the specified value type is not assignable to the specified assignable type.

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfInvalidConversion_T_(T)'></a>

## ExceptionUtils.ThrowIfInvalidConversion<T>(T) Method

Throws an [System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException') if the specified value is null.

```csharp
public static void ThrowIfInvalidConversion<T>(T? value);
```
#### Type parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfInvalidConversion_T_(T).T'></a>

`T`

The type of the value.
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfInvalidConversion_T_(T).value'></a>

`value` [T](CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.md#CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfInvalidConversion_T_(T).T 'CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfInvalidConversion<T>(T).T')

The value to check for null.

#### Exceptions

[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
Thrown if the specified value is null.

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfItemNotFound_T_(T,string)'></a>

## ExceptionUtils.ThrowIfItemNotFound<T>(T, string) Method

Throws an [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') if the specified value is null.

```csharp
public static void ThrowIfItemNotFound<T>(T? value, string paramName);
```
#### Type parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfItemNotFound_T_(T,string).T'></a>

`T`

The type of the value.
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfItemNotFound_T_(T,string).value'></a>

`value` [T](CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.md#CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfItemNotFound_T_(T,string).T 'CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfItemNotFound<T>(T, string).T')

The value to check for null.

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfItemNotFound_T_(T,string).paramName'></a>

`paramName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the parameter.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Thrown if the specified value is null.

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNotAny_T_(System.Linq.Expressions.Expression_System.Func_System.Collections.Generic.IEnumerable_T___,bool)'></a>

## ExceptionUtils.ThrowIfNotAny<T>(Expression<Func<IEnumerable<T>>>, bool) Method

Throws an [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') if the specified collection expression is null or empty.

```csharp
public static void ThrowIfNotAny<T>(System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<T>>> expression, bool isNull=true);
```
#### Type parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNotAny_T_(System.Linq.Expressions.Expression_System.Func_System.Collections.Generic.IEnumerable_T___,bool).T'></a>

`T`

The type of the collection.
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNotAny_T_(System.Linq.Expressions.Expression_System.Func_System.Collections.Generic.IEnumerable_T___,bool).expression'></a>

`expression` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.md#CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNotAny_T_(System.Linq.Expressions.Expression_System.Func_System.Collections.Generic.IEnumerable_T___,bool).T 'CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNotAny<T>(System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<T>>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The collection expression to evaluate.

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNotAny_T_(System.Linq.Expressions.Expression_System.Func_System.Collections.Generic.IEnumerable_T___,bool).isNull'></a>

`isNull` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

A parameter that is ignored and has no meaning.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Thrown if the specified collection expression is null or empty.

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNull_T_(System.Linq.Expressions.Expression_System.Func_T__,bool)'></a>

## ExceptionUtils.ThrowIfNull<T>(Expression<Func<T>>, bool) Method

Throws an [System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException') if the specified expression evaluates to null.

```csharp
public static void ThrowIfNull<T>(System.Linq.Expressions.Expression<System.Func<T>> expression, bool isNull=true);
```
#### Type parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNull_T_(System.Linq.Expressions.Expression_System.Func_T__,bool).T'></a>

`T`

The type of the expression.
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNull_T_(System.Linq.Expressions.Expression_System.Func_T__,bool).expression'></a>

`expression` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.md#CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNull_T_(System.Linq.Expressions.Expression_System.Func_T__,bool).T 'CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNull<T>(System.Linq.Expressions.Expression<System.Func<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The expression to evaluate.

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNull_T_(System.Linq.Expressions.Expression_System.Func_T__,bool).isNull'></a>

`isNull` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

A parameter that is ignored and has no meaning.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Thrown if the specified expression evaluates to null.

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNullOrWhiteSpace(System.Linq.Expressions.Expression_System.Func_string__,bool)'></a>

## ExceptionUtils.ThrowIfNullOrWhiteSpace(Expression<Func<string>>, bool) Method

Throws an [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') if the specified string expression is null or whitespace.

```csharp
public static void ThrowIfNullOrWhiteSpace(System.Linq.Expressions.Expression<System.Func<string?>> expression, bool isNull=true);
```
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNullOrWhiteSpace(System.Linq.Expressions.Expression_System.Func_string__,bool).expression'></a>

`expression` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The string expression to evaluate.

<a name='CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils.ThrowIfNullOrWhiteSpace(System.Linq.Expressions.Expression_System.Func_string__,bool).isNull'></a>

`isNull` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

A parameter that is ignored and has no meaning.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Thrown if the specified string expression is null or whitespace.