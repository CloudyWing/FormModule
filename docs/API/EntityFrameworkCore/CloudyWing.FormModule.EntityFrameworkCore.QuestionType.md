### [CloudyWing.FormModule.EntityFrameworkCore](CloudyWing.FormModule.EntityFrameworkCore.md 'CloudyWing.FormModule.EntityFrameworkCore')

## QuestionType Class

Represents a question type.

```csharp
public class QuestionType : CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<CloudyWing.FormModule.EntityFrameworkCore.QuestionType, short>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase&lt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[QuestionType](CloudyWing.FormModule.EntityFrameworkCore.QuestionType.md 'CloudyWing.FormModule.EntityFrameworkCore.QuestionType')[,](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>')[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase_TEnum,TValue_.md 'CloudyWing.FormModule.EntityFrameworkCore.EnumerationBase<TEnum,TValue>') &#129106; QuestionType
### Constructors

<a name='CloudyWing.FormModule.EntityFrameworkCore.QuestionType.QuestionType(short,string)'></a>

## QuestionType(short, string) Constructor

Initializes a new instance of the [QuestionType](CloudyWing.FormModule.EntityFrameworkCore.QuestionType.md 'CloudyWing.FormModule.EntityFrameworkCore.QuestionType') class with the specified value and name.

```csharp
protected QuestionType(short value, string? name);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.QuestionType.QuestionType(short,string).value'></a>

`value` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The value of the question type.

<a name='CloudyWing.FormModule.EntityFrameworkCore.QuestionType.QuestionType(short,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the question type.
### Properties

<a name='CloudyWing.FormModule.EntityFrameworkCore.QuestionType.DropDownList'></a>

## QuestionType.DropDownList Property

Gets the question type for drop-down list(2).

```csharp
public static CloudyWing.FormModule.EntityFrameworkCore.QuestionType DropDownList { get; }
```

#### Property Value
[QuestionType](CloudyWing.FormModule.EntityFrameworkCore.QuestionType.md 'CloudyWing.FormModule.EntityFrameworkCore.QuestionType')

<a name='CloudyWing.FormModule.EntityFrameworkCore.QuestionType.LongAnswer'></a>

## QuestionType.LongAnswer Property

Gets the question type for long answer(4).

```csharp
public static CloudyWing.FormModule.EntityFrameworkCore.QuestionType LongAnswer { get; }
```

#### Property Value
[QuestionType](CloudyWing.FormModule.EntityFrameworkCore.QuestionType.md 'CloudyWing.FormModule.EntityFrameworkCore.QuestionType')

<a name='CloudyWing.FormModule.EntityFrameworkCore.QuestionType.MultiChoice'></a>

## QuestionType.MultiChoice Property

Gets the question type for multiple choice(0).

```csharp
public static CloudyWing.FormModule.EntityFrameworkCore.QuestionType MultiChoice { get; }
```

#### Property Value
[QuestionType](CloudyWing.FormModule.EntityFrameworkCore.QuestionType.md 'CloudyWing.FormModule.EntityFrameworkCore.QuestionType')

<a name='CloudyWing.FormModule.EntityFrameworkCore.QuestionType.MultiSelection'></a>

## QuestionType.MultiSelection Property

Gets the question type for multiple selection(1).

```csharp
public static CloudyWing.FormModule.EntityFrameworkCore.QuestionType MultiSelection { get; }
```

#### Property Value
[QuestionType](CloudyWing.FormModule.EntityFrameworkCore.QuestionType.md 'CloudyWing.FormModule.EntityFrameworkCore.QuestionType')

<a name='CloudyWing.FormModule.EntityFrameworkCore.QuestionType.ShortAnswer'></a>

## QuestionType.ShortAnswer Property

Gets the question type for short answer(3).

```csharp
public static CloudyWing.FormModule.EntityFrameworkCore.QuestionType ShortAnswer { get; }
```

#### Property Value
[QuestionType](CloudyWing.FormModule.EntityFrameworkCore.QuestionType.md 'CloudyWing.FormModule.EntityFrameworkCore.QuestionType')