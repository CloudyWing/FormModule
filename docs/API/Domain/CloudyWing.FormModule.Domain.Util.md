#### [CloudyWing.FormModule.Domain](index.md 'index')

## CloudyWing.FormModule.Domain.Util Namespace
### Classes

<a name='CloudyWing.FormModule.Domain.Util.ValueWatcherExceptionUtils'></a>

## ValueWatcherExceptionUtils Class

Provides utility methods for handling exceptions related to ValueWatcher types.

```csharp
public static class ValueWatcherExceptionUtils
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ValueWatcherExceptionUtils
### Methods

<a name='CloudyWing.FormModule.Domain.Util.ValueWatcherExceptionUtils.ThrowIfValueIsNullOrWhiteSpace(System.Linq.Expressions.Expression_System.Func_CloudyWing.FormModule.Domain.ValueWatcher_string___,bool)'></a>

## ValueWatcherExceptionUtils.ThrowIfValueIsNullOrWhiteSpace(Expression<Func<ValueWatcher<string>>>, bool) Method

Throws an exception if the ValueWatcher is set and its value is null or empty.

```csharp
public static void ThrowIfValueIsNullOrWhiteSpace(System.Linq.Expressions.Expression<System.Func<CloudyWing.FormModule.Domain.ValueWatcher<string?>>> valueWatcherExpression, bool isNull=true);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.Util.ValueWatcherExceptionUtils.ThrowIfValueIsNullOrWhiteSpace(System.Linq.Expressions.Expression_System.Func_CloudyWing.FormModule.Domain.ValueWatcher_string___,bool).valueWatcherExpression'></a>

`valueWatcherExpression` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

An expression representing the ValueWatcher.

<a name='CloudyWing.FormModule.Domain.Util.ValueWatcherExceptionUtils.ThrowIfValueIsNullOrWhiteSpace(System.Linq.Expressions.Expression_System.Func_CloudyWing.FormModule.Domain.ValueWatcher_string___,bool).isNull'></a>

`isNull` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

A parameter that is ignored and has no meaning.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Thrown when the ValueWatcher is set and its value is null or whitespace.

<a name='CloudyWing.FormModule.Domain.Util.ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSet_T_(System.Linq.Expressions.Expression_System.Func_CloudyWing.FormModule.Domain.ValueWatcher_T___,bool)'></a>

## ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSet<T>(Expression<Func<ValueWatcher<T>>>, bool) Method

Throws an exception if the ValueWatcher does not have a value.

```csharp
public static void ThrowIfValueWatcherNotSet<T>(System.Linq.Expressions.Expression<System.Func<CloudyWing.FormModule.Domain.ValueWatcher<T>>> valueWatcherExpression, bool isNull=true);
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.Util.ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSet_T_(System.Linq.Expressions.Expression_System.Func_CloudyWing.FormModule.Domain.ValueWatcher_T___,bool).T'></a>

`T`

The type of the ValueWatcher.
#### Parameters

<a name='CloudyWing.FormModule.Domain.Util.ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSet_T_(System.Linq.Expressions.Expression_System.Func_CloudyWing.FormModule.Domain.ValueWatcher_T___,bool).valueWatcherExpression'></a>

`valueWatcherExpression` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[T](CloudyWing.FormModule.Domain.Util.md#CloudyWing.FormModule.Domain.Util.ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSet_T_(System.Linq.Expressions.Expression_System.Func_CloudyWing.FormModule.Domain.ValueWatcher_T___,bool).T 'CloudyWing.FormModule.Domain.Util.ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSet<T>(System.Linq.Expressions.Expression<System.Func<CloudyWing.FormModule.Domain.ValueWatcher<T>>>, bool).T')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

An expression representing the ValueWatcher.

<a name='CloudyWing.FormModule.Domain.Util.ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSet_T_(System.Linq.Expressions.Expression_System.Func_CloudyWing.FormModule.Domain.ValueWatcher_T___,bool).isNull'></a>

`isNull` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

A parameter that is ignored and has no meaning.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Thrown when the ValueWatcher does not have a value.

<a name='CloudyWing.FormModule.Domain.Util.ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSetOrValueIsNullOrWhiteSpace(System.Linq.Expressions.Expression_System.Func_CloudyWing.FormModule.Domain.ValueWatcher_string___,bool)'></a>

## ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSetOrValueIsNullOrWhiteSpace(Expression<Func<ValueWatcher<string>>>, bool) Method

Throws an exception if the ValueWatcher is not set or its value is null or empty.

```csharp
public static void ThrowIfValueWatcherNotSetOrValueIsNullOrWhiteSpace(System.Linq.Expressions.Expression<System.Func<CloudyWing.FormModule.Domain.ValueWatcher<string?>>> valueWatcherExpression, bool isNull=true);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.Util.ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSetOrValueIsNullOrWhiteSpace(System.Linq.Expressions.Expression_System.Func_CloudyWing.FormModule.Domain.ValueWatcher_string___,bool).valueWatcherExpression'></a>

`valueWatcherExpression` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

An expression representing the ValueWatcher.

<a name='CloudyWing.FormModule.Domain.Util.ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSetOrValueIsNullOrWhiteSpace(System.Linq.Expressions.Expression_System.Func_CloudyWing.FormModule.Domain.ValueWatcher_string___,bool).isNull'></a>

`isNull` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

A parameter that is ignored and has no meaning.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Thrown when the ValueWatcher is not set or its value is null or whitespace.