### [CloudyWing.FormModule.EntityFrameworkCore](CloudyWing.FormModule.EntityFrameworkCore.md 'CloudyWing.FormModule.EntityFrameworkCore')

## FormPage<TKey> Class

The form page in form module.

```csharp
public class FormPage<TKey>
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.TKey'></a>

`TKey`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormPage<TKey>
### Properties

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.CompletionTime'></a>

## FormPage<TKey>.CompletionTime Property

Gets or sets the completion time of the form page.

```csharp
public System.Nullable<System.DateTimeOffset> CompletionTime { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.CreatedAt'></a>

## FormPage<TKey>.CreatedAt Property

Gets or sets the creation time of this form page.

```csharp
public System.DateTimeOffset CreatedAt { get; set; }
```

#### Property Value
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.CreatedBy'></a>

## FormPage<TKey>.CreatedBy Property

Gets or sets the primary key of the user who created this form page.

```csharp
public string CreatedBy { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.FormId'></a>

## FormPage<TKey>.FormId Property

Gets or sets the primary key of the form that this form page belongs to.

```csharp
public TKey FormId { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>.TKey')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.Id'></a>

## FormPage<TKey>.Id Property

Gets or sets the primary key for this form page.

```csharp
public TKey Id { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>.TKey')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.IP'></a>

## FormPage<TKey>.IP Property

Gets or sets the IP address of the user who submitted the form page.

```csharp
public string IP { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.SecurityCode'></a>

## FormPage<TKey>.SecurityCode Property

Gets or sets the security code for this form page.

```csharp
public string SecurityCode { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.UpdatedAt'></a>

## FormPage<TKey>.UpdatedAt Property

Gets or sets the last updated time of this form page.

```csharp
public System.DateTimeOffset UpdatedAt { get; set; }
```

#### Property Value
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.UpdatedBy'></a>

## FormPage<TKey>.UpdatedBy Property

Gets or sets the primary key of the user who last updated this form page.

```csharp
public string UpdatedBy { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')