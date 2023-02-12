### [CloudyWing.FormModule.EntityFrameworkCore](CloudyWing.FormModule.EntityFrameworkCore.md 'CloudyWing.FormModule.EntityFrameworkCore')

## FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey> Class

Basic class for the Entity Framework database context used for form module.

```csharp
public abstract class FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey> : Microsoft.EntityFrameworkCore.DbContext
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TFormSection : CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>, new()
    where TFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>, new()
    where TQuestionChoice : CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>, new()
    where TSkipFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion<TKey>, new()
    where TFormPage : CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>, new()
    where TFormPageDetail : CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
    where TUserKey : System.IEquatable<TUserKey>
```
#### Type parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormSection'></a>

`TFormSection`

The type of the form section.

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormQuestion'></a>

`TFormQuestion`

The type of the form question.

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TQuestionChoice'></a>

`TQuestionChoice`

The type of the question choice.

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TSkipFormQuestion'></a>

`TSkipFormQuestion`

The type of the skip form question.

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPage'></a>

`TFormPage`

The type of the form page.

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPageDetail'></a>

`TFormPageDetail`

The type of the form page detail.

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TKey'></a>

`TKey`

The type of the key.

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TUserKey'></a>

`TUserKey`

The type of the user key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext') &#129106; FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>

Derived  
&#8627; [FormModuleDbContext&lt;TKey,TUserKey&gt;](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TKey,TUserKey>')

### See Also
- [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext')
### Constructors

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.FormModuleDbContext()'></a>

## FormModuleDbContext() Constructor

Initializes a new instance of the class.

```csharp
protected FormModuleDbContext();
```

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.FormModuleDbContext(Microsoft.EntityFrameworkCore.DbContextOptions)'></a>

## FormModuleDbContext(DbContextOptions) Constructor

Initializes a new instance of the class.

```csharp
protected FormModuleDbContext(Microsoft.EntityFrameworkCore.DbContextOptions options);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.FormModuleDbContext(Microsoft.EntityFrameworkCore.DbContextOptions).options'></a>

`options` [Microsoft.EntityFrameworkCore.DbContextOptions](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContextOptions 'Microsoft.EntityFrameworkCore.DbContextOptions')

The options to be used by a [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext').
### Properties

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.FormPageDetails'></a>

## FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.FormPageDetails Property

Gets or sets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of FormPageDetails.

```csharp
public virtual Microsoft.EntityFrameworkCore.DbSet<TFormPageDetail> FormPageDetails { get; set; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TFormPageDetail](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPageDetail 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormPageDetail')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.FormPages'></a>

## FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.FormPages Property

Gets or sets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of FormPages.

```csharp
public virtual Microsoft.EntityFrameworkCore.DbSet<TFormPage> FormPages { get; set; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TFormPage](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormPage 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormPage')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.FormQuestions'></a>

## FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.FormQuestions Property

Gets or sets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of FormQuestions.

```csharp
public virtual Microsoft.EntityFrameworkCore.DbSet<TFormQuestion> FormQuestions { get; set; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TFormQuestion](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormQuestion 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormQuestion')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.Forms'></a>

## FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.Forms Property

Gets or sets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of Forms.

```csharp
public virtual Microsoft.EntityFrameworkCore.DbSet<TForm> Forms { get; set; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TForm](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TForm 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.TForm')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.FormSections'></a>

## FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.FormSections Property

Gets or sets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of FormSections.

```csharp
public virtual Microsoft.EntityFrameworkCore.DbSet<TFormSection> FormSections { get; set; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TFormSection](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TFormSection 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.TFormSection')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.QuestionChoices'></a>

## FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.QuestionChoices Property

Gets or sets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of QuestionChoices.

```csharp
public virtual Microsoft.EntityFrameworkCore.DbSet<TQuestionChoice> QuestionChoices { get; set; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TQuestionChoice](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TQuestionChoice 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.TQuestionChoice')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.SkipFormQuestions'></a>

## FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.SkipFormQuestions Property

Gets or sets the [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') of SkipFormQuestions.

```csharp
public virtual Microsoft.EntityFrameworkCore.DbSet<TSkipFormQuestion> SkipFormQuestions { get; set; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.DbSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')[TSkipFormQuestion](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TSkipFormQuestion 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.TSkipFormQuestion')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1')

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.UserUserIdConverter'></a>

## FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.UserUserIdConverter Property

Gets the converter that converts the UserId from string and `TKey`.

```csharp
protected virtual Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter<string,TUserKey?> UserUserIdConverter { get; }
```

#### Property Value
[Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter-2 'Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter-2 'Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter`2')[TUserKey](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.TUserKey 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.TUserKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter-2 'Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter`2')
### Methods

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder)'></a>

## FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.OnModelCreating(ModelBuilder) Method

Override this method to further configure the model that was discovered by convention from the entity types  
exposed in [Microsoft.EntityFrameworkCore.DbSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbSet-1 'Microsoft.EntityFrameworkCore.DbSet`1') properties on your derived context. The resulting model may be cached  
and re-used for subsequent instances of your derived context.

```csharp
protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder).modelBuilder'></a>

`modelBuilder` [Microsoft.EntityFrameworkCore.ModelBuilder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.ModelBuilder 'Microsoft.EntityFrameworkCore.ModelBuilder')

The builder being used to construct the model for this context. Databases (and other extensions) typically  
define extension methods on this object that allow you to configure aspects of the model that are specific  
to a given database.

### Remarks
  
If a model is explicitly set on the options for this context (via [Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel#Microsoft_EntityFrameworkCore_DbContextOptionsBuilder_UseModel_Microsoft_EntityFrameworkCore_Metadata_IModel_ 'Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)'))  
then this method will not be run.  
  
See [Modeling entity types and relationships](https://aka.ms/efcore-docs-modeling 'https://aka.ms/efcore-docs-modeling') for more information.

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.SetIdColumn(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder,bool,bool)'></a>

## FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.SetIdColumn(PropertyBuilder, bool, bool) Method

Sets the identifier column.

```csharp
protected virtual void SetIdColumn(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder builder, bool isRequired, bool isPk);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.SetIdColumn(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder,bool,bool).builder'></a>

`builder` [Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder 'Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder')

The builder.

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.SetIdColumn(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder,bool,bool).isRequired'></a>

`isRequired` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [is required].

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.SetIdColumn(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder,bool,bool).isPk'></a>

`isPk` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [is pk].

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.SetUserIdColumn(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder,bool)'></a>

## FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>.SetUserIdColumn(PropertyBuilder, bool) Method

Sets the user identifier column.

```csharp
protected virtual void SetUserIdColumn(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder builder, bool isRequired);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.SetUserIdColumn(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder,bool).builder'></a>

`builder` [Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder 'Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder')

The builder.

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.SetUserIdColumn(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder,bool).isRequired'></a>

`isRequired` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [is required].