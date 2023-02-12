### [CloudyWing.FormModule.EntityFrameworkCore](CloudyWing.FormModule.EntityFrameworkCore.md 'CloudyWing.FormModule.EntityFrameworkCore')

## QuestionChoice<TKey> Class

The question choice in form module.

```csharp
public class QuestionChoice<TKey>
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice_TKey_.TKey'></a>

`TKey`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; QuestionChoice<TKey>
### Properties

<a name='CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice_TKey_.DisplayOrder'></a>

## QuestionChoice<TKey>.DisplayOrder Property

Gets or sets the display order for this question choice.

```csharp
public int DisplayOrder { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice_TKey_.FormQuestionId'></a>

## QuestionChoice<TKey>.FormQuestionId Property

Gets or sets the question identifier for this question choice.

```csharp
public TKey FormQuestionId { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>.TKey')

<a name='CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice_TKey_.HasText'></a>

## QuestionChoice<TKey>.HasText Property

Gets or sets a value indicating whether this question choice has a text field for the response.

```csharp
public bool HasText { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice_TKey_.Id'></a>

## QuestionChoice<TKey>.Id Property

Gets or sets the primary key for this question choice.

```csharp
public TKey Id { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>.TKey')

<a name='CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice_TKey_.Label'></a>

## QuestionChoice<TKey>.Label Property

Gets or sets the label for this question choice.

```csharp
public string? Label { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')