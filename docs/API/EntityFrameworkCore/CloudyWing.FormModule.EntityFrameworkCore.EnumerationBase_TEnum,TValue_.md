### [CloudyWing.FormModule.EntityFrameworkCore](CloudyWing.FormModule.EntityFrameworkCore.md 'CloudyWing.FormModule.EntityFrameworkCore')

## EnumerationBase<TEnum,TValue> Class

The enumeration base.

```csharp
public abstract class EnumerationBase<TEnum,TValue> :
System.IEquatable<TEnum>,
System.IComparable<TEnum>
    where TEnum : CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum, TValue>
    where TValue : System.IComparable
```
#### Type parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue'></a>

`TValue`

The type of the value.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EnumerationBase<TEnum,TValue>

Derived  
&#8627; [QuestionType](CloudyWing.FormModule.EntityFrameworkCore.QuestionType.md 'CloudyWing.FormModule.EntityFrameworkCore.QuestionType')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')
### Constructors

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.EnumerationBase(TValue)'></a>

## EnumerationBase(TValue) Constructor

Initializes a new instance of the [EnumerationBase&lt;TEnum,TValue&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>') class.

```csharp
protected EnumerationBase(TValue? value);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.EnumerationBase(TValue).value'></a>

`value` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The value.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.EnumerationBase(TValue,string)'></a>

## EnumerationBase(TValue, string) Constructor

Initializes a new instance of the [EnumerationBase&lt;TEnum,TValue&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>') class.

```csharp
protected EnumerationBase(TValue? value, string? name);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.EnumerationBase(TValue,string).value'></a>

`value` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The value.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.EnumerationBase(TValue,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name.
### Properties

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.Name'></a>

## EnumerationBase<TEnum,TValue>.Name Property

Gets the name.

```csharp
public string Name { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.Value'></a>

## EnumerationBase<TEnum,TValue>.Value Property

Gets the value.

```csharp
public TValue Value { get; }
```

#### Property Value
[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')  
The value.
### Methods

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.CompareTo(TValue)'></a>

## EnumerationBase<TEnum,TValue>.CompareTo(TValue) Method

Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.

```csharp
public virtual int CompareTo(TValue? other);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.CompareTo(TValue).other'></a>

`other` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

An object to compare with this instance.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A value that indicates the relative order of the objects being compared. The return value has these meanings:  
Value  
Meaning  
Less than zero  
This instance precedes [other](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.CompareTo(TValue).other 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.CompareTo(TValue).other') in the sort order.  
Zero  
This instance occurs in the same position in the sort order as [other](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.CompareTo(TValue).other 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.CompareTo(TValue).other').  
Greater than zero  
This instance follows [other](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.CompareTo(TValue).other 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.CompareTo(TValue).other') in the sort order.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.Equals(object)'></a>

## EnumerationBase<TEnum,TValue>.Equals(object) Method

Determines whether the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'), is equal to this instance.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.Equals(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') to compare with this instance.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is equal to this instance; otherwise, `false`.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.Equals(TValue)'></a>

## EnumerationBase<TEnum,TValue>.Equals(TValue) Method

Equalses the specified other.

```csharp
protected virtual bool Equals(TValue value);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.Equals(TValue).value'></a>

`value` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The other.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` If the current object value is equal to other parameters; otherwise, `false`.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.GetAll()'></a>

## EnumerationBase<TEnum,TValue>.GetAll() Method

Gets all declared enumerations.

```csharp
public static System.Collections.Generic.IEnumerable<TEnum> GetAll();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The `IEnumerable` based on a `TEnumeration`.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.GetValueType()'></a>

## EnumerationBase<TEnum,TValue>.GetValueType() Method

Gets the type of the value.

```csharp
public static System.Type GetValueType();
```

#### Returns
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type of the value.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.Parse(TValue)'></a>

## EnumerationBase<TEnum,TValue>.Parse(TValue) Method

Parses the specified value.

```csharp
public static TEnum Parse(TValue? value);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.Parse(TValue).value'></a>

`value` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The value.

#### Returns
[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')  
The enumeration.

#### Exceptions

[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.ParseName(string,bool)'></a>

## EnumerationBase<TEnum,TValue>.ParseName(string, bool) Method

Parses the name.

```csharp
public static TEnum ParseName(string name, bool ignoreCase=false);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.ParseName(string,bool).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.ParseName(string,bool).ignoreCase'></a>

`ignoreCase` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [ignore case].

#### Returns
[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')  
`true` enumeration if it can be found; otherwise, `false`.

#### Exceptions

[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.ToString()'></a>

## EnumerationBase<TEnum,TValue>.ToString() Method

Converts to string.

```csharp
public override string ToString();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TryParse(TValue,TEnum)'></a>

## EnumerationBase<TEnum,TValue>.TryParse(TValue, TEnum) Method

Tries the parse.

```csharp
public static bool TryParse(TValue? value, out TEnum? enumeration);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TryParse(TValue,TEnum).value'></a>

`value` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The value.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TryParse(TValue,TEnum).enumeration'></a>

`enumeration` [TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')

The enumeration.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` enumeration if it can be found; otherwise, `false`.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TryParseName(string,bool,TEnum)'></a>

## EnumerationBase<TEnum,TValue>.TryParseName(string, bool, TEnum) Method

Tries the name of the parse.

```csharp
public static bool TryParseName(string name, bool ignoreCase, out TEnum? enumeration);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TryParseName(string,bool,TEnum).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TryParseName(string,bool,TEnum).ignoreCase'></a>

`ignoreCase` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [ignore case].

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TryParseName(string,bool,TEnum).enumeration'></a>

`enumeration` [TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')

The enumeration.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` enumeration if it can be found; otherwise, `false`.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TryParseName(string,TEnum)'></a>

## EnumerationBase<TEnum,TValue>.TryParseName(string, TEnum) Method

Tries the name of the parse.

```csharp
public static bool TryParseName(string name, out TEnum? enumeration);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TryParseName(string,TEnum).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TryParseName(string,TEnum).enumeration'></a>

`enumeration` [TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')

The enumeration.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` enumeration if it can be found; otherwise, `false`.
### Operators

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Equality(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue)'></a>

## EnumerationBase<TEnum,TValue>.operator ==(EnumerationBase<TEnum,TValue>, TValue) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? left, TValue right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Equality(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue).left'></a>

`left` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Equality(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue).right'></a>

`right` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Equality(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_)'></a>

## EnumerationBase<TEnum,TValue>.operator ==(TEnum, EnumerationBase<TEnum,TValue>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(TEnum? left, CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Equality(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).left'></a>

`left` [TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Equality(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).right'></a>

`right` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Equality(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_)'></a>

## EnumerationBase<TEnum,TValue>.operator ==(TValue, EnumerationBase<TEnum,TValue>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(TValue left, CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Equality(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).left'></a>

`left` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Equality(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).right'></a>

`right` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_ExplicitCloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_(TValue)'></a>

## EnumerationBase<TEnum,TValue>.explicit operator EnumerationBase<TEnum,TValue>(TValue) Operator

Performs an explicit conversion from `TValue` to [EnumerationBase&lt;TEnum,TValue&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>').

```csharp
public static CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue> explicit operator EnumerationBase<TEnum,TValue>(TValue value);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_ExplicitCloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_(TValue).value'></a>

`value` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The value.

#### Returns
[CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')  
The result of the conversion.

#### Exceptions

[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThan(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue)'></a>

## EnumerationBase<TEnum,TValue>.operator >(EnumerationBase<TEnum,TValue>, TValue) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? left, TValue right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThan(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue).left'></a>

`left` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThan(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue).right'></a>

`right` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThan(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_)'></a>

## EnumerationBase<TEnum,TValue>.operator >(TEnum, EnumerationBase<TEnum,TValue>) Operator

Implements the operator >.

```csharp
public static bool operator >(TEnum? left, CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThan(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).left'></a>

`left` [TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThan(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).right'></a>

`right` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThan(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_)'></a>

## EnumerationBase<TEnum,TValue>.operator >(TValue, EnumerationBase<TEnum,TValue>) Operator

Implements the operator >.

```csharp
public static bool operator >(TValue left, CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThan(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).left'></a>

`left` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThan(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).right'></a>

`right` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThanOrEqual(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue)'></a>

## EnumerationBase<TEnum,TValue>.operator >=(EnumerationBase<TEnum,TValue>, TValue) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue> left, TValue right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThanOrEqual(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue).left'></a>

`left` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThanOrEqual(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue).right'></a>

`right` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThanOrEqual(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_)'></a>

## EnumerationBase<TEnum,TValue>.operator >=(TEnum, EnumerationBase<TEnum,TValue>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(TEnum? left, CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThanOrEqual(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).left'></a>

`left` [TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThanOrEqual(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).right'></a>

`right` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThanOrEqual(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_)'></a>

## EnumerationBase<TEnum,TValue>.operator >=(TValue, EnumerationBase<TEnum,TValue>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(TValue left, CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThanOrEqual(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).left'></a>

`left` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_GreaterThanOrEqual(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).right'></a>

`right` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_ImplicitTValue(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_)'></a>

## EnumerationBase<TEnum,TValue>.implicit operator TValue(EnumerationBase<TEnum,TValue>) Operator

Performs an implicit conversion from [EnumerationBase&lt;TEnum,TValue&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>') to `TValue`.

```csharp
public static TValue implicit operator TValue(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue> enumeration);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_ImplicitTValue(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).enumeration'></a>

`enumeration` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The enumeration.

#### Returns
[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')  
The result of the conversion.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Inequality(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue)'></a>

## EnumerationBase<TEnum,TValue>.operator !=(EnumerationBase<TEnum,TValue>, TValue) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? left, TValue right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Inequality(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue).left'></a>

`left` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Inequality(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue).right'></a>

`right` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Inequality(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_)'></a>

## EnumerationBase<TEnum,TValue>.operator !=(TEnum, EnumerationBase<TEnum,TValue>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(TEnum? left, CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Inequality(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).left'></a>

`left` [TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Inequality(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).right'></a>

`right` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Inequality(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_)'></a>

## EnumerationBase<TEnum,TValue>.operator !=(TValue, EnumerationBase<TEnum,TValue>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(TValue left, CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Inequality(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).left'></a>

`left` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_Inequality(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).right'></a>

`right` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThan(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue)'></a>

## EnumerationBase<TEnum,TValue>.operator <(EnumerationBase<TEnum,TValue>, TValue) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? left, TValue right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThan(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue).left'></a>

`left` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThan(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue).right'></a>

`right` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThan(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_)'></a>

## EnumerationBase<TEnum,TValue>.operator <(TEnum, EnumerationBase<TEnum,TValue>) Operator

Implements the operator <.

```csharp
public static bool operator <(TEnum? left, CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThan(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).left'></a>

`left` [TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThan(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).right'></a>

`right` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThan(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_)'></a>

## EnumerationBase<TEnum,TValue>.operator <(TValue, EnumerationBase<TEnum,TValue>) Operator

Implements the operator <.

```csharp
public static bool operator <(TValue left, CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThan(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).left'></a>

`left` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThan(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).right'></a>

`right` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThanOrEqual(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue)'></a>

## EnumerationBase<TEnum,TValue>.operator <=(EnumerationBase<TEnum,TValue>, TValue) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? left, TValue right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThanOrEqual(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue).left'></a>

`left` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThanOrEqual(CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_,TValue).right'></a>

`right` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThanOrEqual(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_)'></a>

## EnumerationBase<TEnum,TValue>.operator <=(TEnum, EnumerationBase<TEnum,TValue>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(TEnum? left, CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThanOrEqual(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).left'></a>

`left` [TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThanOrEqual(TEnum,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).right'></a>

`right` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThanOrEqual(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_)'></a>

## EnumerationBase<TEnum,TValue>.operator <=(TValue, EnumerationBase<TEnum,TValue>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(TValue left, CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>? right);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThanOrEqual(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).left'></a>

`left` [TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')

The left.

<a name='CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.op_LessThanOrEqual(TValue,CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_).right'></a>

`right` [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TEnum 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TEnum')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md#CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.TValue 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>.TValue')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.