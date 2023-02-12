#### [CloudyWing.FormModule.Domain](index.md 'index')
### [CloudyWing.FormModule.Domain](CloudyWing.FormModule.Domain.md 'CloudyWing.FormModule.Domain')

## IUserIdConverter<TUserKey> Interface

Represents a converter for converting between a string representation and the type [TUserKey](CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.md#CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.TUserKey 'CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey>.TUserKey') of a user identifier.

```csharp
public interface IUserIdConverter<TUserKey>
    where TUserKey : System.IEquatable<TUserKey>
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.TUserKey'></a>

`TUserKey`

The type of the user identifier.

Derived  
&#8627; [IdConverter&lt;TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_ 'CloudyWing.FormModule.Domain.IdConverter<TKey,TUserKey>')
### Methods

<a name='CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.ConvertUserIdFromString(string)'></a>

## IUserIdConverter<TUserKey>.ConvertUserIdFromString(string) Method

Converts a string representation of the second key type `TUserKey` to its corresponding value.

```csharp
TUserKey? ConvertUserIdFromString(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.ConvertUserIdFromString(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string representation of the key to be converted.

#### Returns
[TUserKey](CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.md#CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.TUserKey 'CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey>.TUserKey')  
The converted key value.

<a name='CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.ConvertUserIdToString(TUserKey)'></a>

## IUserIdConverter<TUserKey>.ConvertUserIdToString(TUserKey) Method

Converts the key type `TUserKey` to its string representation.

```csharp
string? ConvertUserIdToString(TUserKey? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.ConvertUserIdToString(TUserKey).id'></a>

`id` [TUserKey](CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.md#CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.TUserKey 'CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey>.TUserKey')

The key to be converted.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string representation of the key.