#### [CloudyWing.FormModule.Domain](index.md 'index')

## CloudyWing.FormModule.Domain.FormPageModel Namespace
### Classes

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailEditor'></a>

## FormPageDetailEditor Class

Represents a form page detail editor.

```csharp
public class FormPageDetailEditor
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormPageDetailEditor
### Properties

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailEditor.FormQuestionId'></a>

## FormPageDetailEditor.FormQuestionId Property

Gets or sets the id for the form question.

```csharp
public string FormQuestionId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailEditor.QuestionChoiceId'></a>

## FormPageDetailEditor.QuestionChoiceId Property

Gets or sets the id for the question choice.

```csharp
public string? QuestionChoiceId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailEditor.Response'></a>

## FormPageDetailEditor.Response Property

Gets or sets the response.

```csharp
public string? Response { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity_TFormPageDetail,TFormPage,TForm,TKey_'></a>

## FormPageDetailQueryEntity<TFormPageDetail,TFormPage,TForm,TKey> Class

Represents a query entity for form form page detail.

```csharp
public class FormPageDetailQueryEntity<TFormPageDetail,TFormPage,TForm,TKey>
    where TFormPageDetail : CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail<TKey>, new()
    where TFormPage : CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity_TFormPageDetail,TFormPage,TForm,TKey_.TFormPageDetail'></a>

`TFormPageDetail`

The type of the form page detail.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity_TFormPageDetail,TFormPage,TForm,TKey_.TFormPage'></a>

`TFormPage`

The type of the form page.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity_TFormPageDetail,TFormPage,TForm,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity_TFormPageDetail,TFormPage,TForm,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormPageDetailQueryEntity<TFormPageDetail,TFormPage,TForm,TKey>
### Properties

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity_TFormPageDetail,TFormPage,TForm,TKey_.Form'></a>

## FormPageDetailQueryEntity<TFormPageDetail,TFormPage,TForm,TKey>.Form Property

Gets or sets the form.

```csharp
public TForm Form { get; set; }
```

#### Property Value
[TForm](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity_TFormPageDetail,TFormPage,TForm,TKey_.TForm 'CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity<TFormPageDetail,TFormPage,TForm,TKey>.TForm')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity_TFormPageDetail,TFormPage,TForm,TKey_.Page'></a>

## FormPageDetailQueryEntity<TFormPageDetail,TFormPage,TForm,TKey>.Page Property

Gets or sets the page.

```csharp
public TFormPage Page { get; set; }
```

#### Property Value
[TFormPage](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity_TFormPageDetail,TFormPage,TForm,TKey_.TFormPage 'CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity<TFormPageDetail,TFormPage,TForm,TKey>.TFormPage')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity_TFormPageDetail,TFormPage,TForm,TKey_.PageDetail'></a>

## FormPageDetailQueryEntity<TFormPageDetail,TFormPage,TForm,TKey>.PageDetail Property

Gets or sets the page detail.

```csharp
public TFormPageDetail PageDetail { get; set; }
```

#### Property Value
[TFormPageDetail](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity_TFormPageDetail,TFormPage,TForm,TKey_.TFormPageDetail 'CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity<TFormPageDetail,TFormPage,TForm,TKey>.TFormPageDetail')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_'></a>

## FormPageDetailQueryService<TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey> Class

Represents a service for querying form page details.

```csharp
public class FormPageDetailQueryService<TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey> : CloudyWing.FormModule.Domain.DomainService<TDbContext>,
CloudyWing.FormModule.Domain.IQueryableService<TFormPageDetailQueryEntity>
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TFormPageDetailQueryEntity : CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity<TFormPageDetail, TFormPage, TForm, TKey>, new()
    where TFormPageDetail : CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail<TKey>, new()
    where TFormPage : CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_.TFormPageDetailQueryEntity'></a>

`TFormPageDetailQueryEntity`

The type of the query entity for form page details.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_.TFormPageDetail'></a>

`TFormPageDetail`

The type of the form page detail.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_.TFormPage'></a>

`TFormPage`

The type of the form page.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>')[TDbContext](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_.TDbContext 'CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService<TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey>.TDbContext')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>') &#129106; FormPageDetailQueryService<TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey>

Implements [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_ 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TFormPageDetailQueryEntity](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_.TFormPageDetailQueryEntity 'CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService<TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey>.TFormPageDetailQueryEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_ 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Constructors

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_.FormPageDetailQueryService(TDbContext,System.IServiceProvider)'></a>

## FormPageDetailQueryService(TDbContext, IServiceProvider) Constructor

Initializes a new instance of the [FormPageDetailQueryService&lt;TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey&gt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_ 'CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService<TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey>') class.

```csharp
public FormPageDetailQueryService(TDbContext? dbContext, System.IServiceProvider? serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_.FormPageDetailQueryService(TDbContext,System.IServiceProvider).dbContext'></a>

`dbContext` [TDbContext](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_.TDbContext 'CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService<TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey>.TDbContext')

The database context.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_.FormPageDetailQueryService(TDbContext,System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.
### Properties

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_.DataSource'></a>

## FormPageDetailQueryService<TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey>.DataSource Property

Gets the data source for querying form page detail query entities.

```csharp
public virtual System.Linq.IQueryable<TFormPageDetailQueryEntity> DataSource { get; }
```

Implements [DataSource](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_.DataSource 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>.DataSource')

#### Property Value
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TFormPageDetailQueryEntity](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_.TFormPageDetailQueryEntity 'CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService<TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey>.TFormPageDetailQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor'></a>

## FormPageEditor Class

Represents a form page editor.

```csharp
public class FormPageEditor : CloudyWing.FormModule.Domain.EditorBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase') &#129106; FormPageEditor

Derived  
&#8627; [FormPageWithDetailsEditor&lt;TFormPageDetailEditor&gt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor_TFormPageDetailEditor_ 'CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor<TFormPageDetailEditor>')

### See Also
- [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase')
### Constructors

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor.FormPageEditor()'></a>

## FormPageEditor() Constructor

Initializes a new instance of the [FormPageEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor 'CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor') class.

```csharp
public FormPageEditor();
```

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor.FormPageEditor(string)'></a>

## FormPageEditor(string) Constructor

Initializes a new instance of the [FormPageEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor 'CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor') class.

```csharp
public FormPageEditor(string id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor.FormPageEditor(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The identifier.
### Properties

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor.ExecutedBy'></a>

## FormPageEditor.ExecutedBy Property

Gets or sets the primary key of the user who exected the form.

```csharp
public string ExecutedBy { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor.FormId'></a>

## FormPageEditor.FormId Property

Gets or sets the primary key of the form that this form page belongs to.

```csharp
public string FormId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor.IP'></a>

## FormPageEditor.IP Property

Gets or sets the IP address of the user who submitted.

```csharp
public CloudyWing.FormModule.Domain.ValueWatcher<string> IP { get; set; }
```

#### Property Value
[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor.SecurityCode'></a>

## FormPageEditor.SecurityCode Property

Gets or sets the security code.

```csharp
public string? SecurityCode { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryEntity_TFormPage,TForm,TKey_'></a>

## FormPageQueryEntity<TFormPage,TForm,TKey> Class

Represents a query entity for form page.

```csharp
public class FormPageQueryEntity<TFormPage,TForm,TKey>
    where TFormPage : CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryEntity_TFormPage,TForm,TKey_.TFormPage'></a>

`TFormPage`

The type of the form page.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryEntity_TFormPage,TForm,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryEntity_TFormPage,TForm,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormPageQueryEntity<TFormPage,TForm,TKey>
### Properties

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryEntity_TFormPage,TForm,TKey_.Form'></a>

## FormPageQueryEntity<TFormPage,TForm,TKey>.Form Property

Gets or sets the form.

```csharp
public TForm Form { get; set; }
```

#### Property Value
[TForm](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryEntity_TFormPage,TForm,TKey_.TForm 'CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryEntity<TFormPage,TForm,TKey>.TForm')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryEntity_TFormPage,TForm,TKey_.Page'></a>

## FormPageQueryEntity<TFormPage,TForm,TKey>.Page Property

Gets or sets the page.

```csharp
public TFormPage Page { get; set; }
```

#### Property Value
[TFormPage](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryEntity_TFormPage,TForm,TKey_.TFormPage 'CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryEntity<TFormPage,TForm,TKey>.TFormPage')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_'></a>

## FormPageQueryService<TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey> Class

Represents a service for querying form form pages.

```csharp
public class FormPageQueryService<TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey> : CloudyWing.FormModule.Domain.DomainService<TDbContext>,
CloudyWing.FormModule.Domain.IQueryableService<TFormPageQueryEntity>
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TFormPageQueryEntity : CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryEntity<TFormPage, TForm, TKey>, new()
    where TFormPage : CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_.TFormPageQueryEntity'></a>

`TFormPageQueryEntity`

The type of the query entity for form pages.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_.TFormPage'></a>

`TFormPage`

The type of the form page.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>')[TDbContext](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_.TDbContext 'CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService<TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey>.TDbContext')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>') &#129106; FormPageQueryService<TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey>

Implements [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_ 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TFormPageQueryEntity](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_.TFormPageQueryEntity 'CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService<TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey>.TFormPageQueryEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_ 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Constructors

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_.FormPageQueryService(TDbContext,System.IServiceProvider)'></a>

## FormPageQueryService(TDbContext, IServiceProvider) Constructor

Initializes a new instance of the [FormPageQueryService&lt;TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey&gt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_ 'CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService<TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey>') class.

```csharp
public FormPageQueryService(TDbContext? dbContext, System.IServiceProvider? serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_.FormPageQueryService(TDbContext,System.IServiceProvider).dbContext'></a>

`dbContext` [TDbContext](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_.TDbContext 'CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService<TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey>.TDbContext')

The database context.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_.FormPageQueryService(TDbContext,System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.
### Properties

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_.DataSource'></a>

## FormPageQueryService<TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey>.DataSource Property

Gets the data source for querying form page query entities.

```csharp
public virtual System.Linq.IQueryable<TFormPageQueryEntity> DataSource { get; }
```

Implements [DataSource](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_.DataSource 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>.DataSource')

#### Property Value
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TFormPageQueryEntity](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_.TFormPageQueryEntity 'CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService<TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey>.TFormPageQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_'></a>

## FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey> Class

Implementation of the form page service.

```csharp
public class FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey> : CloudyWing.FormModule.Domain.DomainService<TDbContext, TKey, TUserKey>,
CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor, TFormPageWithDetailsEditor, TFormPageDetailEditor, TFormPage, TKey>,
CloudyWing.FormModule.Domain.IQueryableService<TFormPage>
    where TFormPageEditor : CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor, new()
    where TFormPageWithDetailsEditor : CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor<TFormPageDetailEditor>, TFormPageEditor, new()
    where TFormPageDetailEditor : CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailEditor, new()
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TFormPage : CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>, new()
    where TFormPageDetail : CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
    where TUserKey : System.IEquatable<TUserKey>
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPageEditor'></a>

`TFormPageEditor`

The type of the form page editor.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPageWithDetailsEditor'></a>

`TFormPageWithDetailsEditor`

The type of the form page with details editor.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPageDetailEditor'></a>

`TFormPageDetailEditor`

The type of the form page detail editor.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPage'></a>

`TFormPage`

The type of the form page.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPageDetail'></a>

`TFormPageDetail`

The type of the form page detail.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TKey'></a>

`TKey`

The type of the key.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TUserKey'></a>

`TUserKey`

The type of the user key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>')[TDbContext](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TDbContext 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TDbContext')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>')[TDbContext](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TDbContext 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TDbContext')[,](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>')[TKey](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TKey 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TKey')[,](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>')[TUserKey](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TUserKey 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TUserKey')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>') &#129106; FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>

Implements [CloudyWing.FormModule.Domain.FormPageModel.IFormPageService&lt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_ 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>')[TFormPageEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPageEditor 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormPageEditor')[,](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_ 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>')[TFormPageWithDetailsEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPageWithDetailsEditor 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormPageWithDetailsEditor')[,](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_ 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>')[TFormPageDetailEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPageDetailEditor 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormPageDetailEditor')[,](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_ 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>')[TFormPage](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPage 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormPage')[,](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_ 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>')[TKey](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TKey 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TKey')[&gt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_ 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>'), [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_ 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TFormPage](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPage 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormPage')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_ 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Constructors

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.FormPageService(TDbContext,System.IServiceProvider)'></a>

## FormPageService(TDbContext, IServiceProvider) Constructor

Initializes a new instance of the [FormPageService&lt;TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>') class.

```csharp
public FormPageService(TDbContext? dbContext, System.IServiceProvider? serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.FormPageService(TDbContext,System.IServiceProvider).dbContext'></a>

`dbContext` [TDbContext](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TDbContext 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TDbContext')

The database context.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.FormPageService(TDbContext,System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.
### Properties

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.DataSource'></a>

## FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.DataSource Property

Gets the data source for querying form page query entities.

```csharp
public System.Linq.IQueryable<TFormPage> DataSource { get; }
```

Implements [DataSource](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_.DataSource 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>.DataSource')

#### Property Value
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TFormPage](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPage 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormPage')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.FormPageDetails'></a>

## FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.FormPageDetails Property

Gets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of form page details.

```csharp
protected Microsoft.EntityFrameworkCore.DbSet<TFormPageDetail> FormPageDetails { get; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TFormPageDetail](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPageDetail 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormPageDetail')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.FormPages'></a>

## FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.FormPages Property

Gets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of form pages.

```csharp
protected Microsoft.EntityFrameworkCore.DbSet<TFormPage> FormPages { get; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TFormPage](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPage 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormPage')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')
### Methods

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.CreateAsync(TFormPageEditor)'></a>

## FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.CreateAsync(TFormPageEditor) Method

Creates a new form page.

```csharp
public virtual System.Threading.Tasks.Task<bool> CreateAsync(TFormPageEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.CreateAsync(TFormPageEditor).editor'></a>

`editor` [TFormPageEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPageEditor 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormPageEditor')

The form page editor.

Implements [CreateAsync(TFormPageEditor)](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.CreateAsync(TFormPageEditor) 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.CreateAsync(TFormPageEditor)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form page is created successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.DeleteAsync(string)'></a>

## FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.DeleteAsync(string) Method

Deletes a form page.

```csharp
public virtual System.Threading.Tasks.Task<bool> DeleteAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.DeleteAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form page to delete.

Implements [DeleteAsync(string)](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.DeleteAsync(string) 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.DeleteAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form page is deleted successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.UpdateAsync(TFormPageEditor)'></a>

## FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.UpdateAsync(TFormPageEditor) Method

Updates an existing form page.

```csharp
public virtual System.Threading.Tasks.Task<bool> UpdateAsync(TFormPageEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.UpdateAsync(TFormPageEditor).editor'></a>

`editor` [TFormPageEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPageEditor 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormPageEditor')

The form page editor.

Implements [UpdateAsync(TFormPageEditor)](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.UpdateAsync(TFormPageEditor) 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.UpdateAsync(TFormPageEditor)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form page is updated successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.UpsertDetailsAsync(TFormPageWithDetailsEditor)'></a>

## FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.UpsertDetailsAsync(TFormPageWithDetailsEditor) Method

Upserts the details of a form page.

```csharp
public virtual System.Threading.Tasks.Task<bool> UpsertDetailsAsync(TFormPageWithDetailsEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.UpsertDetailsAsync(TFormPageWithDetailsEditor).editor'></a>

`editor` [TFormPageWithDetailsEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPageWithDetailsEditor 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormPageWithDetailsEditor')

The form page with details editor.

Implements [UpsertDetailsAsync(TFormPageWithDetailsEditor)](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.UpsertDetailsAsync(TFormPageWithDetailsEditor) 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.UpsertDetailsAsync(TFormPageWithDetailsEditor)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form page details are upserted successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor_TFormPageDetailEditor_'></a>

## FormPageWithDetailsEditor<TFormPageDetailEditor> Class

Represents a form page with detail editor.

```csharp
public class FormPageWithDetailsEditor<TFormPageDetailEditor> : CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor
    where TFormPageDetailEditor : CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailEditor
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor_TFormPageDetailEditor_.TFormPageDetailEditor'></a>

`TFormPageDetailEditor`

The type of the form page detail editor.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase') &#129106; [FormPageEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor 'CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor') &#129106; FormPageWithDetailsEditor<TFormPageDetailEditor>

### See Also
- [FormPageEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor 'CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor')
### Constructors

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor_TFormPageDetailEditor_.FormPageWithDetailsEditor()'></a>

## FormPageWithDetailsEditor() Constructor

Initializes a new instance of the [FormPageWithDetailsEditor&lt;TFormPageDetailEditor&gt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor_TFormPageDetailEditor_ 'CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor<TFormPageDetailEditor>') class.

```csharp
public FormPageWithDetailsEditor();
```

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor_TFormPageDetailEditor_.FormPageWithDetailsEditor(string)'></a>

## FormPageWithDetailsEditor(string) Constructor

Initializes a new instance of the [FormPageWithDetailsEditor&lt;TFormPageDetailEditor&gt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor_TFormPageDetailEditor_ 'CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor<TFormPageDetailEditor>') class.

```csharp
public FormPageWithDetailsEditor(string id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor_TFormPageDetailEditor_.FormPageWithDetailsEditor(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The identifier.
### Properties

<a name='CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor_TFormPageDetailEditor_.Details'></a>

## FormPageWithDetailsEditor<TFormPageDetailEditor>.Details Property

Gets the details.

```csharp
public System.Collections.Generic.IList<TFormPageDetailEditor> Details { get; }
```

#### Property Value
[System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[TFormPageDetailEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor_TFormPageDetailEditor_.TFormPageDetailEditor 'CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor<TFormPageDetailEditor>.TFormPageDetailEditor')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')
### Interfaces

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_'></a>

## IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey> Interface

Interface for the form page service.

```csharp
public interface IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey> :
CloudyWing.FormModule.Domain.IQueryableService<TFormPage>
    where TFormPageEditor : CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor, new()
    where TFormPageWithDetailsEditor : CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor<TFormPageDetailEditor>, new()
    where TFormPageDetailEditor : CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailEditor, new()
    where TFormPage : CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.TFormPageEditor'></a>

`TFormPageEditor`

The type of the form page editor.

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.TFormPageWithDetailsEditor'></a>

`TFormPageWithDetailsEditor`

The type of the form page with details editor.

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.TFormPageDetailEditor'></a>

`TFormPageDetailEditor`

The type of the form page detail editor.

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.TFormPage'></a>

`TFormPage`

The type of the form page.

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.TKey'></a>

`TKey`

The type of the key.

Derived  
&#8627; [FormPageService&lt;TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>')

Implements [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_ 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TFormPage](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.TFormPage 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.TFormPage')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_ 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Methods

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.CreateAsync(TFormPageEditor)'></a>

## IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.CreateAsync(TFormPageEditor) Method

Creates a new form page.

```csharp
System.Threading.Tasks.Task<bool> CreateAsync(TFormPageEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.CreateAsync(TFormPageEditor).editor'></a>

`editor` [TFormPageEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.TFormPageEditor 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.TFormPageEditor')

The form page editor.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form page is created successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.DeleteAsync(string)'></a>

## IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.DeleteAsync(string) Method

Deletes a form page.

```csharp
System.Threading.Tasks.Task<bool> DeleteAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.DeleteAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form page to delete.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form page is deleted successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.UpdateAsync(TFormPageEditor)'></a>

## IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.UpdateAsync(TFormPageEditor) Method

Updates an existing form page.

```csharp
System.Threading.Tasks.Task<bool> UpdateAsync(TFormPageEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.UpdateAsync(TFormPageEditor).editor'></a>

`editor` [TFormPageEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.TFormPageEditor 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.TFormPageEditor')

The form page editor.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form page is updated successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.UpsertDetailsAsync(TFormPageWithDetailsEditor)'></a>

## IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.UpsertDetailsAsync(TFormPageWithDetailsEditor) Method

Upserts the details of a form page.

```csharp
System.Threading.Tasks.Task<bool> UpsertDetailsAsync(TFormPageWithDetailsEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.UpsertDetailsAsync(TFormPageWithDetailsEditor).editor'></a>

`editor` [TFormPageWithDetailsEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.TFormPageWithDetailsEditor 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.TFormPageWithDetailsEditor')

The form page with details editor.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form page details are upserted successfully; otherwise, `false`.