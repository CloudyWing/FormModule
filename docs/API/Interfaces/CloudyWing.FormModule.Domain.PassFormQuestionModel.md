#### [CloudyWing.FormModule.Domain](index.md 'index')

## CloudyWing.FormModule.Domain.PassFormQuestionModel Namespace
### Classes

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput'></a>

## IsExistsInput Class

Represents the input parameters for checking if a pass form question exists.

```csharp
public class IsExistsInput
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IsExistsInput
### Properties

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput.FormQuestionId'></a>

## IsExistsInput.FormQuestionId Property

Gets or sets the ID of the form question.

```csharp
public string FormQuestionId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput.Id'></a>

## IsExistsInput.Id Property

Gets or sets the ID of the pass form question (optional).

```csharp
public string? Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput.PassQuestionId'></a>

## IsExistsInput.PassQuestionId Property

Gets or sets the pass question identifier.

```csharp
public string PassQuestionId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput.QuestionChoiceId'></a>

## IsExistsInput.QuestionChoiceId Property

Gets or sets the question choice identifier.

```csharp
public string? QuestionChoiceId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionEditor'></a>

## PassFormQuestionEditor Class

Represents a pass form question editor.

```csharp
public class PassFormQuestionEditor : CloudyWing.FormModule.Domain.EditorBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase') &#129106; PassFormQuestionEditor

### See Also
- [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase')
### Properties

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionEditor.ExecutedBy'></a>

## PassFormQuestionEditor.ExecutedBy Property

Gets or sets the executed by.

```csharp
public string ExecutedBy { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionEditor.FormQuestionId'></a>

## PassFormQuestionEditor.FormQuestionId Property

Gets or sets the form question identifier.

```csharp
public string FormQuestionId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionEditor.PassQuestionId'></a>

## PassFormQuestionEditor.PassQuestionId Property

Gets or sets the pass question identifier.

```csharp
public string PassQuestionId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionEditor.QuestionChoiceId'></a>

## PassFormQuestionEditor.QuestionChoiceId Property

Gets or sets the question choice identifier.

```csharp
public string? QuestionChoiceId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_'></a>

## PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey> Class

Represents a query entity for pass form question.

```csharp
public class PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>
    where TPassFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.PassFormQuestion<TKey>, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TFormSection : CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>, new()
    where TFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>, new()
    where TQuestionChoice : CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TPassFormQuestion'></a>

`TPassFormQuestion`

The type of the pass form question.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormSection'></a>

`TFormSection`

The type of the form section.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestion'></a>

`TFormQuestion`

The type of the form question.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TQuestionChoice'></a>

`TQuestionChoice`

The type of the question choice.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>
### Properties

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.Choice'></a>

## PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.Choice Property

Gets or sets the choice.

```csharp
public TQuestionChoice? Choice { get; set; }
```

#### Property Value
[TQuestionChoice](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TQuestionChoice 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TQuestionChoice')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.Form'></a>

## PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.Form Property

Gets or sets the form.

```csharp
public TForm Form { get; set; }
```

#### Property Value
[TForm](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TForm 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TForm')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.Pass'></a>

## PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.Pass Property

Gets or sets the pass.

```csharp
public TPassFormQuestion Pass { get; set; }
```

#### Property Value
[TPassFormQuestion](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TPassFormQuestion 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TPassFormQuestion')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.PassQuestion'></a>

## PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.PassQuestion Property

Gets or sets the pass question.

```csharp
public TFormQuestion PassQuestion { get; set; }
```

#### Property Value
[TFormQuestion](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestion 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormQuestion')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.Question'></a>

## PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.Question Property

Gets or sets the question.

```csharp
public TFormQuestion Question { get; set; }
```

#### Property Value
[TFormQuestion](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestion 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormQuestion')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.Section'></a>

## PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.Section Property

Gets or sets the section.

```csharp
public TFormSection Section { get; set; }
```

#### Property Value
[TFormSection](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity_TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormSection 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity<TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormSection')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_'></a>

## PassFormQuestionQueryService<TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey> Class

Represents a service for querying form pass form question.

```csharp
public class PassFormQuestionQueryService<TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey> : CloudyWing.FormModule.Domain.DomainService<TDbContext>,
CloudyWing.FormModule.Domain.IQueryableService<TPassFormQuestionQueryEntity>
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TPassFormQuestionQueryEntity : CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryEntity<TPassFormQuestion, TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
    where TPassFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.PassFormQuestion<TKey>, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TFormSection : CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>, new()
    where TFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>, new()
    where TQuestionChoice : CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TPassFormQuestionQueryEntity'></a>

`TPassFormQuestionQueryEntity`

The type of the pass form question query entity.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TPassFormQuestion'></a>

`TPassFormQuestion`

The type of the pass form question.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormSection'></a>

`TFormSection`

The type of the form section.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestion'></a>

`TFormQuestion`

The type of the form question.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TQuestionChoice'></a>

`TQuestionChoice`

The type of the question choice.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>')[TDbContext](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TDbContext 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService<TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TDbContext')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>') &#129106; PassFormQuestionQueryService<TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>

Implements [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_ 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TPassFormQuestionQueryEntity](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TPassFormQuestionQueryEntity 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService<TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TPassFormQuestionQueryEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_ 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Constructors

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.PassFormQuestionQueryService(TDbContext,System.IServiceProvider)'></a>

## PassFormQuestionQueryService(TDbContext, IServiceProvider) Constructor

Initializes a new instance of the [PassFormQuestionQueryService&lt;TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey&gt;](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_ 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService<TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>') class.

```csharp
public PassFormQuestionQueryService(TDbContext? dbContext, System.IServiceProvider? serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.PassFormQuestionQueryService(TDbContext,System.IServiceProvider).dbContext'></a>

`dbContext` [TDbContext](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TDbContext 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService<TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TDbContext')

The database context.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.PassFormQuestionQueryService(TDbContext,System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.
### Properties

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.DataSource'></a>

## PassFormQuestionQueryService<TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.DataSource Property

Gets the data source for querying pass form question query entities.

```csharp
public virtual System.Linq.IQueryable<TPassFormQuestionQueryEntity> DataSource { get; }
```

Implements [DataSource](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_.DataSource 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>.DataSource')

#### Property Value
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TPassFormQuestionQueryEntity](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService_TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TPassFormQuestionQueryEntity 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionQueryService<TDbContext,TPassFormQuestionQueryEntity,TPassFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TPassFormQuestionQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_'></a>

## PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey> Class

Implementation of the pass form question service.

```csharp
public class PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey> : CloudyWing.FormModule.Domain.DomainService<TDbContext, TKey, TUserKey>,
CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService<TPassFormQuestionEditor, TPassFormQuestion, TKey>,
CloudyWing.FormModule.Domain.IQueryableService<TPassFormQuestion>
    where TPassFormQuestionEditor : CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionEditor, new()
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TPassFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.PassFormQuestion<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
    where TUserKey : System.IEquatable<TUserKey>
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TPassFormQuestionEditor'></a>

`TPassFormQuestionEditor`

The type of the pass form question editor.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TPassFormQuestion'></a>

`TPassFormQuestion`

The type of the pass form question.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TKey'></a>

`TKey`

The type of the key.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TUserKey'></a>

`TUserKey`

The type of the user key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>')[TDbContext](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TDbContext 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.TDbContext')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>')[TDbContext](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TDbContext 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.TDbContext')[,](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>')[TKey](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TKey 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.TKey')[,](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>')[TUserKey](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TUserKey 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.TUserKey')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>') &#129106; PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>

Implements [CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService&lt;](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_ 'CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>')[TPassFormQuestionEditor](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TPassFormQuestionEditor 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.TPassFormQuestionEditor')[,](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_ 'CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>')[TPassFormQuestion](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TPassFormQuestion 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.TPassFormQuestion')[,](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_ 'CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>')[TKey](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TKey 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.TKey')[&gt;](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_ 'CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>'), [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_ 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TPassFormQuestion](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TPassFormQuestion 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.TPassFormQuestion')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_ 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Constructors

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.PassFormQuestionService(TDbContext,System.IServiceProvider)'></a>

## PassFormQuestionService(TDbContext, IServiceProvider) Constructor

Initializes a new instance of the [PassFormQuestionService&lt;TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>') class.

```csharp
public PassFormQuestionService(TDbContext? dbContext, System.IServiceProvider? serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.PassFormQuestionService(TDbContext,System.IServiceProvider).dbContext'></a>

`dbContext` [TDbContext](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TDbContext 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.TDbContext')

The database context.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.PassFormQuestionService(TDbContext,System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.
### Properties

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.DataSource'></a>

## PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.DataSource Property

Gets the data source for querying pass form question query entities.

```csharp
public System.Linq.IQueryable<TPassFormQuestion> DataSource { get; }
```

Implements [DataSource](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_.DataSource 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>.DataSource')

#### Property Value
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TPassFormQuestion](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TPassFormQuestion 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.TPassFormQuestion')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.PassFormQuestions'></a>

## PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.PassFormQuestions Property

Gets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of pass form questions.

```csharp
protected Microsoft.EntityFrameworkCore.DbSet<TPassFormQuestion> PassFormQuestions { get; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TPassFormQuestion](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TPassFormQuestion 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.TPassFormQuestion')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')
### Methods

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.CreateAsync(TPassFormQuestionEditor)'></a>

## PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.CreateAsync(TPassFormQuestionEditor) Method

Creates a new pass form question.

```csharp
public virtual System.Threading.Tasks.Task<bool> CreateAsync(TPassFormQuestionEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.CreateAsync(TPassFormQuestionEditor).editor'></a>

`editor` [TPassFormQuestionEditor](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TPassFormQuestionEditor 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.TPassFormQuestionEditor')

The pass form question editor.

Implements [CreateAsync(TPassFormQuestionEditor)](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.CreateAsync(TPassFormQuestionEditor) 'CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>.CreateAsync(TPassFormQuestionEditor)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the pass form question is created successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.DeleteAsync(string)'></a>

## PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.DeleteAsync(string) Method

Deletes a pass form question.

```csharp
public virtual System.Threading.Tasks.Task<bool> DeleteAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.DeleteAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the pass form question.

Implements [DeleteAsync(string)](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.DeleteAsync(string) 'CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>.DeleteAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the pass form question is deleted successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.IsExistsAsync(CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput)'></a>

## PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.IsExistsAsync(IsExistsInput) Method

Checks if a pass form question exists.

```csharp
public virtual System.Threading.Tasks.Task<bool> IsExistsAsync(CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput input);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.IsExistsAsync(CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput).input'></a>

`input` [IsExistsInput](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput 'CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput')

The input parameters.

Implements [IsExistsAsync(IsExistsInput)](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.IsExistsAsync(CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput) 'CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>.IsExistsAsync(CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the pass form question exists; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.UpdateAsync(TPassFormQuestionEditor)'></a>

## PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.UpdateAsync(TPassFormQuestionEditor) Method

Updates an existing pass form question.

```csharp
public virtual System.Threading.Tasks.Task<bool> UpdateAsync(TPassFormQuestionEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.UpdateAsync(TPassFormQuestionEditor).editor'></a>

`editor` [TPassFormQuestionEditor](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_.TPassFormQuestionEditor 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>.TPassFormQuestionEditor')

The pass form question editor.

Implements [UpdateAsync(TPassFormQuestionEditor)](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.UpdateAsync(TPassFormQuestionEditor) 'CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>.UpdateAsync(TPassFormQuestionEditor)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the pass form question is updated successfully; otherwise, `false`.
### Interfaces

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_'></a>

## IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey> Interface

Interface for the pass form question service.

```csharp
public interface IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey> :
CloudyWing.FormModule.Domain.IQueryableService<TPassFormQuestion>
    where TPassFormQuestionEditor : CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionEditor, new()
    where TPassFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.PassFormQuestion<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.TPassFormQuestionEditor'></a>

`TPassFormQuestionEditor`

The type of the pass form question editor.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.TPassFormQuestion'></a>

`TPassFormQuestion`

The type of the pass form question.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.TKey'></a>

`TKey`

The type of the key.

Derived  
&#8627; [PassFormQuestionService&lt;TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService_TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.PassFormQuestionModel.PassFormQuestionService<TPassFormQuestionEditor,TDbContext,TPassFormQuestion,TKey,TUserKey>')

Implements [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_ 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TPassFormQuestion](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.TPassFormQuestion 'CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>.TPassFormQuestion')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_ 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Methods

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.CreateAsync(TPassFormQuestionEditor)'></a>

## IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>.CreateAsync(TPassFormQuestionEditor) Method

Creates a new pass form question.

```csharp
System.Threading.Tasks.Task<bool> CreateAsync(TPassFormQuestionEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.CreateAsync(TPassFormQuestionEditor).editor'></a>

`editor` [TPassFormQuestionEditor](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.TPassFormQuestionEditor 'CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>.TPassFormQuestionEditor')

The pass form question editor.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the pass form question is created successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.DeleteAsync(string)'></a>

## IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>.DeleteAsync(string) Method

Deletes a pass form question.

```csharp
System.Threading.Tasks.Task<bool> DeleteAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.DeleteAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the pass form question.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the pass form question is deleted successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.IsExistsAsync(CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput)'></a>

## IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>.IsExistsAsync(IsExistsInput) Method

Checks if a pass form question exists.

```csharp
System.Threading.Tasks.Task<bool> IsExistsAsync(CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput input);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.IsExistsAsync(CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput).input'></a>

`input` [IsExistsInput](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput 'CloudyWing.FormModule.Domain.PassFormQuestionModel.IsExistsInput')

The input parameters.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the pass form question exists; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.UpdateAsync(TPassFormQuestionEditor)'></a>

## IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>.UpdateAsync(TPassFormQuestionEditor) Method

Updates an existing pass form question.

```csharp
System.Threading.Tasks.Task<bool> UpdateAsync(TPassFormQuestionEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.UpdateAsync(TPassFormQuestionEditor).editor'></a>

`editor` [TPassFormQuestionEditor](CloudyWing.FormModule.Domain.PassFormQuestionModel.md#CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService_TPassFormQuestionEditor,TPassFormQuestion,TKey_.TPassFormQuestionEditor 'CloudyWing.FormModule.Domain.PassFormQuestionModel.IPassFormQuestionService<TPassFormQuestionEditor,TPassFormQuestion,TKey>.TPassFormQuestionEditor')

The pass form question editor.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the pass form question is updated successfully; otherwise, `false`.