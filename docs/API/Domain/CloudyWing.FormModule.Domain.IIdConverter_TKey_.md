#### [CloudyWing.FormModule.Domain](index.md 'index')
### [CloudyWing.FormModule.Domain](CloudyWing.FormModule.Domain.md 'CloudyWing.FormModule.Domain')

## IIdConverter<TKey> Interface

Provides conversion functionality between a string representation and a key of type [TKey](CloudyWing.FormModule.Domain.IIdConverter_TKey_.md#CloudyWing.FormModule.Domain.IIdConverter_TKey_.TKey 'CloudyWing.FormModule.Domain.IIdConverter<TKey>.TKey').

```csharp
public interface IIdConverter<TKey>
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.IIdConverter_TKey_.TKey'></a>

`TKey`

The type of the key.

Derived  
&#8627; [IdConverter&lt;TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_ 'CloudyWing.FormModule.Domain.IdConverter<TKey,TUserKey>')
### Methods

<a name='CloudyWing.FormModule.Domain.IIdConverter_TKey_.ConvertIdFromString(string)'></a>

## IIdConverter<TKey>.ConvertIdFromString(string) Method

Converts a string representation of the second key type `TKey` to its corresponding value.

```csharp
System.Nullable<TKey> ConvertIdFromString(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.IIdConverter_TKey_.ConvertIdFromString(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string representation of the key to be converted.

#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TKey](CloudyWing.FormModule.Domain.IIdConverter_TKey_.md#CloudyWing.FormModule.Domain.IIdConverter_TKey_.TKey 'CloudyWing.FormModule.Domain.IIdConverter<TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The converted key value.

<a name='CloudyWing.FormModule.Domain.IIdConverter_TKey_.ConvertIdToString(System.Nullable_TKey_)'></a>

## IIdConverter<TKey>.ConvertIdToString(Nullable<TKey>) Method

Converts the key type `TKey` to its string representation.

```csharp
string? ConvertIdToString(System.Nullable<TKey> id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.IIdConverter_TKey_.ConvertIdToString(System.Nullable_TKey_).id'></a>

`id` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TKey](CloudyWing.FormModule.Domain.IIdConverter_TKey_.md#CloudyWing.FormModule.Domain.IIdConverter_TKey_.TKey 'CloudyWing.FormModule.Domain.IIdConverter<TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The key to be converted.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string representation of the key.