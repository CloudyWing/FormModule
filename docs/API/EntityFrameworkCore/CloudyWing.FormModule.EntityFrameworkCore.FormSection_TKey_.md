### [CloudyWing.FormModule.EntityFrameworkCore](CloudyWing.FormModule.EntityFrameworkCore.md 'CloudyWing.FormModule.EntityFrameworkCore')

## FormSection<TKey> Class

The form section in form module.

```csharp
public class FormSection<TKey>
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormSection_TKey_.TKey'></a>

`TKey`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormSection<TKey>
### Properties

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormSection_TKey_.DisplayOrder'></a>

## FormSection<TKey>.DisplayOrder Property

Gets or sets the display order for this section within the form.

```csharp
public int DisplayOrder { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormSection_TKey_.FormId'></a>

## FormSection<TKey>.FormId Property

Gets or sets the form ID that this section belongs to.

```csharp
public TKey FormId { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormSection_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormSection_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>.TKey')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormSection_TKey_.Id'></a>

## FormSection<TKey>.Id Property

Gets or sets the primary key for this form section.

```csharp
public TKey Id { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormSection_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormSection_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>.TKey')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormSection_TKey_.Name'></a>

## FormSection<TKey>.Name Property

Gets or sets the name for this form section.

```csharp
public string? Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')