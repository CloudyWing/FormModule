### [CloudyWing.FormModule.EntityFrameworkCore](CloudyWing.FormModule.EntityFrameworkCore.md 'CloudyWing.FormModule.EntityFrameworkCore')

## FormQuestion<TKey> Class

The form question in form module.

```csharp
public class FormQuestion<TKey>
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormQuestion_TKey_.TKey'></a>

`TKey`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormQuestion<TKey>
### Properties

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormQuestion_TKey_.DisplayOrder'></a>

## FormQuestion<TKey>.DisplayOrder Property

Gets or sets the display order for this question.

```csharp
public int DisplayOrder { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormQuestion_TKey_.FormSectionId'></a>

## FormQuestion<TKey>.FormSectionId Property

Gets or sets the primary key for the form section to which this question belongs.

```csharp
public TKey FormSectionId { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormQuestion_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormQuestion_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>.TKey')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormQuestion_TKey_.Id'></a>

## FormQuestion<TKey>.Id Property

Gets or sets the primary key for this form question.

```csharp
public TKey Id { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormQuestion_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormQuestion_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>.TKey')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormQuestion_TKey_.IsRequired'></a>

## FormQuestion<TKey>.IsRequired Property

Gets or sets a value indicating whether this question is required to be answered.

```csharp
public bool IsRequired { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormQuestion_TKey_.QuestionText'></a>

## FormQuestion<TKey>.QuestionText Property

Gets or sets the text for this question.

```csharp
public string? QuestionText { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormQuestion_TKey_.QuestionType'></a>

## FormQuestion<TKey>.QuestionType Property

Gets or sets the type of this question.

```csharp
public CloudyWing.FormModule.EntityFrameworkCore.QuestionType? QuestionType { get; set; }
```

#### Property Value
[QuestionType](CloudyWing.FormModule.EntityFrameworkCore.QuestionType.md 'CloudyWing.FormModule.EntityFrameworkCore.QuestionType')