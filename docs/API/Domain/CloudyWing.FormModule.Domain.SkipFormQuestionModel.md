#### [CloudyWing.FormModule.Domain](index.md 'index')

## CloudyWing.FormModule.Domain.SkipFormQuestionModel Namespace
### Classes

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput'></a>

## IsExistsInput Class

Represents the input parameters for checking if a skip form question exists.

```csharp
public class IsExistsInput
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IsExistsInput
### Properties

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput.FormQuestionId'></a>

## IsExistsInput.FormQuestionId Property

Gets or sets the ID of the form question.

```csharp
public string FormQuestionId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput.Id'></a>

## IsExistsInput.Id Property

Gets or sets the ID of the skip form question (optional).

```csharp
public string? Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput.QuestionChoiceId'></a>

## IsExistsInput.QuestionChoiceId Property

Gets or sets the question choice identifier.

```csharp
public string? QuestionChoiceId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput.SkipQuestionId'></a>

## IsExistsInput.SkipQuestionId Property

Gets or sets the skip question identifier.

```csharp
public string SkipQuestionId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionEditor'></a>

## SkipFormQuestionEditor Class

Represents a skip form question editor.

```csharp
public class SkipFormQuestionEditor : CloudyWing.FormModule.Domain.EditorBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase') &#129106; SkipFormQuestionEditor

### See Also
- [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase')
### Properties

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionEditor.ExecutedBy'></a>

## SkipFormQuestionEditor.ExecutedBy Property

Gets or sets the executed by.

```csharp
public string ExecutedBy { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionEditor.FormQuestionId'></a>

## SkipFormQuestionEditor.FormQuestionId Property

Gets or sets the form question identifier.

```csharp
public string FormQuestionId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionEditor.QuestionChoiceId'></a>

## SkipFormQuestionEditor.QuestionChoiceId Property

Gets or sets the question choice identifier.

```csharp
public string? QuestionChoiceId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionEditor.SkipQuestionId'></a>

## SkipFormQuestionEditor.SkipQuestionId Property

Gets or sets the skip question identifier.

```csharp
public string SkipQuestionId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Methods

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionEditor.ThrowIfInvalidAtCreate()'></a>

## SkipFormQuestionEditor.ThrowIfInvalidAtCreate() Method

Throws if invalid at create.

```csharp
public virtual void ThrowIfInvalidAtCreate();
```

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionEditor.ThrowIfInvalidAtUpdate()'></a>

## SkipFormQuestionEditor.ThrowIfInvalidAtUpdate() Method

Throws if invalid at update.

```csharp
public virtual void ThrowIfInvalidAtUpdate();
```

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_'></a>

## SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey> Class

Represents a query entity for skip form question.

```csharp
public class SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>
    where TSkipFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion<TKey>, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TFormSection : CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>, new()
    where TFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>, new()
    where TQuestionChoice : CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TSkipFormQuestion'></a>

`TSkipFormQuestion`

The type of the skip form question.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormSection'></a>

`TFormSection`

The type of the form section.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestion'></a>

`TFormQuestion`

The type of the form question.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TQuestionChoice'></a>

`TQuestionChoice`

The type of the question choice.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>
### Properties

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.Choice'></a>

## SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.Choice Property

Gets or sets the choice.

```csharp
public TQuestionChoice? Choice { get; set; }
```

#### Property Value
[TQuestionChoice](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TQuestionChoice 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TQuestionChoice')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.Form'></a>

## SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.Form Property

Gets or sets the form.

```csharp
public TForm Form { get; set; }
```

#### Property Value
[TForm](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TForm 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TForm')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.Question'></a>

## SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.Question Property

Gets or sets the question.

```csharp
public TFormQuestion Question { get; set; }
```

#### Property Value
[TFormQuestion](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestion 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormQuestion')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.Section'></a>

## SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.Section Property

Gets or sets the section.

```csharp
public TFormSection Section { get; set; }
```

#### Property Value
[TFormSection](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormSection 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormSection')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.Skip'></a>

## SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.Skip Property

Gets or sets the skip.

```csharp
public TSkipFormQuestion Skip { get; set; }
```

#### Property Value
[TSkipFormQuestion](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TSkipFormQuestion 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TSkipFormQuestion')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.SkipQuestion'></a>

## SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.SkipQuestion Property

Gets or sets the skip question.

```csharp
public TFormQuestion SkipQuestion { get; set; }
```

#### Property Value
[TFormQuestion](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity_TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestion 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity<TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormQuestion')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_'></a>

## SkipFormQuestionQueryService<TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey> Class

Represents a service for querying form skip form question.

```csharp
public class SkipFormQuestionQueryService<TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey> : CloudyWing.FormModule.Domain.DomainService<TDbContext>,
CloudyWing.FormModule.Domain.IQueryableService<TSkipFormQuestionQueryEntity>
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TSkipFormQuestionQueryEntity : CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity<TSkipFormQuestion, TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
    where TSkipFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion<TKey>, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TFormSection : CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>, new()
    where TFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>, new()
    where TQuestionChoice : CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TSkipFormQuestionQueryEntity'></a>

`TSkipFormQuestionQueryEntity`

The type of the skip form question query entity.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TSkipFormQuestion'></a>

`TSkipFormQuestion`

The type of the skip form question.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormSection'></a>

`TFormSection`

The type of the form section.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestion'></a>

`TFormQuestion`

The type of the form question.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TQuestionChoice'></a>

`TQuestionChoice`

The type of the question choice.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>')[TDbContext](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TDbContext 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService<TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TDbContext')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>') &#129106; SkipFormQuestionQueryService<TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>

Implements [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TSkipFormQuestionQueryEntity](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TSkipFormQuestionQueryEntity 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService<TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TSkipFormQuestionQueryEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Constructors

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.SkipFormQuestionQueryService(TDbContext,System.IServiceProvider)'></a>

## SkipFormQuestionQueryService(TDbContext, IServiceProvider) Constructor

Initializes a new instance of the [SkipFormQuestionQueryService&lt;TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey&gt;](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_ 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService<TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>') class.

```csharp
public SkipFormQuestionQueryService(TDbContext? dbContext, System.IServiceProvider? serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.SkipFormQuestionQueryService(TDbContext,System.IServiceProvider).dbContext'></a>

`dbContext` [TDbContext](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TDbContext 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService<TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TDbContext')

The database context.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.SkipFormQuestionQueryService(TDbContext,System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.
### Properties

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.DataSource'></a>

## SkipFormQuestionQueryService<TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.DataSource Property

Gets the data source for querying skip form question query entities.

```csharp
public virtual System.Linq.IQueryable<TSkipFormQuestionQueryEntity> DataSource { get; }
```

Implements [DataSource](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_.DataSource 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>.DataSource')

#### Property Value
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TSkipFormQuestionQueryEntity](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TSkipFormQuestionQueryEntity 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService<TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TSkipFormQuestionQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_'></a>

## SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey> Class

Implementation of the skip form question service.

```csharp
public class SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey> : CloudyWing.FormModule.Domain.DomainService<TDbContext, TKey, TUserKey>,
CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService<TSkipFormQuestionEditor, TSkipFormQuestion, TKey>,
CloudyWing.FormModule.Domain.IQueryableService<TSkipFormQuestion>
    where TSkipFormQuestionEditor : CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionEditor, new()
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TSkipFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
    where TUserKey : System.IEquatable<TUserKey>
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TSkipFormQuestionEditor'></a>

`TSkipFormQuestionEditor`

The type of the skip form question editor.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TSkipFormQuestion'></a>

`TSkipFormQuestion`

The type of the skip form question.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TKey'></a>

`TKey`

The type of the key.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TUserKey'></a>

`TUserKey`

The type of the user key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>')[TDbContext](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TDbContext 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.TDbContext')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>')[TDbContext](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TDbContext 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.TDbContext')[,](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>')[TKey](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TKey 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.TKey')[,](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>')[TUserKey](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TUserKey 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.TUserKey')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>') &#129106; SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>

Implements [CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService&lt;](CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.md 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>')[TSkipFormQuestionEditor](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TSkipFormQuestionEditor 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.TSkipFormQuestionEditor')[,](CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.md 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>')[TSkipFormQuestion](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TSkipFormQuestion 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.TSkipFormQuestion')[,](CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.md 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>')[TKey](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TKey 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.TKey')[&gt;](CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.md 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>'), [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TSkipFormQuestion](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TSkipFormQuestion 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.TSkipFormQuestion')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Constructors

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.SkipFormQuestionService(TDbContext,System.IServiceProvider)'></a>

## SkipFormQuestionService(TDbContext, IServiceProvider) Constructor

Initializes a new instance of the [SkipFormQuestionService&lt;TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>') class.

```csharp
public SkipFormQuestionService(TDbContext? dbContext, System.IServiceProvider? serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.SkipFormQuestionService(TDbContext,System.IServiceProvider).dbContext'></a>

`dbContext` [TDbContext](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TDbContext 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.TDbContext')

The database context.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.SkipFormQuestionService(TDbContext,System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.
### Properties

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.DataSource'></a>

## SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.DataSource Property

Gets the data source for querying skip form question query entities.

```csharp
public virtual System.Linq.IQueryable<TSkipFormQuestion> DataSource { get; }
```

Implements [DataSource](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_.DataSource 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>.DataSource')

#### Property Value
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TSkipFormQuestion](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TSkipFormQuestion 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.TSkipFormQuestion')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.SkipFormQuestions'></a>

## SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.SkipFormQuestions Property

Gets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of skip form questions.

```csharp
protected Microsoft.EntityFrameworkCore.DbSet<TSkipFormQuestion> SkipFormQuestions { get; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TSkipFormQuestion](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TSkipFormQuestion 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.TSkipFormQuestion')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')
### Methods

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.CreateAsync(TSkipFormQuestionEditor)'></a>

## SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.CreateAsync(TSkipFormQuestionEditor) Method

Creates a new skip form question.

```csharp
public virtual System.Threading.Tasks.Task<bool> CreateAsync(TSkipFormQuestionEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.CreateAsync(TSkipFormQuestionEditor).editor'></a>

`editor` [TSkipFormQuestionEditor](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TSkipFormQuestionEditor 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.TSkipFormQuestionEditor')

The skip form question editor.

Implements [CreateAsync(TSkipFormQuestionEditor)](CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.CreateAsync(TSkipFormQuestionEditor) 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>.CreateAsync(TSkipFormQuestionEditor)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the skip form question is created successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.DeleteAsync(string)'></a>

## SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.DeleteAsync(string) Method

Deletes a skip form question.

```csharp
public virtual System.Threading.Tasks.Task<bool> DeleteAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.DeleteAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the skip form question.

Implements [DeleteAsync(string)](CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.DeleteAsync(string) 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>.DeleteAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the skip form question is deleted successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.IsExistsAsync(CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput)'></a>

## SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.IsExistsAsync(IsExistsInput) Method

Checks if a skip form question exists.

```csharp
public virtual System.Threading.Tasks.Task<bool> IsExistsAsync(CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput input);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.IsExistsAsync(CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput).input'></a>

`input` [IsExistsInput](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput')

The input parameters.

Implements [IsExistsAsync(IsExistsInput)](CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.IsExistsAsync(CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput) 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>.IsExistsAsync(CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the skip form question exists; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.UpdateAsync(TSkipFormQuestionEditor)'></a>

## SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.UpdateAsync(TSkipFormQuestionEditor) Method

Updates an existing skip form question.

```csharp
public virtual System.Threading.Tasks.Task<bool> UpdateAsync(TSkipFormQuestionEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.UpdateAsync(TSkipFormQuestionEditor).editor'></a>

`editor` [TSkipFormQuestionEditor](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_.TSkipFormQuestionEditor 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>.TSkipFormQuestionEditor')

The skip form question editor.

Implements [UpdateAsync(TSkipFormQuestionEditor)](CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.UpdateAsync(TSkipFormQuestionEditor) 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>.UpdateAsync(TSkipFormQuestionEditor)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the skip form question is updated successfully; otherwise, `false`.

| Interfaces | |
| :--- | :--- |
| [ISkipFormQuestionService&lt;TSkipFormQuestionEditor,TSkipFormQuestion,TKey&gt;](CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.md 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>') | Interface for the skip form question service. |
