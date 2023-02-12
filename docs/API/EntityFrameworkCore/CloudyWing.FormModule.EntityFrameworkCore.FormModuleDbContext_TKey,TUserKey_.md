### [CloudyWing.FormModule.EntityFrameworkCore](CloudyWing.FormModule.EntityFrameworkCore.md 'CloudyWing.FormModule.EntityFrameworkCore')

## FormModuleDbContext<TKey,TUserKey> Class

Basic class for the Entity Framework database context used for form module.

```csharp
public abstract class FormModuleDbContext<TKey,TUserKey> : CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>, CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>, CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>, CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion<TKey>, CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>, CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail<TKey>, TKey, string>
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
    where TUserKey : System.IEquatable<TUserKey>
```
#### Type parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.TKey'></a>

`TKey`

The type of the key.

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.TUserKey'></a>

`TUserKey`

The type of the user key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext') &#129106; [CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext&lt;](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>')[CloudyWing.FormModule.EntityFrameworkCore.Form&lt;](CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>')[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TKey,TUserKey>.TKey')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>')[,](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>')[CloudyWing.FormModule.EntityFrameworkCore.FormSection&lt;](CloudyWing.FormModule.EntityFrameworkCore.FormSection_TKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>')[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TKey,TUserKey>.TKey')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.FormSection_TKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>')[,](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>')[CloudyWing.FormModule.EntityFrameworkCore.FormQuestion&lt;](CloudyWing.FormModule.EntityFrameworkCore.FormQuestion_TKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>')[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TKey,TUserKey>.TKey')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.FormQuestion_TKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>')[,](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>')[CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice&lt;](CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice_TKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>')[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TKey,TUserKey>.TKey')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice_TKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>')[,](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>')[CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion&lt;](CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion<TKey>')[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TKey,TUserKey>.TKey')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion_TKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion<TKey>')[,](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>')[CloudyWing.FormModule.EntityFrameworkCore.FormPage&lt;](CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>')[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TKey,TUserKey>.TKey')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.FormPage_TKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>')[,](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>')[CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail&lt;](CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail<TKey>')[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TKey,TUserKey>.TKey')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail_TKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail<TKey>')[,](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>')[TKey](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.md#CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TKey,TUserKey>.TKey')[,](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey,TUserKey>') &#129106; FormModuleDbContext<TKey,TUserKey>
### Constructors

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.FormModuleDbContext(Microsoft.EntityFrameworkCore.DbContextOptions)'></a>

## FormModuleDbContext(DbContextOptions) Constructor

Initializes a new instance of the [FormModuleDbContext&lt;TKey,TUserKey&gt;](CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.md 'CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext<TKey,TUserKey>') class.

```csharp
public FormModuleDbContext(Microsoft.EntityFrameworkCore.DbContextOptions options);
```
#### Parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.FormModuleDbContext_TKey,TUserKey_.FormModuleDbContext(Microsoft.EntityFrameworkCore.DbContextOptions).options'></a>

`options` [Microsoft.EntityFrameworkCore.DbContextOptions](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContextOptions 'Microsoft.EntityFrameworkCore.DbContextOptions')

The options to be used by a [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext').