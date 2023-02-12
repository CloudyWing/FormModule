#### [CloudyWing.FormModule.Domain](index.md 'index')
### [CloudyWing.FormModule.Domain](CloudyWing.FormModule.Domain.md 'CloudyWing.FormModule.Domain')

## IQueryableService<TEntity> Interface

Represents a service for querying entities of type [TEntity](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_.TEntity 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>.TEntity').

```csharp
public interface IQueryableService<out TEntity>
    where TEntity : class
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.IQueryableService_TEntity_.TEntity'></a>

`TEntity`

The type of the entities.

Derived  
&#8627; [FormDetailQueryService&lt;TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_ 'CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService<TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>')  
&#8627; [FormQuestionQueryService&lt;TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_ 'CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService<TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey>')  
&#8627; [FormService&lt;TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>')  
&#8627; [IFormService&lt;TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey&gt;](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>')  
&#8627; [FormPageDetailQueryService&lt;TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey&gt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_ 'CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService<TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey>')  
&#8627; [FormPageQueryService&lt;TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey&gt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_ 'CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService<TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey>')  
&#8627; [FormPageService&lt;TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>')  
&#8627; [IFormPageService&lt;TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey&gt;](CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.md 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>')  
&#8627; [ISkipFormQuestionService&lt;TSkipFormQuestionEditor,TSkipFormQuestion,TKey&gt;](CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.md 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>')  
&#8627; [SkipFormQuestionQueryService&lt;TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey&gt;](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_ 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService<TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>')  
&#8627; [SkipFormQuestionService&lt;TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>')
### Properties

<a name='CloudyWing.FormModule.Domain.IQueryableService_TEntity_.DataSource'></a>

## IQueryableService<TEntity>.DataSource Property

Gets the data source for querying entities.

```csharp
System.Linq.IQueryable<TEntity> DataSource { get; }
```

#### Property Value
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TEntity](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_.TEntity 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')

<a name='CloudyWing.FormModule.Domain.IQueryableService_TEntity_.Logger'></a>

## IQueryableService<TEntity>.Logger Property

Gets the logger associated with the service.

```csharp
Microsoft.Extensions.Logging.ILogger Logger { get; }
```

#### Property Value
[Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')