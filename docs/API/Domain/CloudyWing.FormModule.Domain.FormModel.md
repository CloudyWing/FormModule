#### [CloudyWing.FormModule.Domain](index.md 'index')

## CloudyWing.FormModule.Domain.FormModel Namespace
### Classes

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailEditor_TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor_'></a>

## FormDetailEditor<TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor> Class

Represents a form detail editor.

```csharp
public class FormDetailEditor<TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor>
    where TFormSectionEditor : CloudyWing.FormModule.Domain.FormModel.FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor>
    where TFormQuestionEditor : CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor<TQuestionChoiceEditor>
    where TQuestionChoiceEditor : CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailEditor_TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor_.TFormSectionEditor'></a>

`TFormSectionEditor`

The type of the form section editor.

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailEditor_TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor_.TFormQuestionEditor'></a>

`TFormQuestionEditor`

The type of the form question editor.

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailEditor_TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor_.TQuestionChoiceEditor'></a>

`TQuestionChoiceEditor`

The type of the question choice editor.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormDetailEditor<TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor>
### Properties

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailEditor_TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor_.ExecutedBy'></a>

## FormDetailEditor<TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor>.ExecutedBy Property

Gets or sets the primary key of the user who exected the form.

```csharp
public string ExecutedBy { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailEditor_TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor_.FormId'></a>

## FormDetailEditor<TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor>.FormId Property

Gets or sets the primary key of the form that this form page belongs to.

```csharp
public string FormId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailEditor_TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor_.FormSections'></a>

## FormDetailEditor<TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor>.FormSections Property

Gets the form sections.

```csharp
public System.Collections.Generic.IList<TFormSectionEditor> FormSections { get; }
```

#### Property Value
[System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[TFormSectionEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormDetailEditor_TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor_.TFormSectionEditor 'CloudyWing.FormModule.Domain.FormModel.FormDetailEditor<TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor>.TFormSectionEditor')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')
### Methods

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailEditor_TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor_.ThrowIfInvalid()'></a>

## FormDetailEditor<TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor>.ThrowIfInvalid() Method

Throws if invalid.

```csharp
public virtual void ThrowIfInvalid();
```

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity_TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_'></a>

## FormDetailQueryEntity<TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey> Class

Represents a query entity for form details.

```csharp
public class FormDetailQueryEntity<TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TFormSection : CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>, new()
    where TFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>, new()
    where TQuestionChoice : CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity_TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity_TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormSection'></a>

`TFormSection`

The type of the form section.

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity_TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestion'></a>

`TFormQuestion`

The type of the form question.

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity_TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TQuestionChoice'></a>

`TQuestionChoice`

The type of the question choice.

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity_TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TKey'></a>

`TKey`

The type of the primary key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormDetailQueryEntity<TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>
### Properties

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity_TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.Choice'></a>

## FormDetailQueryEntity<TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.Choice Property

Gets or sets the choice.

```csharp
public TQuestionChoice? Choice { get; set; }
```

#### Property Value
[TQuestionChoice](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity_TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TQuestionChoice 'CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity<TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TQuestionChoice')

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity_TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.Form'></a>

## FormDetailQueryEntity<TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.Form Property

Gets or sets the form.

```csharp
public TForm Form { get; set; }
```

#### Property Value
[TForm](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity_TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TForm 'CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity<TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TForm')

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity_TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.Question'></a>

## FormDetailQueryEntity<TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.Question Property

Gets or sets the question.

```csharp
public TFormQuestion Question { get; set; }
```

#### Property Value
[TFormQuestion](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity_TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestion 'CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity<TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormQuestion')

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity_TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.Section'></a>

## FormDetailQueryEntity<TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.Section Property

Gets or sets the section.

```csharp
public TFormSection Section { get; set; }
```

#### Property Value
[TFormSection](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity_TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormSection 'CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity<TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormSection')

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_'></a>

## FormDetailQueryService<TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey> Class

Represents a service for querying form details.

```csharp
public class FormDetailQueryService<TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey> : CloudyWing.FormModule.Domain.DomainService<TDbContext>,
CloudyWing.FormModule.Domain.IQueryableService<TFormDetailQueryEntity>
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TFormDetailQueryEntity : CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity<TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TFormSection : CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>, new()
    where TFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>, new()
    where TQuestionChoice : CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormDetailQueryEntity'></a>

`TFormDetailQueryEntity`

The type of the form detail query entity.

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormSection'></a>

`TFormSection`

The type of the form section.

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestion'></a>

`TFormQuestion`

The type of the form question.

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TQuestionChoice'></a>

`TQuestionChoice`

The type of the question choice.

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TKey'></a>

`TKey`

The type of the primary key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>')[TDbContext](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TDbContext 'CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService<TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TDbContext')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>') &#129106; FormDetailQueryService<TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>

Implements [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TFormDetailQueryEntity](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormDetailQueryEntity 'CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService<TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormDetailQueryEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Constructors

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.FormDetailQueryService(TDbContext,System.IServiceProvider)'></a>

## FormDetailQueryService(TDbContext, IServiceProvider) Constructor

Initializes a new instance of the [FormDetailQueryService&lt;TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_ 'CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService<TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>') class.

```csharp
public FormDetailQueryService(TDbContext? dbContext, System.IServiceProvider? serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.FormDetailQueryService(TDbContext,System.IServiceProvider).dbContext'></a>

`dbContext` [TDbContext](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TDbContext 'CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService<TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TDbContext')

The database context.

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.FormDetailQueryService(TDbContext,System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.
### Properties

<a name='CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.DataSource'></a>

## FormDetailQueryService<TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.DataSource Property

Gets the data source for querying form detail query entities.

```csharp
public virtual System.Linq.IQueryable<TFormDetailQueryEntity> DataSource { get; }
```

Implements [DataSource](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_.DataSource 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>.DataSource')

#### Property Value
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TFormDetailQueryEntity](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormDetailQueryEntity 'CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService<TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormDetailQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor'></a>

## FormEditor Class

Represents a form editor.

```csharp
public class FormEditor : CloudyWing.FormModule.Domain.EditorBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase') &#129106; FormEditor

### See Also
- [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase')
### Constructors

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.FormEditor()'></a>

## FormEditor() Constructor

Initializes a new instance of the [FormEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormEditor 'CloudyWing.FormModule.Domain.FormModel.FormEditor') class.

```csharp
public FormEditor();
```

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.FormEditor(string)'></a>

## FormEditor(string) Constructor

Initializes a new instance of the [FormEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormEditor 'CloudyWing.FormModule.Domain.FormModel.FormEditor') class.

```csharp
public FormEditor(string id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.FormEditor(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The identifier.
### Properties

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.CanUpdate'></a>

## FormEditor.CanUpdate Property

Gets or sets whether can be updated after submission.

```csharp
public CloudyWing.FormModule.Domain.ValueWatcher<bool> CanUpdate { get; set; }
```

#### Property Value
[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.Code'></a>

## FormEditor.Code Property

Gets or sets the code.

```csharp
public CloudyWing.FormModule.Domain.ValueWatcher<string?> Code { get; set; }
```

#### Property Value
[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.CompletionMessage'></a>

## FormEditor.CompletionMessage Property

Gets or sets the message to be displayed upon completion.

```csharp
public CloudyWing.FormModule.Domain.ValueWatcher<string?> CompletionMessage { get; set; }
```

#### Property Value
[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.EndTime'></a>

## FormEditor.EndTime Property

Gets or sets the end time.

```csharp
public CloudyWing.FormModule.Domain.ValueWatcher<System.DateTimeOffset> EndTime { get; set; }
```

#### Property Value
[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.ExecutedBy'></a>

## FormEditor.ExecutedBy Property

Gets or sets the primary key of the user who exected the form.

```csharp
public string ExecutedBy { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.Footer'></a>

## FormEditor.Footer Property

Gets or sets the footer.

```csharp
public CloudyWing.FormModule.Domain.ValueWatcher<string?> Footer { get; set; }
```

#### Property Value
[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.Header'></a>

## FormEditor.Header Property

Gets or sets the header.

```csharp
public CloudyWing.FormModule.Domain.ValueWatcher<string?> Header { get; set; }
```

#### Property Value
[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.IsInternal'></a>

## FormEditor.IsInternal Property

Gets or sets whether this is an internal form.

```csharp
public CloudyWing.FormModule.Domain.ValueWatcher<bool> IsInternal { get; set; }
```

#### Property Value
[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.Name'></a>

## FormEditor.Name Property

Gets or sets the name.

```csharp
public CloudyWing.FormModule.Domain.ValueWatcher<string?> Name { get; set; }
```

#### Property Value
[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.Role'></a>

## FormEditor.Role Property

Gets or sets the role.

```csharp
public CloudyWing.FormModule.Domain.ValueWatcher<string?> Role { get; set; }
```

#### Property Value
[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.StartTime'></a>

## FormEditor.StartTime Property

Gets or sets the start time.

```csharp
public CloudyWing.FormModule.Domain.ValueWatcher<System.DateTimeOffset> StartTime { get; set; }
```

#### Property Value
[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')
### Methods

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.ThrowIfInvalidAtCreate()'></a>

## FormEditor.ThrowIfInvalidAtCreate() Method

Throws if invalid at create.

```csharp
public virtual void ThrowIfInvalidAtCreate();
```

<a name='CloudyWing.FormModule.Domain.FormModel.FormEditor.ThrowIfInvalidAtUpdate()'></a>

## FormEditor.ThrowIfInvalidAtUpdate() Method

Throws if invalid at update.

```csharp
public virtual void ThrowIfInvalidAtUpdate();
```

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor_TQuestionChoiceEditor_'></a>

## FormQuestionEditor<TQuestionChoiceEditor> Class

Represents a form question editor.

```csharp
public class FormQuestionEditor<TQuestionChoiceEditor> : CloudyWing.FormModule.Domain.EditorBase
    where TQuestionChoiceEditor : CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor_TQuestionChoiceEditor_.TQuestionChoiceEditor'></a>

`TQuestionChoiceEditor`

The type of the question choice editor.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase') &#129106; FormQuestionEditor<TQuestionChoiceEditor>

### See Also
- [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase')
### Constructors

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor_TQuestionChoiceEditor_.FormQuestionEditor()'></a>

## FormQuestionEditor() Constructor

Initializes a new instance of the [FormQuestionEditor&lt;TQuestionChoiceEditor&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor_TQuestionChoiceEditor_ 'CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor<TQuestionChoiceEditor>') class.

```csharp
public FormQuestionEditor();
```

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor_TQuestionChoiceEditor_.FormQuestionEditor(string)'></a>

## FormQuestionEditor(string) Constructor

Initializes a new instance of the [FormQuestionEditor&lt;TQuestionChoiceEditor&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor_TQuestionChoiceEditor_ 'CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor<TQuestionChoiceEditor>') class.

```csharp
public FormQuestionEditor(string id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor_TQuestionChoiceEditor_.FormQuestionEditor(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The identifier.
### Properties

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor_TQuestionChoiceEditor_.IsRequired'></a>

## FormQuestionEditor<TQuestionChoiceEditor>.IsRequired Property

Gets or sets a value indicating whether this question is required to be answered.

```csharp
public bool IsRequired { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor_TQuestionChoiceEditor_.QuestionChoices'></a>

## FormQuestionEditor<TQuestionChoiceEditor>.QuestionChoices Property

Gets the question choices.

```csharp
public System.Collections.Generic.IList<TQuestionChoiceEditor> QuestionChoices { get; }
```

#### Property Value
[System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[TQuestionChoiceEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor_TQuestionChoiceEditor_.TQuestionChoiceEditor 'CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor<TQuestionChoiceEditor>.TQuestionChoiceEditor')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor_TQuestionChoiceEditor_.QuestionText'></a>

## FormQuestionEditor<TQuestionChoiceEditor>.QuestionText Property

Gets or sets the text.

```csharp
public string? QuestionText { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor_TQuestionChoiceEditor_.QuestionType'></a>

## FormQuestionEditor<TQuestionChoiceEditor>.QuestionType Property

Gets or sets the type of this question.

```csharp
public CloudyWing.FormModule.EntityFrameworkCore.QuestionType? QuestionType { get; set; }
```

#### Property Value
[CloudyWing.FormModule.EntityFrameworkCore.QuestionType](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.EntityFrameworkCore.QuestionType 'CloudyWing.FormModule.EntityFrameworkCore.QuestionType')
### Methods

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor_TQuestionChoiceEditor_.ThrowIfInvalid()'></a>

## FormQuestionEditor<TQuestionChoiceEditor>.ThrowIfInvalid() Method

Throws if invalid.

```csharp
public virtual void ThrowIfInvalid();
```

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity_TFormQuestion,TFormSection,TForm,TKey_'></a>

## FormQuestionQueryEntity<TFormQuestion,TFormSection,TForm,TKey> Class

Represents a query entity for form questions.

```csharp
public class FormQuestionQueryEntity<TFormQuestion,TFormSection,TForm,TKey>
    where TFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>, new()
    where TFormSection : CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity_TFormQuestion,TFormSection,TForm,TKey_.TFormQuestion'></a>

`TFormQuestion`

The type of the form question.

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity_TFormQuestion,TFormSection,TForm,TKey_.TFormSection'></a>

`TFormSection`

The type of the form section.

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity_TFormQuestion,TFormSection,TForm,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity_TFormQuestion,TFormSection,TForm,TKey_.TKey'></a>

`TKey`

The type of the primary key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormQuestionQueryEntity<TFormQuestion,TFormSection,TForm,TKey>
### Properties

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity_TFormQuestion,TFormSection,TForm,TKey_.Form'></a>

## FormQuestionQueryEntity<TFormQuestion,TFormSection,TForm,TKey>.Form Property

Gets or sets the form.

```csharp
public TForm Form { get; set; }
```

#### Property Value
[TForm](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity_TFormQuestion,TFormSection,TForm,TKey_.TForm 'CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity<TFormQuestion,TFormSection,TForm,TKey>.TForm')

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity_TFormQuestion,TFormSection,TForm,TKey_.Question'></a>

## FormQuestionQueryEntity<TFormQuestion,TFormSection,TForm,TKey>.Question Property

Gets or sets the question.

```csharp
public TFormQuestion Question { get; set; }
```

#### Property Value
[TFormQuestion](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity_TFormQuestion,TFormSection,TForm,TKey_.TFormQuestion 'CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity<TFormQuestion,TFormSection,TForm,TKey>.TFormQuestion')

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity_TFormQuestion,TFormSection,TForm,TKey_.Section'></a>

## FormQuestionQueryEntity<TFormQuestion,TFormSection,TForm,TKey>.Section Property

Gets or sets the section.

```csharp
public TFormSection Section { get; set; }
```

#### Property Value
[TFormSection](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity_TFormQuestion,TFormSection,TForm,TKey_.TFormSection 'CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity<TFormQuestion,TFormSection,TForm,TKey>.TFormSection')

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_'></a>

## FormQuestionQueryService<TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey> Class

Represents a service for querying form questions.

```csharp
public class FormQuestionQueryService<TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey> : CloudyWing.FormModule.Domain.DomainService<TDbContext>,
CloudyWing.FormModule.Domain.IQueryableService<TFormQuestionQueryEntity>
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TFormQuestionQueryEntity : CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryEntity<TFormQuestion, TFormSection, TForm, TKey>, new()
    where TFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>, new()
    where TFormSection : CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_.TFormQuestionQueryEntity'></a>

`TFormQuestionQueryEntity`

The type of the form question query entity.

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_.TFormQuestion'></a>

`TFormQuestion`

The type of the form question.

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_.TFormSection'></a>

`TFormSection`

The type of the form section.

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_.TKey'></a>

`TKey`

The type of the primary key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>')[TDbContext](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_.TDbContext 'CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService<TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey>.TDbContext')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>') &#129106; FormQuestionQueryService<TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey>

Implements [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TFormQuestionQueryEntity](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_.TFormQuestionQueryEntity 'CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService<TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey>.TFormQuestionQueryEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Constructors

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_.FormQuestionQueryService(TDbContext,System.IServiceProvider)'></a>

## FormQuestionQueryService(TDbContext, IServiceProvider) Constructor

Initializes a new instance of the [FormQuestionQueryService&lt;TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_ 'CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService<TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey>') class.

```csharp
public FormQuestionQueryService(TDbContext? dbContext, System.IServiceProvider? serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_.FormQuestionQueryService(TDbContext,System.IServiceProvider).dbContext'></a>

`dbContext` [TDbContext](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_.TDbContext 'CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService<TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey>.TDbContext')

The database context.

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_.FormQuestionQueryService(TDbContext,System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.
### Properties

<a name='CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_.DataSource'></a>

## FormQuestionQueryService<TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey>.DataSource Property

Gets the data source for querying form question query entities.

```csharp
public virtual System.Linq.IQueryable<TFormQuestionQueryEntity> DataSource { get; }
```

Implements [DataSource](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_.DataSource 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>.DataSource')

#### Property Value
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TFormQuestionQueryEntity](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_.TFormQuestionQueryEntity 'CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService<TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey>.TFormQuestionQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')

<a name='CloudyWing.FormModule.Domain.FormModel.FormSectionEditor_TFormQuestionEditor,TQuestionChoiceEditor_'></a>

## FormSectionEditor<TFormQuestionEditor,TQuestionChoiceEditor> Class

Represents a form section editor.

```csharp
public class FormSectionEditor<TFormQuestionEditor,TQuestionChoiceEditor> : CloudyWing.FormModule.Domain.EditorBase
    where TFormQuestionEditor : CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor<TQuestionChoiceEditor>
    where TQuestionChoiceEditor : CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormSectionEditor_TFormQuestionEditor,TQuestionChoiceEditor_.TFormQuestionEditor'></a>

`TFormQuestionEditor`

The type of the form question editor.

<a name='CloudyWing.FormModule.Domain.FormModel.FormSectionEditor_TFormQuestionEditor,TQuestionChoiceEditor_.TQuestionChoiceEditor'></a>

`TQuestionChoiceEditor`

The type of the question choice editor.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase') &#129106; FormSectionEditor<TFormQuestionEditor,TQuestionChoiceEditor>

### See Also
- [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase')
### Constructors

<a name='CloudyWing.FormModule.Domain.FormModel.FormSectionEditor_TFormQuestionEditor,TQuestionChoiceEditor_.FormSectionEditor()'></a>

## FormSectionEditor() Constructor

Initializes a new instance of the [FormSectionEditor&lt;TFormQuestionEditor,TQuestionChoiceEditor&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormSectionEditor_TFormQuestionEditor,TQuestionChoiceEditor_ 'CloudyWing.FormModule.Domain.FormModel.FormSectionEditor<TFormQuestionEditor,TQuestionChoiceEditor>') class.

```csharp
public FormSectionEditor();
```

<a name='CloudyWing.FormModule.Domain.FormModel.FormSectionEditor_TFormQuestionEditor,TQuestionChoiceEditor_.FormSectionEditor(string)'></a>

## FormSectionEditor(string) Constructor

Initializes a new instance of the [FormSectionEditor&lt;TFormQuestionEditor,TQuestionChoiceEditor&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormSectionEditor_TFormQuestionEditor,TQuestionChoiceEditor_ 'CloudyWing.FormModule.Domain.FormModel.FormSectionEditor<TFormQuestionEditor,TQuestionChoiceEditor>') class.

```csharp
public FormSectionEditor(string id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormSectionEditor_TFormQuestionEditor,TQuestionChoiceEditor_.FormSectionEditor(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The identifier.
### Properties

<a name='CloudyWing.FormModule.Domain.FormModel.FormSectionEditor_TFormQuestionEditor,TQuestionChoiceEditor_.FormQuestions'></a>

## FormSectionEditor<TFormQuestionEditor,TQuestionChoiceEditor>.FormQuestions Property

Gets the form questions

```csharp
public System.Collections.Generic.IList<TFormQuestionEditor> FormQuestions { get; }
```

#### Property Value
[System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[TFormQuestionEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormSectionEditor_TFormQuestionEditor,TQuestionChoiceEditor_.TFormQuestionEditor 'CloudyWing.FormModule.Domain.FormModel.FormSectionEditor<TFormQuestionEditor,TQuestionChoiceEditor>.TFormQuestionEditor')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')

<a name='CloudyWing.FormModule.Domain.FormModel.FormSectionEditor_TFormQuestionEditor,TQuestionChoiceEditor_.Name'></a>

## FormSectionEditor<TFormQuestionEditor,TQuestionChoiceEditor>.Name Property

Gets or sets the name.

```csharp
public string? Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Methods

<a name='CloudyWing.FormModule.Domain.FormModel.FormSectionEditor_TFormQuestionEditor,TQuestionChoiceEditor_.ThrowIfInvalid()'></a>

## FormSectionEditor<TFormQuestionEditor,TQuestionChoiceEditor>.ThrowIfInvalid() Method

Throws if invalid.

```csharp
public virtual void ThrowIfInvalid();
```

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey> Class

Implementation of the form service.

```csharp
public class FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey> : CloudyWing.FormModule.Domain.DomainService<TDbContext, TKey, TUserKey>,
CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, TForm, TKey>,
CloudyWing.FormModule.Domain.IQueryableService<TForm>
    where TFormEditor : CloudyWing.FormModule.Domain.FormModel.FormEditor, new()
    where TFormDetailEditor : CloudyWing.FormModule.Domain.FormModel.FormDetailEditor<TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>, new()
    where TFormSectionEditor : CloudyWing.FormModule.Domain.FormModel.FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor>, new()
    where TFormQuestionEditor : CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor<TQuestionChoiceEditor>, new()
    where TQuestionChoiceEditor : CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor, new()
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TFormSection : CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>, new()
    where TFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>, new()
    where TQuestionChoice : CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>, new()
    where TSkipFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion<TKey>, new()
    where TFormPage : CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
    where TUserKey : System.IEquatable<TUserKey>
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormEditor'></a>

`TFormEditor`

The type of the form editor.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormDetailEditor'></a>

`TFormDetailEditor`

The type of the form detail editor.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormSectionEditor'></a>

`TFormSectionEditor`

The type of the form section editor.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormQuestionEditor'></a>

`TFormQuestionEditor`

The type of the form question editor.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TQuestionChoiceEditor'></a>

`TQuestionChoiceEditor`

The type of the question choice editor.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormSection'></a>

`TFormSection`

The type of the form section.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormQuestion'></a>

`TFormQuestion`

The type of the form question.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TQuestionChoice'></a>

`TQuestionChoice`

The type of the question choice.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TSkipFormQuestion'></a>

`TSkipFormQuestion`

The type of the skip form question.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormPage'></a>

`TFormPage`

The type of the form page.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TKey'></a>

`TKey`

The type of the primary key.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TUserKey'></a>

`TUserKey`

The type of the user key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>')[TDbContext](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TDbContext 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TDbContext')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>')[TDbContext](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TDbContext 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TDbContext')[,](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>')[TKey](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TKey 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TKey')[,](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>')[TUserKey](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TUserKey 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TUserKey')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>') &#129106; FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>

Implements [CloudyWing.FormModule.Domain.FormModel.IFormService&lt;](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>')[TFormEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormEditor 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TFormEditor')[,](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>')[TFormDetailEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormDetailEditor 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TFormDetailEditor')[,](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>')[TFormSectionEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormSectionEditor 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TFormSectionEditor')[,](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>')[TFormQuestionEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormQuestionEditor 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TFormQuestionEditor')[,](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>')[TQuestionChoiceEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TQuestionChoiceEditor 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TQuestionChoiceEditor')[,](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>')[TForm](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TForm 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TForm')[,](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>')[TKey](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TKey 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TKey')[&gt;](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>'), [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TForm](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TForm 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TForm')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Constructors

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.FormService(TDbContext,System.IServiceProvider)'></a>

## FormService(TDbContext, IServiceProvider) Constructor

Initializes a new instance of the [FormService&lt;TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>') class.

```csharp
public FormService(TDbContext? dbContext, System.IServiceProvider serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.FormService(TDbContext,System.IServiceProvider).dbContext'></a>

`dbContext` [TDbContext](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TDbContext 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TDbContext')

The database context.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.FormService(TDbContext,System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.
### Properties

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.DataSource'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.DataSource Property

Gets the data source for querying form query entities.

```csharp
public virtual System.Linq.IQueryable<TForm> DataSource { get; }
```

Implements [DataSource](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_.DataSource 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>.DataSource')

#### Property Value
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TForm](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TForm 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TForm')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.FormPages'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.FormPages Property

Gets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of form pages.

```csharp
protected Microsoft.EntityFrameworkCore.DbSet<TFormPage> FormPages { get; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TFormPage](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormPage 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TFormPage')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.FormQuestions'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.FormQuestions Property

Gets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of form questions.

```csharp
protected Microsoft.EntityFrameworkCore.DbSet<TFormQuestion> FormQuestions { get; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TFormQuestion](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormQuestion 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TFormQuestion')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.Forms'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.Forms Property

Gets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of forms.

```csharp
protected Microsoft.EntityFrameworkCore.DbSet<TForm> Forms { get; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TForm](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TForm 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TForm')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.FormSections'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.FormSections Property

Gets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of form sections.

```csharp
protected Microsoft.EntityFrameworkCore.DbSet<TFormSection> FormSections { get; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TFormSection](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormSection 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TFormSection')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.QuestionChoices'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.QuestionChoices Property

Gets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of question choices.

```csharp
protected Microsoft.EntityFrameworkCore.DbSet<TQuestionChoice> QuestionChoices { get; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TQuestionChoice](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TQuestionChoice 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TQuestionChoice')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.SkipFormQuestions'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.SkipFormQuestions Property

Gets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of skip form questions.

```csharp
protected Microsoft.EntityFrameworkCore.DbSet<TSkipFormQuestion> SkipFormQuestions { get; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TSkipFormQuestion](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TSkipFormQuestion 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TSkipFormQuestion')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')
### Methods

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.AllowDeleteAsync(string)'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.AllowDeleteAsync(string) Method

Checks whether deleting a form with the specified ID is allowed.

```csharp
public virtual System.Threading.Tasks.Task<bool> AllowDeleteAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.AllowDeleteAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form.

Implements [AllowDeleteAsync(string)](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md#CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.AllowDeleteAsync(string) 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.AllowDeleteAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if deleting the form is allowed; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.AllowDetailModifyAsync(string)'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.AllowDetailModifyAsync(string) Method

Checks whether modifying the details of a form with the specified ID is allowed.

```csharp
public virtual System.Threading.Tasks.Task<bool> AllowDetailModifyAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.AllowDetailModifyAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form.

Implements [AllowDetailModifyAsync(string)](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md#CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.AllowDetailModifyAsync(string) 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.AllowDetailModifyAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if modifying the form details is allowed; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.CreateAsync(TFormEditor)'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.CreateAsync(TFormEditor) Method

Creates a new form using the provided form editor.

```csharp
public virtual System.Threading.Tasks.Task<bool> CreateAsync(TFormEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.CreateAsync(TFormEditor).editor'></a>

`editor` [TFormEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormEditor 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TFormEditor')

The form editor containing the form data.

Implements [CreateAsync(TFormEditor)](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md#CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.CreateAsync(TFormEditor) 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.CreateAsync(TFormEditor)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form is created successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.CreateDetailsAsync(TFormDetailEditor)'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.CreateDetailsAsync(TFormDetailEditor) Method

Creates the details of a form using the provided form detail editor.

```csharp
public virtual System.Threading.Tasks.Task<bool> CreateDetailsAsync(TFormDetailEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.CreateDetailsAsync(TFormDetailEditor).editor'></a>

`editor` [TFormDetailEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormDetailEditor 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TFormDetailEditor')

The form detail editor containing the form details data.

Implements [CreateDetailsAsync(TFormDetailEditor)](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md#CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.CreateDetailsAsync(TFormDetailEditor) 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.CreateDetailsAsync(TFormDetailEditor)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form details are created successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.DeleteAsync(string)'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.DeleteAsync(string) Method

Deletes a form with the specified ID.

```csharp
public virtual System.Threading.Tasks.Task<bool> DeleteAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.DeleteAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form to delete.

Implements [DeleteAsync(string)](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md#CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.DeleteAsync(string) 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.DeleteAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form is deleted successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.DeleteDetailsAsync(string)'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.DeleteDetailsAsync(string) Method

Deletes the details of a form with the specified form ID.

```csharp
public virtual System.Threading.Tasks.Task<bool> DeleteDetailsAsync(string? formId);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.DeleteDetailsAsync(string).formId'></a>

`formId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form for which to delete the details.

Implements [DeleteDetailsAsync(string)](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md#CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.DeleteDetailsAsync(string) 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.DeleteDetailsAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form details are deleted successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.UpdateAsync(TFormEditor)'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.UpdateAsync(TFormEditor) Method

Updates an existing form using the provided form editor.

```csharp
public virtual System.Threading.Tasks.Task<bool> UpdateAsync(TFormEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.UpdateAsync(TFormEditor).editor'></a>

`editor` [TFormEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.TFormEditor 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.TFormEditor')

The form editor containing the updated form data.

Implements [UpdateAsync(TFormEditor)](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md#CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.UpdateAsync(TFormEditor) 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.UpdateAsync(TFormEditor)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form is updated successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.VerifyCodeNotExistsAsync(CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput)'></a>

## FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>.VerifyCodeNotExistsAsync(VerifyCodeExistsInput) Method

Verifies if a form with the specified code already exists.

```csharp
public virtual System.Threading.Tasks.Task<bool> VerifyCodeNotExistsAsync(CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput input);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_.VerifyCodeNotExistsAsync(CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput).input'></a>

`input` [VerifyCodeExistsInput](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput 'CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput')

The input containing the form code.

Implements [VerifyCodeNotExistsAsync(VerifyCodeExistsInput)](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md#CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.VerifyCodeNotExistsAsync(CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput) 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.VerifyCodeNotExistsAsync(CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the code doesn't exist; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor'></a>

## QuestionChoiceEditor Class

Represents a question choice editor.

```csharp
public class QuestionChoiceEditor : CloudyWing.FormModule.Domain.EditorBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase') &#129106; QuestionChoiceEditor

### See Also
- [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase')
### Constructors

<a name='CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor.QuestionChoiceEditor()'></a>

## QuestionChoiceEditor() Constructor

Initializes a new instance of the [QuestionChoiceEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor 'CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor') class.

```csharp
public QuestionChoiceEditor();
```

<a name='CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor.QuestionChoiceEditor(string)'></a>

## QuestionChoiceEditor(string) Constructor

Initializes a new instance of the [QuestionChoiceEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor 'CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor') class.

```csharp
public QuestionChoiceEditor(string id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor.QuestionChoiceEditor(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The identifier.
### Properties

<a name='CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor.HasText'></a>

## QuestionChoiceEditor.HasText Property

Gets or sets a value indicating whether this question choice has a text field for the response.

```csharp
public bool HasText { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor.Label'></a>

## QuestionChoiceEditor.Label Property

Gets or sets the label.

```csharp
public string? Label { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Methods

<a name='CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor.ThrowIfInvalid()'></a>

## QuestionChoiceEditor.ThrowIfInvalid() Method

Throws if invalid.

```csharp
public virtual void ThrowIfInvalid();
```

<a name='CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput'></a>

## VerifyCodeExistsInput Class

Represents the input for verifying if a code exists within a specified time range.

```csharp
public class VerifyCodeExistsInput
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; VerifyCodeExistsInput
### Properties

<a name='CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput.Code'></a>

## VerifyCodeExistsInput.Code Property

Gets or sets the code to verify.

```csharp
public string? Code { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput.EndTime'></a>

## VerifyCodeExistsInput.EndTime Property

Gets or sets the end time of the time range.

```csharp
public System.DateTimeOffset EndTime { get; set; }
```

#### Property Value
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')

<a name='CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput.Id'></a>

## VerifyCodeExistsInput.Id Property

Gets or sets the ID of the code (optional).

```csharp
public string? Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput.StartTime'></a>

## VerifyCodeExistsInput.StartTime Property

Gets or sets the start time of the time range.

```csharp
public System.DateTimeOffset StartTime { get; set; }
```

#### Property Value
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')

| Interfaces | |
| :--- | :--- |
| [IFormService&lt;TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey&gt;](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>') | Represents a service for managing forms. |
