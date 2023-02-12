### [CloudyWing.FormModule.EntityFrameworkCore](CloudyWing.FormModule.EntityFrameworkCore.md 'CloudyWing.FormModule.EntityFrameworkCore')

## FormPageDetail<TKey> Class

The form page detail in the form module.

```csharp
public class FormPageDetail<TKey>
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.TKey'></a>

`TKey`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormPageDetail<TKey>
### Properties

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.FormPageId'></a>

## FormPageDetail<TKey>.FormPageId Property

Gets or sets the id for the form page associated with this form page detail.

```csharp
public TKey FormPageId { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail<TKey>.TKey')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.FormQuestionId'></a>

## FormPageDetail<TKey>.FormQuestionId Property

Gets or sets the id for the form question associated with this form page detail.

```csharp
public TKey FormQuestionId { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail<TKey>.TKey')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.Id'></a>

## FormPageDetail<TKey>.Id Property

Gets or sets the primary key for this form page detail.

```csharp
public TKey Id { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail<TKey>.TKey')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.QuestionChoiceId'></a>

## FormPageDetail<TKey>.QuestionChoiceId Property

Gets or sets the id for the question choice associated with this form page detail.

```csharp
public System.Nullable<TKey> QuestionChoiceId { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail<TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.Response'></a>

## FormPageDetail<TKey>.Response Property

Gets or sets the response for this form page detail.

```csharp
public string? Response { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')