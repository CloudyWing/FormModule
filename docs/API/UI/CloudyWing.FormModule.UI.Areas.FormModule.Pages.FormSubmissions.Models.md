#### [CloudyWing.FormModule](index.md 'index')

## CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models Namespace
### Classes

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.CompletionViewModel'></a>

## CompletionViewModel Class

Represents the view model for completion.

```csharp
public class CompletionViewModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CompletionViewModel
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.CompletionViewModel.CompletionMessage'></a>

## CompletionViewModel.CompletionMessage Property

Gets or sets the completion message.

```csharp
public string? CompletionMessage { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_'></a>

## FormSubmissionCompletionAppService<TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey> Class

Represents an implementation of the form submission completion application service.

```csharp
public class FormSubmissionCompletionAppService<TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey> : CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>,
CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionCompletionAppService<TCompletionViewModel>
    where TCompletionViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.CompletionViewModel, new()
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TFormPageQueryEntity : CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryEntity<TFormPage, TForm, TKey>, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TFormPage : CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.TCompletionViewModel'></a>

`TCompletionViewModel`

The type of the completion view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.TFormPageQueryEntity'></a>

`TFormPageQueryEntity`

The type of the form page query entity.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.TFormPage'></a>

`TFormPage`

The type of the form page.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [ApplicationService](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService') &#129106; [CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService<TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey>.TKey')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>') &#129106; FormSubmissionCompletionAppService<TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey>

Implements [CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionCompletionAppService&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionCompletionAppService_TCompletionViewModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionCompletionAppService<TCompletionViewModel>')[TCompletionViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.TCompletionViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService<TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey>.TCompletionViewModel')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionCompletionAppService_TCompletionViewModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionCompletionAppService<TCompletionViewModel>')
### Constructors

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.FormSubmissionCompletionAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.IQueryableService_TFormPageQueryEntity_)'></a>

## FormSubmissionCompletionAppService(IServiceProvider, IQueryableService<TFormPageQueryEntity>) Constructor

Initializes a new instance of the [FormSubmissionCompletionAppService&lt;TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService<TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey>') class.

```csharp
public FormSubmissionCompletionAppService(System.IServiceProvider? serviceProvider, CloudyWing.FormModule.Domain.IQueryableService<TFormPageQueryEntity> formPageQueryService);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.FormSubmissionCompletionAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.IQueryableService_TFormPageQueryEntity_).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.FormSubmissionCompletionAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.IQueryableService_TFormPageQueryEntity_).formPageQueryService'></a>

`formPageQueryService` [CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TFormPageQueryEntity](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.TFormPageQueryEntity 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService<TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey>.TFormPageQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')

The form page query service.

#### Exceptions

[CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils 'CloudyWing.FormModule.Infrastructure.Util.ExceptionUtils')
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.FormPageQueryService'></a>

## FormSubmissionCompletionAppService<TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey>.FormPageQueryService Property

Gets the form page query service.

```csharp
protected CloudyWing.FormModule.Domain.IQueryableService<TFormPageQueryEntity> FormPageQueryService { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TFormPageQueryEntity](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.TFormPageQueryEntity 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService<TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey>.TFormPageQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')  
The form page query service.
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.GetViewAsync(string)'></a>

## FormSubmissionCompletionAppService<TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey>.GetViewAsync(string) Method

Gets the index view based on the form ID.

```csharp
public virtual System.Threading.Tasks.Task<TCompletionViewModel> GetViewAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.GetViewAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the view model to retrieve.

Implements [GetViewAsync(string)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionCompletionAppService_TCompletionViewModel_.GetViewAsync(string) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionCompletionAppService<TCompletionViewModel>.GetViewAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TCompletionViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_.TCompletionViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService<TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey>.TCompletionViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The completion index view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_'></a>

## FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey> Class

Represents the application service for form submission index.

```csharp
public class FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey> : CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>,
CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel, TIndexSectionViewModel, TIndexQuestionViewModel, TIndexChoiceViewModel, TIndexSkipViewModel, TIndexInputModel, TIndexQuestionInputModel, TIndexChoiceInputModel>
    where TIndexViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel<TIndexSectionViewModel, TIndexQuestionViewModel, TIndexChoiceViewModel, TIndexSkipViewModel>, new()
    where TIndexSectionViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSectionViewModel<TIndexQuestionViewModel, TIndexChoiceViewModel>, new()
    where TIndexQuestionViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionViewModel<TIndexChoiceViewModel>, new()
    where TIndexChoiceViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceViewModel, new()
    where TIndexSkipViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSkipViewModel, new()
    where TIndexInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexInputModel<TIndexQuestionInputModel, TIndexChoiceInputModel>, new()
    where TIndexQuestionInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionInputModel<TIndexChoiceInputModel>, new()
    where TIndexChoiceInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceInputModel, new()
    where TFormPageEditor : CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor, new()
    where TFormPageWithDetailsEditor : CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor<TFormPageDetailEditor>, new()
    where TFormPageDetailEditor : CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailEditor, new()
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TFormDetailQueryEntity : CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity<TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
    where TFormPageDetailQueryEntity : CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity<TFormPageDetail, TFormPage, TForm, TKey>, new()
    where TSkipFormQuestionQueryEntity : CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryEntity<TSkipFormQuestion, TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TFormSection : CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>, new()
    where TFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>, new()
    where TQuestionChoice : CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>, new()
    where TSkipFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion<TKey>, new()
    where TFormPage : CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>, new()
    where TFormPageDetail : CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexViewModel'></a>

`TIndexViewModel`

The type of the index view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexSectionViewModel'></a>

`TIndexSectionViewModel`

The type of the index section view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexQuestionViewModel'></a>

`TIndexQuestionViewModel`

The type of the index question view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexChoiceViewModel'></a>

`TIndexChoiceViewModel`

The type of the index choice view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexSkipViewModel'></a>

`TIndexSkipViewModel`

The type of the index skip view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexInputModel'></a>

`TIndexInputModel`

The type of the index input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexQuestionInputModel'></a>

`TIndexQuestionInputModel`

The type of the index question input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexChoiceInputModel'></a>

`TIndexChoiceInputModel`

The type of the index choice input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPageEditor'></a>

`TFormPageEditor`

The type of the form page editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPageWithDetailsEditor'></a>

`TFormPageWithDetailsEditor`

The type of the form page with details editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPageDetailEditor'></a>

`TFormPageDetailEditor`

The type of the form page detail editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormDetailQueryEntity'></a>

`TFormDetailQueryEntity`

The type of the form detail query entity.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPageDetailQueryEntity'></a>

`TFormPageDetailQueryEntity`

The type of the form page detail query entity.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TSkipFormQuestionQueryEntity'></a>

`TSkipFormQuestionQueryEntity`

The type of the skip form question query entity.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormSection'></a>

`TFormSection`

The type of the form section.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormQuestion'></a>

`TFormQuestion`

The type of the form question.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TQuestionChoice'></a>

`TQuestionChoice`

The type of the question choice.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TSkipFormQuestion'></a>

`TSkipFormQuestion`

The type of the skip form question.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPage'></a>

`TFormPage`

The type of the form page.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPageDetail'></a>

`TFormPageDetail`

The type of the form page detail.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [ApplicationService](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService') &#129106; [CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TKey')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>') &#129106; FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>

Implements [CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>')[TIndexViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexViewModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>')[TIndexSectionViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexSectionViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexSectionViewModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>')[TIndexQuestionViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexQuestionViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexQuestionViewModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>')[TIndexChoiceViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexChoiceViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexChoiceViewModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>')[TIndexSkipViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexSkipViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexSkipViewModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>')[TIndexInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexInputModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>')[TIndexQuestionInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexQuestionInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexQuestionInputModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>')[TIndexChoiceInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexChoiceInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexChoiceInputModel')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>')
### Constructors

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.FormSubmissionIndexAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_,CloudyWing.FormModule.Domain.IQueryableService_TFormDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TFormPageDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TSkipFormQuestionQueryEntity_)'></a>

## FormSubmissionIndexAppService(IServiceProvider, IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>, IQueryableService<TFormDetailQueryEntity>, IQueryableService<TFormPageDetailQueryEntity>, IQueryableService<TSkipFormQuestionQueryEntity>) Constructor

Initializes a new instance of the [FormSubmissionIndexAppService&lt;TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>') class.

```csharp
public FormSubmissionIndexAppService(System.IServiceProvider? serviceProvider, CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey> formPageService, CloudyWing.FormModule.Domain.IQueryableService<TFormDetailQueryEntity> formDetailQueryService, CloudyWing.FormModule.Domain.IQueryableService<TFormPageDetailQueryEntity> formPageDetailQueryService, CloudyWing.FormModule.Domain.IQueryableService<TSkipFormQuestionQueryEntity> skipFormQuestionQueryService);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.FormSubmissionIndexAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_,CloudyWing.FormModule.Domain.IQueryableService_TFormDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TFormPageDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TSkipFormQuestionQueryEntity_).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.FormSubmissionIndexAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_,CloudyWing.FormModule.Domain.IQueryableService_TFormDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TFormPageDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TSkipFormQuestionQueryEntity_).formPageService'></a>

`formPageService` [CloudyWing.FormModule.Domain.FormPageModel.IFormPageService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPageEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPageEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TFormPageEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPageWithDetailsEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPageWithDetailsEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TFormPageWithDetailsEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPageDetailEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPageDetailEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TFormPageDetailEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPage](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPage 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TFormPage')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')

The form page service.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.FormSubmissionIndexAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_,CloudyWing.FormModule.Domain.IQueryableService_TFormDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TFormPageDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TSkipFormQuestionQueryEntity_).formDetailQueryService'></a>

`formDetailQueryService` [CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TFormDetailQueryEntity](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormDetailQueryEntity 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TFormDetailQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')

The form detail query service.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.FormSubmissionIndexAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_,CloudyWing.FormModule.Domain.IQueryableService_TFormDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TFormPageDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TSkipFormQuestionQueryEntity_).formPageDetailQueryService'></a>

`formPageDetailQueryService` [CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TFormPageDetailQueryEntity](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPageDetailQueryEntity 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TFormPageDetailQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')

The form page detail query service.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.FormSubmissionIndexAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_,CloudyWing.FormModule.Domain.IQueryableService_TFormDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TFormPageDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TSkipFormQuestionQueryEntity_).skipFormQuestionQueryService'></a>

`skipFormQuestionQueryService` [CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TSkipFormQuestionQueryEntity](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TSkipFormQuestionQueryEntity 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TSkipFormQuestionQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')

The skip form question query service.
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.FormDetailQueryService'></a>

## FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.FormDetailQueryService Property

Gets the form detail query service.

```csharp
protected CloudyWing.FormModule.Domain.IQueryableService<TFormDetailQueryEntity> FormDetailQueryService { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TFormDetailQueryEntity](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormDetailQueryEntity 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TFormDetailQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.FormPageDetailQueryService'></a>

## FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.FormPageDetailQueryService Property

Gets the form page detail query service.

```csharp
protected CloudyWing.FormModule.Domain.IQueryableService<TFormPageDetailQueryEntity> FormPageDetailQueryService { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TFormPageDetailQueryEntity](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPageDetailQueryEntity 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TFormPageDetailQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.FormPageService'></a>

## FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.FormPageService Property

Gets the form page service.

```csharp
protected CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey> FormPageService { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.FormPageModel.IFormPageService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPageEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPageEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TFormPageEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPageWithDetailsEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPageWithDetailsEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TFormPageWithDetailsEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPageDetailEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPageDetailEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TFormPageDetailEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPage](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TFormPage 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TFormPage')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.SkipFormQuestionQueryService'></a>

## FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.SkipFormQuestionQueryService Property

Gets the skip form question query service.

```csharp
protected CloudyWing.FormModule.Domain.IQueryableService<TSkipFormQuestionQueryEntity> SkipFormQuestionQueryService { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TSkipFormQuestionQueryEntity](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TSkipFormQuestionQueryEntity 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TSkipFormQuestionQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.GetInputAsync(string,string)'></a>

## FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.GetInputAsync(string, string) Method

Gets the input model based on the form ID and security code.

```csharp
public virtual System.Threading.Tasks.Task<TIndexInputModel> GetInputAsync(string? formId, string? securityCode);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.GetInputAsync(string,string).formId'></a>

`formId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.GetInputAsync(string,string).securityCode'></a>

`securityCode` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The security code of the form page.

Implements [GetInputAsync(string, string)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.GetInputAsync(string,string) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.GetInputAsync(string, string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TIndexInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexInputModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.GetViewAsync(string)'></a>

## FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.GetViewAsync(string) Method

Gets the index view based on the code.

```csharp
public virtual System.Threading.Tasks.Task<TIndexViewModel> GetViewAsync(string? code);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.GetViewAsync(string).code'></a>

`code` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The code to retrieve the view.

Implements [GetViewAsync(string)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.GetViewAsync(string) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.GetViewAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TIndexViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The index view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.GetViewByFormIdAsync(string)'></a>

## FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.GetViewByFormIdAsync(string) Method

Gets the index view based on the form ID.

```csharp
public virtual System.Threading.Tasks.Task<TIndexViewModel> GetViewByFormIdAsync(string? formId);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.GetViewByFormIdAsync(string).formId'></a>

`formId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Implements [GetViewByFormIdAsync(string)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.GetViewByFormIdAsync(string) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.GetViewByFormIdAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TIndexViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The index view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.UpsertAsync(TIndexInputModel,System.Collections.Generic.IEnumerable_TIndexSkipViewModel_)'></a>

## FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.UpsertAsync(TIndexInputModel, IEnumerable<TIndexSkipViewModel>) Method

Upserts the form submission.

```csharp
public virtual System.Threading.Tasks.Task<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<string>> UpsertAsync(TIndexInputModel? input, System.Collections.Generic.IEnumerable<TIndexSkipViewModel> skipSettings);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.UpsertAsync(TIndexInputModel,System.Collections.Generic.IEnumerable_TIndexSkipViewModel_).input'></a>

`input` [TIndexInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexInputModel')

The input model containing the form submission data.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.UpsertAsync(TIndexInputModel,System.Collections.Generic.IEnumerable_TIndexSkipViewModel_).skipSettings'></a>

`skipSettings` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TIndexSkipViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexSkipViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexSkipViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection of pass settings for the form submission.

Implements [UpsertAsync(TIndexInputModel, IEnumerable&lt;TIndexSkipViewModel&gt;)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.UpsertAsync(TIndexInputModel,System.Collections.Generic.IEnumerable_TIndexSkipViewModel_) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.UpsertAsync(TIndexInputModel, System.Collections.Generic.IEnumerable<TIndexSkipViewModel>)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<T>')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The result is an ApplicationResult containing a string.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.VerifyInputAsync(TIndexInputModel,TIndexViewModel,Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary)'></a>

## FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.VerifyInputAsync(TIndexInputModel, TIndexViewModel, ModelStateDictionary) Method

Verifies the input model.

```csharp
public virtual System.Threading.Tasks.Task<bool> VerifyInputAsync(TIndexInputModel? inputModel, TIndexViewModel? viewModel, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary? modelState);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.VerifyInputAsync(TIndexInputModel,TIndexViewModel,Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary).inputModel'></a>

`inputModel` [TIndexInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexInputModel')

The input model to verify.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.VerifyInputAsync(TIndexInputModel,TIndexViewModel,Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary).viewModel'></a>

`viewModel` [TIndexViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.TIndexViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>.TIndexViewModel')

The view model for comparison.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_.VerifyInputAsync(TIndexInputModel,TIndexViewModel,Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary).modelState'></a>

`modelState` [Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary 'Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary')

The model state dictionary to store errors.

Implements [VerifyInputAsync(TIndexInputModel, TIndexViewModel, ModelStateDictionary)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.VerifyInputAsync(TIndexInputModel,TIndexViewModel,Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.VerifyInputAsync(TIndexInputModel, TIndexViewModel, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A boolean indicating whether the input is valid.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceInputModel'></a>

## IndexChoiceInputModel Class

Represents the input model for an index choice.

```csharp
public class IndexChoiceInputModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IndexChoiceInputModel
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceInputModel.IsChecked'></a>

## IndexChoiceInputModel.IsChecked Property

Gets or sets a value indicating whether the choice is checked.

```csharp
public bool IsChecked { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceInputModel.QuestionChoiceId'></a>

## IndexChoiceInputModel.QuestionChoiceId Property

Gets or sets the ID of the question choice.

```csharp
public string? QuestionChoiceId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceInputModel.Response'></a>

## IndexChoiceInputModel.Response Property

Gets or sets the response.

```csharp
public string? Response { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceViewModel'></a>

## IndexChoiceViewModel Class

Represents the view model for an index choice.

```csharp
public class IndexChoiceViewModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IndexChoiceViewModel
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceViewModel.HasText'></a>

## IndexChoiceViewModel.HasText Property

Gets or sets a value indicating whether the choice has text.

```csharp
public bool HasText { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceViewModel.Id'></a>

## IndexChoiceViewModel.Id Property

Gets or sets the ID of the choice.

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceViewModel.Label'></a>

## IndexChoiceViewModel.Label Property

Gets or sets the label of the choice.

```csharp
public string Label { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexInputModel_TIndexQuestionInputModel,TIndexChoiceInputModel_'></a>

## IndexInputModel<TIndexQuestionInputModel,TIndexChoiceInputModel> Class

Represents the input model for an index.

```csharp
public class IndexInputModel<TIndexQuestionInputModel,TIndexChoiceInputModel>
    where TIndexQuestionInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionInputModel<TIndexChoiceInputModel>, new()
    where TIndexChoiceInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceInputModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexInputModel_TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexQuestionInputModel'></a>

`TIndexQuestionInputModel`

The type of the index question input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexInputModel_TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexChoiceInputModel'></a>

`TIndexChoiceInputModel`

The type of the index choice input model.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IndexInputModel<TIndexQuestionInputModel,TIndexChoiceInputModel>
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexInputModel_TIndexQuestionInputModel,TIndexChoiceInputModel_.FormId'></a>

## IndexInputModel<TIndexQuestionInputModel,TIndexChoiceInputModel>.FormId Property

Gets or sets the ID of the form.

```csharp
public string FormId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexInputModel_TIndexQuestionInputModel,TIndexChoiceInputModel_.FormPageId'></a>

## IndexInputModel<TIndexQuestionInputModel,TIndexChoiceInputModel>.FormPageId Property

Gets or sets the ID of the form page.

```csharp
public string? FormPageId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexInputModel_TIndexQuestionInputModel,TIndexChoiceInputModel_.Questions'></a>

## IndexInputModel<TIndexQuestionInputModel,TIndexChoiceInputModel>.Questions Property

Gets or sets the list of index question input models.

```csharp
public System.Collections.Generic.List<TIndexQuestionInputModel> Questions { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TIndexQuestionInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexInputModel_TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexQuestionInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexInputModel<TIndexQuestionInputModel,TIndexChoiceInputModel>.TIndexQuestionInputModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexInputModel_TIndexQuestionInputModel,TIndexChoiceInputModel_.SecurityCode'></a>

## IndexInputModel<TIndexQuestionInputModel,TIndexChoiceInputModel>.SecurityCode Property

Gets or sets the security code.

```csharp
public string? SecurityCode { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionInputModel_TIndexChoiceInputModel_'></a>

## IndexQuestionInputModel<TIndexChoiceInputModel> Class

Represents the input model for an index question.

```csharp
public class IndexQuestionInputModel<TIndexChoiceInputModel>
    where TIndexChoiceInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceInputModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionInputModel_TIndexChoiceInputModel_.TIndexChoiceInputModel'></a>

`TIndexChoiceInputModel`

The type of the index choice input model.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IndexQuestionInputModel<TIndexChoiceInputModel>
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionInputModel_TIndexChoiceInputModel_.Choices'></a>

## IndexQuestionInputModel<TIndexChoiceInputModel>.Choices Property

Gets or sets the list of index choice input models.

```csharp
public System.Collections.Generic.List<TIndexChoiceInputModel> Choices { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TIndexChoiceInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionInputModel_TIndexChoiceInputModel_.TIndexChoiceInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionInputModel<TIndexChoiceInputModel>.TIndexChoiceInputModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionInputModel_TIndexChoiceInputModel_.FormQuestionId'></a>

## IndexQuestionInputModel<TIndexChoiceInputModel>.FormQuestionId Property

Gets or sets the ID of the form question.

```csharp
public string FormQuestionId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionInputModel_TIndexChoiceInputModel_.Response'></a>

## IndexQuestionInputModel<TIndexChoiceInputModel>.Response Property

Gets or sets the response.

```csharp
public string? Response { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionViewModel_TIndexChoiceViewModel_'></a>

## IndexQuestionViewModel<TIndexChoiceViewModel> Class

Represents the view model for an index question.

```csharp
public class IndexQuestionViewModel<TIndexChoiceViewModel>
    where TIndexChoiceViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceViewModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionViewModel_TIndexChoiceViewModel_.TIndexChoiceViewModel'></a>

`TIndexChoiceViewModel`

The type of the index choice view model.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IndexQuestionViewModel<TIndexChoiceViewModel>
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionViewModel_TIndexChoiceViewModel_.Choices'></a>

## IndexQuestionViewModel<TIndexChoiceViewModel>.Choices Property

Gets or sets the list of choice view models for the question.

```csharp
public System.Collections.Generic.List<TIndexChoiceViewModel> Choices { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TIndexChoiceViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionViewModel_TIndexChoiceViewModel_.TIndexChoiceViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionViewModel<TIndexChoiceViewModel>.TIndexChoiceViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionViewModel_TIndexChoiceViewModel_.Id'></a>

## IndexQuestionViewModel<TIndexChoiceViewModel>.Id Property

Gets or sets the ID of the question.

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionViewModel_TIndexChoiceViewModel_.IsRequired'></a>

## IndexQuestionViewModel<TIndexChoiceViewModel>.IsRequired Property

Gets or sets a value indicating whether the question is required.

```csharp
public bool IsRequired { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionViewModel_TIndexChoiceViewModel_.QuestionText'></a>

## IndexQuestionViewModel<TIndexChoiceViewModel>.QuestionText Property

Gets or sets the question text.

```csharp
public string QuestionText { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionViewModel_TIndexChoiceViewModel_.QuestionType'></a>

## IndexQuestionViewModel<TIndexChoiceViewModel>.QuestionType Property

Gets or sets the type of the question.

```csharp
public CloudyWing.FormModule.EntityFrameworkCore.QuestionType? QuestionType { get; set; }
```

#### Property Value
[CloudyWing.FormModule.EntityFrameworkCore.QuestionType](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.EntityFrameworkCore.QuestionType 'CloudyWing.FormModule.EntityFrameworkCore.QuestionType')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSectionViewModel_TIndexQuestionViewModel,TIndexChoiceViewModel_'></a>

## IndexSectionViewModel<TIndexQuestionViewModel,TIndexChoiceViewModel> Class

Represents the view model for an index section.

```csharp
public class IndexSectionViewModel<TIndexQuestionViewModel,TIndexChoiceViewModel>
    where TIndexQuestionViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionViewModel<TIndexChoiceViewModel>, new()
    where TIndexChoiceViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceViewModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSectionViewModel_TIndexQuestionViewModel,TIndexChoiceViewModel_.TIndexQuestionViewModel'></a>

`TIndexQuestionViewModel`

The type of the index question view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSectionViewModel_TIndexQuestionViewModel,TIndexChoiceViewModel_.TIndexChoiceViewModel'></a>

`TIndexChoiceViewModel`

The type of the index choice view model.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IndexSectionViewModel<TIndexQuestionViewModel,TIndexChoiceViewModel>
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSectionViewModel_TIndexQuestionViewModel,TIndexChoiceViewModel_.Id'></a>

## IndexSectionViewModel<TIndexQuestionViewModel,TIndexChoiceViewModel>.Id Property

Gets or sets the ID of the section.

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSectionViewModel_TIndexQuestionViewModel,TIndexChoiceViewModel_.Name'></a>

## IndexSectionViewModel<TIndexQuestionViewModel,TIndexChoiceViewModel>.Name Property

Gets or sets the name of the section.

```csharp
public string Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSectionViewModel_TIndexQuestionViewModel,TIndexChoiceViewModel_.Questions'></a>

## IndexSectionViewModel<TIndexQuestionViewModel,TIndexChoiceViewModel>.Questions Property

Gets or sets the list of question view models in the section.

```csharp
public System.Collections.Generic.List<TIndexQuestionViewModel> Questions { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TIndexQuestionViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSectionViewModel_TIndexQuestionViewModel,TIndexChoiceViewModel_.TIndexQuestionViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSectionViewModel<TIndexQuestionViewModel,TIndexChoiceViewModel>.TIndexQuestionViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSkipViewModel'></a>

## IndexSkipViewModel Class

Represents the skip view model for an index.

```csharp
public class IndexSkipViewModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IndexSkipViewModel
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSkipViewModel.FormQuestionId'></a>

## IndexSkipViewModel.FormQuestionId Property

Gets or sets the ID of the form question.

```csharp
public string? FormQuestionId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSkipViewModel.QuestionChoiceId'></a>

## IndexSkipViewModel.QuestionChoiceId Property

Gets or sets the ID of the question choice.

```csharp
public string? QuestionChoiceId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSkipViewModel.SkipQuestionId'></a>

## IndexSkipViewModel.SkipQuestionId Property

Gets or sets the ID of the skip question.

```csharp
public string? SkipQuestionId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_'></a>

## IndexViewModel<TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel> Class

Represents the view model for the index page.

```csharp
public class IndexViewModel<TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel>
    where TIndexSectionViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSectionViewModel<TIndexQuestionViewModel, TIndexChoiceViewModel>, new()
    where TIndexQuestionViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionViewModel<TIndexChoiceViewModel>, new()
    where TIndexChoiceViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceViewModel, new()
    where TIndexSkipViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSkipViewModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.TIndexSectionViewModel'></a>

`TIndexSectionViewModel`

The type of the index section view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.TIndexQuestionViewModel'></a>

`TIndexQuestionViewModel`

The type of the index question view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.TIndexChoiceViewModel'></a>

`TIndexChoiceViewModel`

The type of the index choice view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.TIndexSkipViewModel'></a>

`TIndexSkipViewModel`

The type of the index skip view model.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IndexViewModel<TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel>
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.CanUpdate'></a>

## IndexViewModel<TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel>.CanUpdate Property

Gets or sets a value indicating whether the form can be updated.

```csharp
public bool CanUpdate { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.Footer'></a>

## IndexViewModel<TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel>.Footer Property

Gets or sets the footer of the form.

```csharp
public string? Footer { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.FormId'></a>

## IndexViewModel<TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel>.FormId Property

Gets or sets the ID of the form.

```csharp
public string? FormId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.Header'></a>

## IndexViewModel<TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel>.Header Property

Gets or sets the header of the form.

```csharp
public string? Header { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.IsInternal'></a>

## IndexViewModel<TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel>.IsInternal Property

Gets or sets a value indicating whether the form is internal.

```csharp
public bool IsInternal { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.Name'></a>

## IndexViewModel<TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel>.Name Property

Gets or sets the name of the form.

```csharp
public string? Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.Role'></a>

## IndexViewModel<TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel>.Role Property

Gets or sets the role of the form.

```csharp
public string? Role { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.Sections'></a>

## IndexViewModel<TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel>.Sections Property

Gets or sets the list of section view models in the index.

```csharp
public System.Collections.Generic.List<TIndexSectionViewModel> Sections { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TIndexSectionViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.TIndexSectionViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel<TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel>.TIndexSectionViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.SkipSettings'></a>

## IndexViewModel<TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel>.SkipSettings Property

Gets or sets the list of skip view models in the index.

```csharp
public System.Collections.Generic.List<TIndexSkipViewModel> SkipSettings { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TIndexSkipViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel_TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel_.TIndexSkipViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel<TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel>.TIndexSkipViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')
### Interfaces

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionCompletionAppService_TCompletionViewModel_'></a>

## IFormSubmissionCompletionAppService<TCompletionViewModel> Interface

Represents an interface for a form submission completion application service.

```csharp
public interface IFormSubmissionCompletionAppService<TCompletionViewModel>
    where TCompletionViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.CompletionViewModel
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionCompletionAppService_TCompletionViewModel_.TCompletionViewModel'></a>

`TCompletionViewModel`

The type of the completion view model.

Derived  
&#8627; [FormSubmissionCompletionAppService&lt;TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService<TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey>')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionCompletionAppService_TCompletionViewModel_.GetViewAsync(string)'></a>

## IFormSubmissionCompletionAppService<TCompletionViewModel>.GetViewAsync(string) Method

Gets the index view based on the form ID.

```csharp
System.Threading.Tasks.Task<TCompletionViewModel> GetViewAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionCompletionAppService_TCompletionViewModel_.GetViewAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the view model to retrieve.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TCompletionViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionCompletionAppService_TCompletionViewModel_.TCompletionViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionCompletionAppService<TCompletionViewModel>.TCompletionViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The completion index view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_'></a>

## IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel> Interface

Represents an interface for the Form Submission Index application service.

```csharp
public interface IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>
    where TIndexViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexViewModel<TIndexSectionViewModel, TIndexQuestionViewModel, TIndexChoiceViewModel, TIndexSkipViewModel>, new()
    where TIndexSectionViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSectionViewModel<TIndexQuestionViewModel, TIndexChoiceViewModel>, new()
    where TIndexQuestionViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionViewModel<TIndexChoiceViewModel>, new()
    where TIndexChoiceViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceViewModel, new()
    where TIndexSkipViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexSkipViewModel, new()
    where TIndexInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexInputModel<TIndexQuestionInputModel, TIndexChoiceInputModel>, new()
    where TIndexQuestionInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexQuestionInputModel<TIndexChoiceInputModel>, new()
    where TIndexChoiceInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IndexChoiceInputModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexViewModel'></a>

`TIndexViewModel`

The type of the index view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexSectionViewModel'></a>

`TIndexSectionViewModel`

The type of the index section view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexQuestionViewModel'></a>

`TIndexQuestionViewModel`

The type of the index question view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexChoiceViewModel'></a>

`TIndexChoiceViewModel`

The type of the index choice view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexSkipViewModel'></a>

`TIndexSkipViewModel`

The type of the index skip view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexInputModel'></a>

`TIndexInputModel`

The type of the index input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexQuestionInputModel'></a>

`TIndexQuestionInputModel`

The type of the index question input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexChoiceInputModel'></a>

`TIndexChoiceInputModel`

The type of the index choice input model.

Derived  
&#8627; [FormSubmissionIndexAppService&lt;TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.GetInputAsync(string,string)'></a>

## IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.GetInputAsync(string, string) Method

Gets the input model based on the form ID and security code.

```csharp
System.Threading.Tasks.Task<TIndexInputModel> GetInputAsync(string? formId, string? securityCode);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.GetInputAsync(string,string).formId'></a>

`formId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.GetInputAsync(string,string).securityCode'></a>

`securityCode` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The security code of the form page.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TIndexInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.TIndexInputModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.GetViewAsync(string)'></a>

## IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.GetViewAsync(string) Method

Gets the index view based on the code.

```csharp
System.Threading.Tasks.Task<TIndexViewModel> GetViewAsync(string? code);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.GetViewAsync(string).code'></a>

`code` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The code to retrieve the view.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TIndexViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.TIndexViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The index view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.GetViewByFormIdAsync(string)'></a>

## IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.GetViewByFormIdAsync(string) Method

Gets the index view based on the form ID.

```csharp
System.Threading.Tasks.Task<TIndexViewModel> GetViewByFormIdAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.GetViewByFormIdAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TIndexViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.TIndexViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The index view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.UpsertAsync(TIndexInputModel,System.Collections.Generic.IEnumerable_TIndexSkipViewModel_)'></a>

## IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.UpsertAsync(TIndexInputModel, IEnumerable<TIndexSkipViewModel>) Method

Upserts the form submission.

```csharp
System.Threading.Tasks.Task<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<string>> UpsertAsync(TIndexInputModel? input, System.Collections.Generic.IEnumerable<TIndexSkipViewModel> skipSettings);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.UpsertAsync(TIndexInputModel,System.Collections.Generic.IEnumerable_TIndexSkipViewModel_).input'></a>

`input` [TIndexInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.TIndexInputModel')

The input model containing the form submission data.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.UpsertAsync(TIndexInputModel,System.Collections.Generic.IEnumerable_TIndexSkipViewModel_).skipSettings'></a>

`skipSettings` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TIndexSkipViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexSkipViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.TIndexSkipViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection of pass settings for the form submission.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<T>')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The result is an ApplicationResult containing a string.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.VerifyInputAsync(TIndexInputModel,TIndexViewModel,Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary)'></a>

## IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.VerifyInputAsync(TIndexInputModel, TIndexViewModel, ModelStateDictionary) Method

Verifies the input model.

```csharp
System.Threading.Tasks.Task<bool> VerifyInputAsync(TIndexInputModel? inputModel, TIndexViewModel? viewModel, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary? modelState);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.VerifyInputAsync(TIndexInputModel,TIndexViewModel,Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary).inputModel'></a>

`inputModel` [TIndexInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.TIndexInputModel')

The input model to verify.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.VerifyInputAsync(TIndexInputModel,TIndexViewModel,Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary).viewModel'></a>

`viewModel` [TIndexViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.TIndexViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel>.TIndexViewModel')

The view model for comparison.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.IFormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel_.VerifyInputAsync(TIndexInputModel,TIndexViewModel,Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary).modelState'></a>

`modelState` [Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary 'Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary')

The model state dictionary to store errors.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A boolean indicating whether the input is valid.