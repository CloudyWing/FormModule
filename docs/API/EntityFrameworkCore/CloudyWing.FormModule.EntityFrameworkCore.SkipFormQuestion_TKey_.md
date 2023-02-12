### [CloudyWing.FormModule.EntityFrameworkCore](CloudyWing.FormModule.EntityFrameworkCore.md 'CloudyWing.FormModule.EntityFrameworkCore')

## SkipFormQuestion<TKey> Class

The skip form question in form module.

```csharp
public class SkipFormQuestion<TKey>
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.TKey'></a>

`TKey`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SkipFormQuestion<TKey>
### Properties

<a name='CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.FormQuestionId'></a>

## SkipFormQuestion<TKey>.FormQuestionId Property

Gets or sets the form question identifier for this skip form question.

```csharp
public TKey FormQuestionId { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion<TKey>.TKey')

<a name='CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.Id'></a>

## SkipFormQuestion<TKey>.Id Property

Gets or sets the primary key for this skip form question.

```csharp
public TKey Id { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion<TKey>.TKey')

<a name='CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.QuestionChoiceId'></a>

## SkipFormQuestion<TKey>.QuestionChoiceId Property

Gets or sets the question choice identifier for this skip form question.

```csharp
public System.Nullable<TKey> QuestionChoiceId { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TKey](CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion<TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.SkipQuestionId'></a>

## SkipFormQuestion<TKey>.SkipQuestionId Property

Gets or sets the skip question identifier for this skip form question.

```csharp
public TKey SkipQuestionId { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion<TKey>.TKey')