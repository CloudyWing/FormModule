#### [CloudyWing.FormModule.Domain](index.md 'index')

## CloudyWing.FormModule.Domain Namespace
### Classes

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_'></a>

## DomainService<TDbContext,TKey,TUserKey> Class

Abstract basic class for domain services.

```csharp
public abstract class DomainService<TDbContext,TKey,TUserKey> : CloudyWing.FormModule.Domain.DomainService<TDbContext>
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
    where TUserKey : System.IEquatable<TUserKey>
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.TKey'></a>

`TKey`

The type of the key.

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.TUserKey'></a>

`TUserKey`

The type of the user key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [CloudyWing.FormModule.Domain.DomainService&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>')[TDbContext](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.TDbContext 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>.TDbContext')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>') &#129106; DomainService<TDbContext,TKey,TUserKey>

Derived  
&#8627; [FormService&lt;TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>')  
&#8627; [FormPageService&lt;TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.FormPageModel.FormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormPage,TFormPageDetail,TKey,TUserKey>')  
&#8627; [SkipFormQuestionService&lt;TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>')
### Constructors

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.DomainService(TDbContext,System.IServiceProvider)'></a>

## DomainService(TDbContext, IServiceProvider) Constructor

Initializes a new instance of the [DomainService&lt;TDbContext,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>') class.

```csharp
protected DomainService(TDbContext? dbContext, System.IServiceProvider? serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.DomainService(TDbContext,System.IServiceProvider).dbContext'></a>

`dbContext` [TDbContext](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.TDbContext 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>.TDbContext')

The database context.

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.DomainService(TDbContext,System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.
### Properties

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.IdConverter'></a>

## DomainService<TDbContext,TKey,TUserKey>.IdConverter Property

Gets the ID converter.

```csharp
protected CloudyWing.FormModule.Domain.IIdConverter<TKey> IdConverter { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.IIdConverter&lt;](CloudyWing.FormModule.Domain.IIdConverter_TKey_.md 'CloudyWing.FormModule.Domain.IIdConverter<TKey>')[TKey](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.TKey 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>.TKey')[&gt;](CloudyWing.FormModule.Domain.IIdConverter_TKey_.md 'CloudyWing.FormModule.Domain.IIdConverter<TKey>')

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.Mapper'></a>

## DomainService<TDbContext,TKey,TUserKey>.Mapper Property

Gets the form module mapper.

```csharp
protected CloudyWing.FormModule.Domain.IFormModuleMapper Mapper { get; }
```

#### Property Value
[IFormModuleMapper](CloudyWing.FormModule.Domain.IFormModuleMapper.md 'CloudyWing.FormModule.Domain.IFormModuleMapper')

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UserIdConverter'></a>

## DomainService<TDbContext,TKey,TUserKey>.UserIdConverter Property

Gets the user ID converter.

```csharp
protected CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey> UserIdConverter { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.IUserIdConverter&lt;](CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.md 'CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey>')[TUserKey](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.TUserKey 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>.TUserKey')[&gt;](CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.md 'CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey>')
### Methods

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.SaveChangesAsync()'></a>

## DomainService<TDbContext,TKey,TUserKey>.SaveChangesAsync() Method

Saves changes.

```csharp
protected System.Threading.Tasks.Task<bool> SaveChangesAsync();
```

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task representing the asynchronous operation. The task result indicates whether the save operation was successful.

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UseTransactionAsync(System.Func_Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction,System.Threading.Tasks.Task_)'></a>

## DomainService<TDbContext,TKey,TUserKey>.UseTransactionAsync(Func<IDbContextTransaction,Task>) Method

Executes a transaction asynchronously for the specified action with access to the transaction object.

```csharp
protected System.Threading.Tasks.Task UseTransactionAsync(System.Func<Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction,System.Threading.Tasks.Task> transactionAction);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UseTransactionAsync(System.Func_Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction,System.Threading.Tasks.Task_).transactionAction'></a>

`transactionAction` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction 'Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The transaction action to execute.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UseTransactionAsync(System.Func_System.Threading.Tasks.Task_)'></a>

## DomainService<TDbContext,TKey,TUserKey>.UseTransactionAsync(Func<Task>) Method

Executes a transaction asynchronously for the specified action.

```csharp
protected System.Threading.Tasks.Task UseTransactionAsync(System.Func<System.Threading.Tasks.Task> transactionAction);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UseTransactionAsync(System.Func_System.Threading.Tasks.Task_).transactionAction'></a>

`transactionAction` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The transaction action to execute.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UseTransactionAsync_T_(System.Func_Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction,System.Threading.Tasks.Task_T__)'></a>

## DomainService<TDbContext,TKey,TUserKey>.UseTransactionAsync<T>(Func<IDbContextTransaction,Task<T>>) Method

Executes a transaction asynchronously for the specified function with access to the transaction object and returns the result.

```csharp
protected System.Threading.Tasks.Task<T> UseTransactionAsync<T>(System.Func<Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction,System.Threading.Tasks.Task<T>> transactionAction);
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UseTransactionAsync_T_(System.Func_Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction,System.Threading.Tasks.Task_T__).T'></a>

`T`

The type of the result.
#### Parameters

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UseTransactionAsync_T_(System.Func_Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction,System.Threading.Tasks.Task_T__).transactionAction'></a>

`transactionAction` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction 'Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UseTransactionAsync_T_(System.Func_Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction,System.Threading.Tasks.Task_T__).T 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>.UseTransactionAsync<T>(System.Func<Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction,System.Threading.Tasks.Task<T>>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The transaction function to execute.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UseTransactionAsync_T_(System.Func_Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction,System.Threading.Tasks.Task_T__).T 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>.UseTransactionAsync<T>(System.Func<Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction,System.Threading.Tasks.Task<T>>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task representing the asynchronous operation. The task result contains the result of the transaction function.

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UseTransactionAsync_T_(System.Func_System.Threading.Tasks.Task_T__)'></a>

## DomainService<TDbContext,TKey,TUserKey>.UseTransactionAsync<T>(Func<Task<T>>) Method

Executes a transaction asynchronously for the specified function and returns the result.

```csharp
protected System.Threading.Tasks.Task<T> UseTransactionAsync<T>(System.Func<System.Threading.Tasks.Task<T>> transactionAction);
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UseTransactionAsync_T_(System.Func_System.Threading.Tasks.Task_T__).T'></a>

`T`

The type of the result.
#### Parameters

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UseTransactionAsync_T_(System.Func_System.Threading.Tasks.Task_T__).transactionAction'></a>

`transactionAction` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UseTransactionAsync_T_(System.Func_System.Threading.Tasks.Task_T__).T 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>.UseTransactionAsync<T>(System.Func<System.Threading.Tasks.Task<T>>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The transaction function to execute.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_.UseTransactionAsync_T_(System.Func_System.Threading.Tasks.Task_T__).T 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>.UseTransactionAsync<T>(System.Func<System.Threading.Tasks.Task<T>>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task representing the asynchronous operation. The task result contains the result of the transaction function.

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext_'></a>

## DomainService<TDbContext> Class

Abstract basic class for domain services.

```csharp
public abstract class DomainService<TDbContext> : CloudyWing.FormModule.Infrastructure.InfrastructureBase
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext_.TDbContext'></a>

`TDbContext`

The type of the database context.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; DomainService<TDbContext>

Derived  
&#8627; [DomainService&lt;TDbContext,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext,TKey,TUserKey>')  
&#8627; [FormDetailQueryService&lt;TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService_TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_ 'CloudyWing.FormModule.Domain.FormModel.FormDetailQueryService<TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>')  
&#8627; [FormQuestionQueryService&lt;TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService_TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey_ 'CloudyWing.FormModule.Domain.FormModel.FormQuestionQueryService<TDbContext,TFormQuestionQueryEntity,TFormQuestion,TFormSection,TForm,TKey>')  
&#8627; [FormPageDetailQueryService&lt;TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey&gt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService_TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey_ 'CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryService<TDbContext,TFormPageDetailQueryEntity,TFormPageDetail,TFormPage,TForm,TKey>')  
&#8627; [FormPageQueryService&lt;TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey&gt;](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService_TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey_ 'CloudyWing.FormModule.Domain.FormPageModel.FormPageQueryService<TDbContext,TFormPageQueryEntity,TFormPage,TForm,TKey>')  
&#8627; [SkipFormQuestionQueryService&lt;TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey&gt;](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService_TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_ 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionQueryService<TDbContext,TSkipFormQuestionQueryEntity,TSkipFormQuestion,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>')
### Constructors

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext_.DomainService(TDbContext,System.IServiceProvider)'></a>

## DomainService(TDbContext, IServiceProvider) Constructor

Initializes a new instance of the [DomainService&lt;TDbContext&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_ 'CloudyWing.FormModule.Domain.DomainService<TDbContext>') class.

```csharp
protected DomainService(TDbContext? dbContext, System.IServiceProvider? serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext_.DomainService(TDbContext,System.IServiceProvider).dbContext'></a>

`dbContext` [TDbContext](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_.TDbContext 'CloudyWing.FormModule.Domain.DomainService<TDbContext>.TDbContext')

The database context.

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext_.DomainService(TDbContext,System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.
### Properties

<a name='CloudyWing.FormModule.Domain.DomainService_TDbContext_.DbContext'></a>

## DomainService<TDbContext>.DbContext Property

Gets the database context.

```csharp
protected internal TDbContext DbContext { get; }
```

#### Property Value
[TDbContext](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.DomainService_TDbContext_.TDbContext 'CloudyWing.FormModule.Domain.DomainService<TDbContext>.TDbContext')

<a name='CloudyWing.FormModule.Domain.EditorBase'></a>

## EditorBase Class

The editor is a DTO used for creating or updating.

```csharp
public abstract class EditorBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EditorBase

Derived  
&#8627; [FormEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormEditor 'CloudyWing.FormModule.Domain.FormModel.FormEditor')  
&#8627; [FormQuestionEditor&lt;TQuestionChoiceEditor&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor_TQuestionChoiceEditor_ 'CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor<TQuestionChoiceEditor>')  
&#8627; [FormSectionEditor&lt;TFormQuestionEditor,TQuestionChoiceEditor&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormSectionEditor_TFormQuestionEditor,TQuestionChoiceEditor_ 'CloudyWing.FormModule.Domain.FormModel.FormSectionEditor<TFormQuestionEditor,TQuestionChoiceEditor>')  
&#8627; [QuestionChoiceEditor](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor 'CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor')  
&#8627; [FormPageEditor](CloudyWing.FormModule.Domain.FormPageModel.md#CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor 'CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor')  
&#8627; [SkipFormQuestionEditor](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionEditor 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionEditor')
### Constructors

<a name='CloudyWing.FormModule.Domain.EditorBase.EditorBase()'></a>

## EditorBase() Constructor

Initializes a new instance of the [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase') class.

```csharp
protected EditorBase();
```

<a name='CloudyWing.FormModule.Domain.EditorBase.EditorBase(string)'></a>

## EditorBase(string) Constructor

Initializes a new instance of the [EditorBase](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EditorBase 'CloudyWing.FormModule.Domain.EditorBase') class.

```csharp
protected EditorBase(string id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.EditorBase.EditorBase(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The identifier.
### Properties

<a name='CloudyWing.FormModule.Domain.EditorBase.Id'></a>

## EditorBase.Id Property

Gets the primary key for editor.

```csharp
public string? Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Methods

<a name='CloudyWing.FormModule.Domain.EditorBase.SetId(string)'></a>

## EditorBase.SetId(string) Method

Sets the identifier.

```csharp
public void SetId(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.EditorBase.SetId(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The primary key.

<a name='CloudyWing.FormModule.Domain.EnumerableExtensions'></a>

## EnumerableExtensions Class

Provides extension methods for [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') objects.

```csharp
public static class EnumerableExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EnumerableExtensions
### Methods

<a name='CloudyWing.FormModule.Domain.EnumerableExtensions.ToPagedList_T_(thisSystem.Collections.Generic.IEnumerable_T_,CloudyWing.FormModule.Domain.PagingMetadata)'></a>

## EnumerableExtensions.ToPagedList<T>(this IEnumerable<T>, PagingMetadata) Method

Converts an [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to a paged list.

```csharp
public static CloudyWing.FormModule.Domain.IPagedList<T> ToPagedList<T>(this System.Collections.Generic.IEnumerable<T> enumerable, CloudyWing.FormModule.Domain.PagingMetadata metadata);
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.EnumerableExtensions.ToPagedList_T_(thisSystem.Collections.Generic.IEnumerable_T_,CloudyWing.FormModule.Domain.PagingMetadata).T'></a>

`T`

The type of the elements in the enumerable.
#### Parameters

<a name='CloudyWing.FormModule.Domain.EnumerableExtensions.ToPagedList_T_(thisSystem.Collections.Generic.IEnumerable_T_,CloudyWing.FormModule.Domain.PagingMetadata).enumerable'></a>

`enumerable` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EnumerableExtensions.ToPagedList_T_(thisSystem.Collections.Generic.IEnumerable_T_,CloudyWing.FormModule.Domain.PagingMetadata).T 'CloudyWing.FormModule.Domain.EnumerableExtensions.ToPagedList<T>(this System.Collections.Generic.IEnumerable<T>, CloudyWing.FormModule.Domain.PagingMetadata).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The enumerable to convert.

<a name='CloudyWing.FormModule.Domain.EnumerableExtensions.ToPagedList_T_(thisSystem.Collections.Generic.IEnumerable_T_,CloudyWing.FormModule.Domain.PagingMetadata).metadata'></a>

`metadata` [PagingMetadata](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagingMetadata 'CloudyWing.FormModule.Domain.PagingMetadata')

The paging metadata.

#### Returns
[CloudyWing.FormModule.Domain.IPagedList&lt;](CloudyWing.FormModule.Domain.IPagedList_T_.md 'CloudyWing.FormModule.Domain.IPagedList<T>')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.EnumerableExtensions.ToPagedList_T_(thisSystem.Collections.Generic.IEnumerable_T_,CloudyWing.FormModule.Domain.PagingMetadata).T 'CloudyWing.FormModule.Domain.EnumerableExtensions.ToPagedList<T>(this System.Collections.Generic.IEnumerable<T>, CloudyWing.FormModule.Domain.PagingMetadata).T')[&gt;](CloudyWing.FormModule.Domain.IPagedList_T_.md 'CloudyWing.FormModule.Domain.IPagedList<T>')  
A paged list containing the elements from the enumerable.

<a name='CloudyWing.FormModule.Domain.ExpressionExtensions'></a>

## ExpressionExtensions Class

Extension methods for combining expressions with logical "AND" and "OR" operators.

```csharp
public static class ExpressionExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ExpressionExtensions

### Remarks
The code is adapted from the LINQKit library, available at: https://github.com/scottksmith95/LINQKit/blob/master/src/LinqKit.Core/PredicateBuilder.cs.
### Methods

<a name='CloudyWing.FormModule.Domain.ExpressionExtensions.And_TEntity_(thisSystem.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__)'></a>

## ExpressionExtensions.And<TEntity>(this Expression<Func<TEntity,bool>>, Expression<Func<TEntity,bool>>) Method

Combines multiple expressions using the logical "AND" operator.

```csharp
public static System.Linq.Expressions.Expression<System.Func<TEntity,bool>> And<TEntity>(this System.Linq.Expressions.Expression<System.Func<TEntity,bool>> first, System.Linq.Expressions.Expression<System.Func<TEntity,bool>> second);
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.ExpressionExtensions.And_TEntity_(thisSystem.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity'></a>

`TEntity`

The entity type.
#### Parameters

<a name='CloudyWing.FormModule.Domain.ExpressionExtensions.And_TEntity_(thisSystem.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).first'></a>

`first` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ExpressionExtensions.And_TEntity_(thisSystem.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.ExpressionExtensions.And<TEntity>(this System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The first expression.

<a name='CloudyWing.FormModule.Domain.ExpressionExtensions.And_TEntity_(thisSystem.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).second'></a>

`second` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ExpressionExtensions.And_TEntity_(thisSystem.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.ExpressionExtensions.And<TEntity>(this System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The second expression.

#### Returns
[System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ExpressionExtensions.And_TEntity_(thisSystem.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.ExpressionExtensions.And<TEntity>(this System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')  
The combined expression.

<a name='CloudyWing.FormModule.Domain.ExpressionExtensions.Or_TEntity_(thisSystem.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__)'></a>

## ExpressionExtensions.Or<TEntity>(this Expression<Func<TEntity,bool>>, Expression<Func<TEntity,bool>>) Method

Combines multiple expressions using the logical "OR" operator.

```csharp
public static System.Linq.Expressions.Expression<System.Func<TEntity,bool>> Or<TEntity>(this System.Linq.Expressions.Expression<System.Func<TEntity,bool>> first, System.Linq.Expressions.Expression<System.Func<TEntity,bool>> second);
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.ExpressionExtensions.Or_TEntity_(thisSystem.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity'></a>

`TEntity`

The entity type.
#### Parameters

<a name='CloudyWing.FormModule.Domain.ExpressionExtensions.Or_TEntity_(thisSystem.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).first'></a>

`first` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ExpressionExtensions.Or_TEntity_(thisSystem.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.ExpressionExtensions.Or<TEntity>(this System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The first expression.

<a name='CloudyWing.FormModule.Domain.ExpressionExtensions.Or_TEntity_(thisSystem.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).second'></a>

`second` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ExpressionExtensions.Or_TEntity_(thisSystem.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.ExpressionExtensions.Or<TEntity>(this System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The second expression.

#### Returns
[System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ExpressionExtensions.Or_TEntity_(thisSystem.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.ExpressionExtensions.Or<TEntity>(this System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')  
The combined expression.

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_'></a>

## FormModuleMapper<TKey,TUserKey> Class

Provides mapping functionality between editor objects and entity objects for form modules.

```csharp
public class FormModuleMapper<TKey,TUserKey> :
CloudyWing.FormModule.Domain.IFormModuleMapper
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
    where TUserKey : System.IEquatable<TUserKey>
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.TKey'></a>

`TKey`

The type of the key used in the entity.

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.TUserKey'></a>

`TUserKey`

The type of the user key used in the entity.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormModuleMapper<TKey,TUserKey>

Implements [IFormModuleMapper](CloudyWing.FormModule.Domain.IFormModuleMapper.md 'CloudyWing.FormModule.Domain.IFormModuleMapper')
### Constructors

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.FormModuleMapper(CloudyWing.FormModule.Domain.IIdConverter_TKey_,CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_)'></a>

## FormModuleMapper(IIdConverter<TKey>, IUserIdConverter<TUserKey>) Constructor

Initializes a new instance of the [FormModuleMapper&lt;TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_ 'CloudyWing.FormModule.Domain.FormModuleMapper<TKey,TUserKey>') class.

```csharp
public FormModuleMapper(CloudyWing.FormModule.Domain.IIdConverter<TKey> idConverter, CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey> userIdConverter);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.FormModuleMapper(CloudyWing.FormModule.Domain.IIdConverter_TKey_,CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_).idConverter'></a>

`idConverter` [CloudyWing.FormModule.Domain.IIdConverter&lt;](CloudyWing.FormModule.Domain.IIdConverter_TKey_.md 'CloudyWing.FormModule.Domain.IIdConverter<TKey>')[TKey](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.TKey 'CloudyWing.FormModule.Domain.FormModuleMapper<TKey,TUserKey>.TKey')[&gt;](CloudyWing.FormModule.Domain.IIdConverter_TKey_.md 'CloudyWing.FormModule.Domain.IIdConverter<TKey>')

The ID converter.

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.FormModuleMapper(CloudyWing.FormModule.Domain.IIdConverter_TKey_,CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_).userIdConverter'></a>

`userIdConverter` [CloudyWing.FormModule.Domain.IUserIdConverter&lt;](CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.md 'CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey>')[TUserKey](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.TUserKey 'CloudyWing.FormModule.Domain.FormModuleMapper<TKey,TUserKey>.TUserKey')[&gt;](CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.md 'CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey>')

The user ID converter.
### Methods

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.Map_TEditor,TEntity_(TEditor)'></a>

## FormModuleMapper<TKey,TUserKey>.Map<TEditor,TEntity>(TEditor) Method

Maps properties from an editor object to a new instance of an entity object.

```csharp
public TEntity Map<TEditor,TEntity>(TEditor editor)
    where TEntity : new();
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.Map_TEditor,TEntity_(TEditor).TEditor'></a>

`TEditor`

The type of the editor object.

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.Map_TEditor,TEntity_(TEditor).TEntity'></a>

`TEntity`

The type of the entity object.
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.Map_TEditor,TEntity_(TEditor).editor'></a>

`editor` [TEditor](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.Map_TEditor,TEntity_(TEditor).TEditor 'CloudyWing.FormModule.Domain.FormModuleMapper<TKey,TUserKey>.Map<TEditor,TEntity>(TEditor).TEditor')

Implements [Map&lt;TEditor,TEntity&gt;(TEditor)](CloudyWing.FormModule.Domain.IFormModuleMapper.md#CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor) 'CloudyWing.FormModule.Domain.IFormModuleMapper.Map<TEditor,TEntity>(TEditor)')

#### Returns
[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.Map_TEditor,TEntity_(TEditor).TEntity 'CloudyWing.FormModule.Domain.FormModuleMapper<TKey,TUserKey>.Map<TEditor,TEntity>(TEditor).TEntity')  
A new instance of the mapped entity object.

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.Map_TEditor,TEntity_(TEditor,TEntity)'></a>

## FormModuleMapper<TKey,TUserKey>.Map<TEditor,TEntity>(TEditor, TEntity) Method

Maps properties from an editor object to an existing instance of an entity object.

```csharp
public void Map<TEditor,TEntity>(TEditor editor, TEntity entity)
    where TEntity : new();
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.Map_TEditor,TEntity_(TEditor,TEntity).TEditor'></a>

`TEditor`

The type of the editor object.

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.Map_TEditor,TEntity_(TEditor,TEntity).TEntity'></a>

`TEntity`

The type of the entity object.
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.Map_TEditor,TEntity_(TEditor,TEntity).editor'></a>

`editor` [TEditor](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.Map_TEditor,TEntity_(TEditor,TEntity).TEditor 'CloudyWing.FormModule.Domain.FormModuleMapper<TKey,TUserKey>.Map<TEditor,TEntity>(TEditor, TEntity).TEditor')

<a name='CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.Map_TEditor,TEntity_(TEditor,TEntity).entity'></a>

`entity` [TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_.Map_TEditor,TEntity_(TEditor,TEntity).TEntity 'CloudyWing.FormModule.Domain.FormModuleMapper<TKey,TUserKey>.Map<TEditor,TEntity>(TEditor, TEntity).TEntity')

Implements [Map&lt;TEditor,TEntity&gt;(TEditor, TEntity)](CloudyWing.FormModule.Domain.IFormModuleMapper.md#CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor,TEntity) 'CloudyWing.FormModule.Domain.IFormModuleMapper.Map<TEditor,TEntity>(TEditor, TEntity)')

<a name='CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_'></a>

## IdConverter<TKey,TUserKey> Class

Provides conversion functionality for IDs and user IDs.

```csharp
public class IdConverter<TKey,TUserKey> :
CloudyWing.FormModule.Domain.IIdConverter<TKey>,
CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey>
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
    where TUserKey : System.IEquatable<TUserKey>
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_.TKey'></a>

`TKey`

The type of the ID.

<a name='CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_.TUserKey'></a>

`TUserKey`

The type of the user ID.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IdConverter<TKey,TUserKey>

Implements [CloudyWing.FormModule.Domain.IIdConverter&lt;](CloudyWing.FormModule.Domain.IIdConverter_TKey_.md 'CloudyWing.FormModule.Domain.IIdConverter<TKey>')[TKey](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_.TKey 'CloudyWing.FormModule.Domain.IdConverter<TKey,TUserKey>.TKey')[&gt;](CloudyWing.FormModule.Domain.IIdConverter_TKey_.md 'CloudyWing.FormModule.Domain.IIdConverter<TKey>'), [CloudyWing.FormModule.Domain.IUserIdConverter&lt;](CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.md 'CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey>')[TUserKey](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_.TUserKey 'CloudyWing.FormModule.Domain.IdConverter<TKey,TUserKey>.TUserKey')[&gt;](CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.md 'CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey>')
### Methods

<a name='CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_.ConvertIdFromString(string)'></a>

## IdConverter<TKey,TUserKey>.ConvertIdFromString(string) Method

Converts a string representation of the second key type `TKey` to its corresponding value.

```csharp
public System.Nullable<TKey> ConvertIdFromString(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_.ConvertIdFromString(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string representation of the key to be converted.

Implements [ConvertIdFromString(string)](CloudyWing.FormModule.Domain.IIdConverter_TKey_.md#CloudyWing.FormModule.Domain.IIdConverter_TKey_.ConvertIdFromString(string) 'CloudyWing.FormModule.Domain.IIdConverter<TKey>.ConvertIdFromString(string)')

#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TKey](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_.TKey 'CloudyWing.FormModule.Domain.IdConverter<TKey,TUserKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The converted key value.

<a name='CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_.ConvertIdToString(System.Nullable_TKey_)'></a>

## IdConverter<TKey,TUserKey>.ConvertIdToString(Nullable<TKey>) Method

Converts the key type `TKey` to its string representation.

```csharp
public string? ConvertIdToString(System.Nullable<TKey> id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_.ConvertIdToString(System.Nullable_TKey_).id'></a>

`id` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TKey](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_.TKey 'CloudyWing.FormModule.Domain.IdConverter<TKey,TUserKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The key to be converted.

Implements [ConvertIdToString(Nullable&lt;TKey&gt;)](CloudyWing.FormModule.Domain.IIdConverter_TKey_.md#CloudyWing.FormModule.Domain.IIdConverter_TKey_.ConvertIdToString(System.Nullable_TKey_) 'CloudyWing.FormModule.Domain.IIdConverter<TKey>.ConvertIdToString(System.Nullable<TKey>)')

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string representation of the key.

<a name='CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_.ConvertUserIdFromString(string)'></a>

## IdConverter<TKey,TUserKey>.ConvertUserIdFromString(string) Method

Converts a string representation of the second key type `TUserKey` to its corresponding value.

```csharp
public TUserKey? ConvertUserIdFromString(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_.ConvertUserIdFromString(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string representation of the key to be converted.

Implements [ConvertUserIdFromString(string)](CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.md#CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.ConvertUserIdFromString(string) 'CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey>.ConvertUserIdFromString(string)')

#### Returns
[TUserKey](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.IdConverter_TKey,TUserKey_.TUserKey 'CloudyWing.FormModule.Domain.IdConverter<TKey,TUserKey>.TUserKey')  
The converted key value.

<a name='CloudyWing.FormModule.Domain.PagedList_T_'></a>

## PagedList<T> Class

Represents a paged list of items

```csharp
public sealed class PagedList<T> : CloudyWing.FormModule.Domain.PagingMetadata,
CloudyWing.FormModule.Domain.IPagedList<T>,
CloudyWing.FormModule.Domain.IPagingMetadata,
System.Collections.Generic.IEnumerable<T>,
System.Collections.IEnumerable
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.PagedList_T_.T'></a>

`T`

The type of items in the paged list.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [PagingMetadata](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagingMetadata 'CloudyWing.FormModule.Domain.PagingMetadata') &#129106; PagedList<T>

Implements [CloudyWing.FormModule.Domain.IPagedList&lt;](CloudyWing.FormModule.Domain.IPagedList_T_.md 'CloudyWing.FormModule.Domain.IPagedList<T>')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagedList_T_.T 'CloudyWing.FormModule.Domain.PagedList<T>.T')[&gt;](CloudyWing.FormModule.Domain.IPagedList_T_.md 'CloudyWing.FormModule.Domain.IPagedList<T>'), [IPagingMetadata](CloudyWing.FormModule.Domain.IPagingMetadata.md 'CloudyWing.FormModule.Domain.IPagingMetadata'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagedList_T_.T 'CloudyWing.FormModule.Domain.PagedList<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')
### Constructors

<a name='CloudyWing.FormModule.Domain.PagedList_T_.PagedList(System.Collections.Generic.IEnumerable_T_,CloudyWing.FormModule.Domain.PagingMetadata)'></a>

## PagedList(IEnumerable<T>, PagingMetadata) Constructor

Initializes a new instance of the [PagedList&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagedList_T_ 'CloudyWing.FormModule.Domain.PagedList<T>') class.

```csharp
public PagedList(System.Collections.Generic.IEnumerable<T> records, CloudyWing.FormModule.Domain.PagingMetadata metadata);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.PagedList_T_.PagedList(System.Collections.Generic.IEnumerable_T_,CloudyWing.FormModule.Domain.PagingMetadata).records'></a>

`records` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagedList_T_.T 'CloudyWing.FormModule.Domain.PagedList<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection of items in the paged list.

<a name='CloudyWing.FormModule.Domain.PagedList_T_.PagedList(System.Collections.Generic.IEnumerable_T_,CloudyWing.FormModule.Domain.PagingMetadata).metadata'></a>

`metadata` [PagingMetadata](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagingMetadata 'CloudyWing.FormModule.Domain.PagingMetadata')

The pagination metadata.

<a name='CloudyWing.FormModule.Domain.PagedList_T_.PagedList(System.Collections.Generic.IEnumerable_T_,int,int,int)'></a>

## PagedList(IEnumerable<T>, int, int, int) Constructor

Initializes a new instance of the [PagedList&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagedList_T_ 'CloudyWing.FormModule.Domain.PagedList<T>') class.

```csharp
public PagedList(System.Collections.Generic.IEnumerable<T> records, int pageNumber, int pageSize, int totalItemCount);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.PagedList_T_.PagedList(System.Collections.Generic.IEnumerable_T_,int,int,int).records'></a>

`records` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagedList_T_.T 'CloudyWing.FormModule.Domain.PagedList<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection of items in the paged list.

<a name='CloudyWing.FormModule.Domain.PagedList_T_.PagedList(System.Collections.Generic.IEnumerable_T_,int,int,int).pageNumber'></a>

`pageNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The current page number.

<a name='CloudyWing.FormModule.Domain.PagedList_T_.PagedList(System.Collections.Generic.IEnumerable_T_,int,int,int).pageSize'></a>

`pageSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of items per page.

<a name='CloudyWing.FormModule.Domain.PagedList_T_.PagedList(System.Collections.Generic.IEnumerable_T_,int,int,int).totalItemCount'></a>

`totalItemCount` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of items.
### Properties

<a name='CloudyWing.FormModule.Domain.PagedList_T_.Count'></a>

## PagedList<T>.Count Property

Gets the total number of items in the paged list.

```csharp
public int Count { get; }
```

Implements [Count](CloudyWing.FormModule.Domain.IPagedList_T_.md#CloudyWing.FormModule.Domain.IPagedList_T_.Count 'CloudyWing.FormModule.Domain.IPagedList<T>.Count')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.Domain.PagedList_T_.this[int]'></a>

## PagedList<T>.this[int] Property

Gets the item at the specified index in the paged list.

```csharp
public T this[int index] { get; }
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.PagedList_T_.this[int].index'></a>

`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The zero-based index of the item to retrieve.

Implements [this[int]](CloudyWing.FormModule.Domain.IPagedList_T_.md#CloudyWing.FormModule.Domain.IPagedList_T_.this[int] 'CloudyWing.FormModule.Domain.IPagedList<T>.this[int]')

#### Property Value
[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagedList_T_.T 'CloudyWing.FormModule.Domain.PagedList<T>.T')

<a name='CloudyWing.FormModule.Domain.PagingMetadata'></a>

## PagingMetadata Class

Represents pagination metadata for a paged collection of items.

```csharp
public class PagingMetadata :
CloudyWing.FormModule.Domain.IPagingMetadata
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PagingMetadata

Derived  
&#8627; [PagedList&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagedList_T_ 'CloudyWing.FormModule.Domain.PagedList<T>')

Implements [IPagingMetadata](CloudyWing.FormModule.Domain.IPagingMetadata.md 'CloudyWing.FormModule.Domain.IPagingMetadata')
### Constructors

<a name='CloudyWing.FormModule.Domain.PagingMetadata.PagingMetadata(int,int,int)'></a>

## PagingMetadata(int, int, int) Constructor

Initializes a new instance of the [PagingMetadata](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagingMetadata 'CloudyWing.FormModule.Domain.PagingMetadata') class.

```csharp
public PagingMetadata(int pageNumber, int pageSize, int totalCount);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.PagingMetadata.PagingMetadata(int,int,int).pageNumber'></a>

`pageNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The page number.

<a name='CloudyWing.FormModule.Domain.PagingMetadata.PagingMetadata(int,int,int).pageSize'></a>

`pageSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Size of the page.

<a name='CloudyWing.FormModule.Domain.PagingMetadata.PagingMetadata(int,int,int).totalCount'></a>

`totalCount` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total count.
### Properties

<a name='CloudyWing.FormModule.Domain.PagingMetadata.FirstItemOnPage'></a>

## PagingMetadata.FirstItemOnPage Property

Gets the index of the first item on the current page.

```csharp
public int FirstItemOnPage { get; }
```

Implements [FirstItemOnPage](CloudyWing.FormModule.Domain.IPagingMetadata.md#CloudyWing.FormModule.Domain.IPagingMetadata.FirstItemOnPage 'CloudyWing.FormModule.Domain.IPagingMetadata.FirstItemOnPage')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.Domain.PagingMetadata.HasNextPage'></a>

## PagingMetadata.HasNextPage Property

Gets a value indicating whether there is a next page.

```csharp
public bool HasNextPage { get; }
```

Implements [HasNextPage](CloudyWing.FormModule.Domain.IPagingMetadata.md#CloudyWing.FormModule.Domain.IPagingMetadata.HasNextPage 'CloudyWing.FormModule.Domain.IPagingMetadata.HasNextPage')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.Domain.PagingMetadata.HasPreviousPage'></a>

## PagingMetadata.HasPreviousPage Property

Gets a value indicating whether there is a previous page.

```csharp
public bool HasPreviousPage { get; }
```

Implements [HasPreviousPage](CloudyWing.FormModule.Domain.IPagingMetadata.md#CloudyWing.FormModule.Domain.IPagingMetadata.HasPreviousPage 'CloudyWing.FormModule.Domain.IPagingMetadata.HasPreviousPage')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.Domain.PagingMetadata.IsFirstPage'></a>

## PagingMetadata.IsFirstPage Property

Gets a value indicating whether the current page is the first page.

```csharp
public bool IsFirstPage { get; }
```

Implements [IsFirstPage](CloudyWing.FormModule.Domain.IPagingMetadata.md#CloudyWing.FormModule.Domain.IPagingMetadata.IsFirstPage 'CloudyWing.FormModule.Domain.IPagingMetadata.IsFirstPage')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.Domain.PagingMetadata.IsLastPage'></a>

## PagingMetadata.IsLastPage Property

Gets a value indicating whether the current page is the last page.

```csharp
public bool IsLastPage { get; }
```

Implements [IsLastPage](CloudyWing.FormModule.Domain.IPagingMetadata.md#CloudyWing.FormModule.Domain.IPagingMetadata.IsLastPage 'CloudyWing.FormModule.Domain.IPagingMetadata.IsLastPage')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.Domain.PagingMetadata.LastItemOnPage'></a>

## PagingMetadata.LastItemOnPage Property

Gets the index of the last item on the current page.

```csharp
public int LastItemOnPage { get; }
```

Implements [LastItemOnPage](CloudyWing.FormModule.Domain.IPagingMetadata.md#CloudyWing.FormModule.Domain.IPagingMetadata.LastItemOnPage 'CloudyWing.FormModule.Domain.IPagingMetadata.LastItemOnPage')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.Domain.PagingMetadata.PageCount'></a>

## PagingMetadata.PageCount Property

Gets the total number of pages.

```csharp
public int PageCount { get; }
```

Implements [PageCount](CloudyWing.FormModule.Domain.IPagingMetadata.md#CloudyWing.FormModule.Domain.IPagingMetadata.PageCount 'CloudyWing.FormModule.Domain.IPagingMetadata.PageCount')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.Domain.PagingMetadata.PageNumber'></a>

## PagingMetadata.PageNumber Property

Gets the current page number.

```csharp
public int PageNumber { get; set; }
```

Implements [PageNumber](CloudyWing.FormModule.Domain.IPagingMetadata.md#CloudyWing.FormModule.Domain.IPagingMetadata.PageNumber 'CloudyWing.FormModule.Domain.IPagingMetadata.PageNumber')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.Domain.PagingMetadata.PageSize'></a>

## PagingMetadata.PageSize Property

Gets the number of items per page.

```csharp
public int PageSize { get; set; }
```

Implements [PageSize](CloudyWing.FormModule.Domain.IPagingMetadata.md#CloudyWing.FormModule.Domain.IPagingMetadata.PageSize 'CloudyWing.FormModule.Domain.IPagingMetadata.PageSize')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.Domain.PagingMetadata.TotalItemCount'></a>

## PagingMetadata.TotalItemCount Property

Gets the total number of items.

```csharp
public int TotalItemCount { get; set; }
```

Implements [TotalItemCount](CloudyWing.FormModule.Domain.IPagingMetadata.md#CloudyWing.FormModule.Domain.IPagingMetadata.TotalItemCount 'CloudyWing.FormModule.Domain.IPagingMetadata.TotalItemCount')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions'></a>

## QueryableServiceExtensions Class

Provides extension methods for `IQueryableService` to perform common querying operations.

```csharp
public static class QueryableServiceExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; QueryableServiceExtensions
### Methods

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_)'></a>

## QueryableServiceExtensions.CountAsync<TEntity>(this IQueryableService<TEntity>, Specification<TEntity>) Method

Counts the number of entities satisfying the specified specification.

```csharp
public static System.Threading.Tasks.Task<int> CountAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, CloudyWing.FormModule.Domain.Specification<TEntity> spec)
    where TEntity : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity'></a>

`TEntity`

The type of the entity.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).spec'></a>

`spec` [CloudyWing.FormModule.Domain.Specification&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')

The specification to apply.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The number of entities satisfying the specification.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__)'></a>

## QueryableServiceExtensions.CountAsync<TEntity>(this IQueryableService<TEntity>, Expression<Func<TEntity,bool>>) Method

Counts the number of entities satisfying the specified filter.

```csharp
public static System.Threading.Tasks.Task<int> CountAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>? filter=null)
    where TEntity : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity'></a>

`TEntity`

The type of the entity.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).filter'></a>

`filter` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.CountAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The filter expression.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The number of entities satisfying the filter.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_)'></a>

## QueryableServiceExtensions.GetFirstAsync<TEntity,TRecord>(this IQueryableService<TEntity>, Expression<Func<TEntity,TRecord>>, Specification<TEntity>) Method

Gets the first entity satisfying the specified selector and specification.

```csharp
public static System.Threading.Tasks.Task<TRecord> GetFirstAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>> selector, CloudyWing.FormModule.Domain.Specification<TEntity> spec)
    where TEntity : class
    where TRecord : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity'></a>

`TEntity`

The type of the entity.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord'></a>

`TRecord`

The type of the result record.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).selector'></a>

`selector` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The selector expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).spec'></a>

`spec` [CloudyWing.FormModule.Domain.Specification&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')

The specification to apply.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The first entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__)'></a>

## QueryableServiceExtensions.GetFirstAsync<TEntity,TRecord>(this IQueryableService<TEntity>, Expression<Func<TEntity,TRecord>>, Expression<Func<TEntity,bool>>, Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>>) Method

Gets the first entity satisfying the specified selector, filter, and optional order generator.

```csharp
public static System.Threading.Tasks.Task<TRecord> GetFirstAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>> selector, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>? filter=null, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>? orderByGenerator=null)
    where TEntity : class
    where TRecord : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity'></a>

`TEntity`

The type of the entity.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TRecord'></a>

`TRecord`

The type of the result record.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).selector'></a>

`selector` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The selector expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).filter'></a>

`filter` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The filter expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).orderByGenerator'></a>

`orderByGenerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IOrderedQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The optional order generator.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The first entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_)'></a>

## QueryableServiceExtensions.GetFirstAsync<TEntity>(this IQueryableService<TEntity>, Specification<TEntity>) Method

Gets the first entity satisfying the specified specification.

```csharp
public static System.Threading.Tasks.Task<TEntity> GetFirstAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, CloudyWing.FormModule.Domain.Specification<TEntity> spec)
    where TEntity : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity'></a>

`TEntity`

The type of the entity.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).spec'></a>

`spec` [CloudyWing.FormModule.Domain.Specification&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')

The specification to apply.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The first entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__)'></a>

## QueryableServiceExtensions.GetFirstAsync<TEntity>(this IQueryableService<TEntity>, Expression<Func<TEntity,bool>>, Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>>) Method

Gets the first entity satisfying the specified filter and optional order generator.

```csharp
public static System.Threading.Tasks.Task<TEntity> GetFirstAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>? filter=null, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>? orderByGenerator=null)
    where TEntity : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity'></a>

`TEntity`

The type of the entity.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).filter'></a>

`filter` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The filter expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).orderByGenerator'></a>

`orderByGenerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IOrderedQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The optional order generator.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The first entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_)'></a>

## QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity,TRecord>(this IQueryableService<TEntity>, Expression<Func<TEntity,TRecord>>, Specification<TEntity>) Method

Gets the first or default entity satisfying the specified selector and specification.

```csharp
public static System.Threading.Tasks.Task<TRecord?> GetFirstOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>> selector, CloudyWing.FormModule.Domain.Specification<TEntity> spec)
    where TEntity : class
    where TRecord : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity'></a>

`TEntity`

The type of the entity.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord'></a>

`TRecord`

The type of the result record.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).selector'></a>

`selector` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The selector expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).spec'></a>

`spec` [CloudyWing.FormModule.Domain.Specification&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')

The specification to apply.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The first or default entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__)'></a>

## QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity,TRecord>(this IQueryableService<TEntity>, Expression<Func<TEntity,TRecord>>, Expression<Func<TEntity,bool>>, Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>>) Method

Gets the first or default entity satisfying the specified selector, filter, and optional order generator.

```csharp
public static System.Threading.Tasks.Task<TRecord?> GetFirstOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>> selector, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>? filter=null, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>? orderByGenerator=null)
    where TEntity : class
    where TRecord : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity'></a>

`TEntity`

The type of the entity.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TRecord'></a>

`TRecord`

The type of the result record.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).selector'></a>

`selector` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The selector expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).filter'></a>

`filter` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The filter expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).orderByGenerator'></a>

`orderByGenerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IOrderedQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The optional order generator.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The first or default entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_)'></a>

## QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity>(this IQueryableService<TEntity>, Specification<TEntity>) Method

Gets the first or default entity satisfying the specified specification.

```csharp
public static System.Threading.Tasks.Task<TEntity?> GetFirstOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, CloudyWing.FormModule.Domain.Specification<TEntity> spec)
    where TEntity : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity'></a>

`TEntity`

The type of the entity.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).spec'></a>

`spec` [CloudyWing.FormModule.Domain.Specification&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')

The specification to apply.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The first or default entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__)'></a>

## QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity>(this IQueryableService<TEntity>, Expression<Func<TEntity,bool>>, Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>>) Method

Gets the first or default entity satisfying the specified filter and optional order generator.

```csharp
public static System.Threading.Tasks.Task<TEntity?> GetFirstOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>? filter=null, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>? orderByGenerator=null)
    where TEntity : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity'></a>

`TEntity`

The type of the entity.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).filter'></a>

`filter` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The filter expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).orderByGenerator'></a>

`orderByGenerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IOrderedQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The optional order generator.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetFirstOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The first or default entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_)'></a>

## QueryableServiceExtensions.GetListAsync<TEntity,TRecord>(this IQueryableService<TEntity>, Expression<Func<TEntity,TRecord>>, Specification<TEntity>) Method

Gets a list of entities satisfying the specified selector and specification.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<TRecord>> GetListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>> selector, CloudyWing.FormModule.Domain.Specification<TEntity> spec)
    where TEntity : class
    where TRecord : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity'></a>

`TEntity`

The type of the entity.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord'></a>

`TRecord`

The type of the result record.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).selector'></a>

`selector` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The selector expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).spec'></a>

`spec` [CloudyWing.FormModule.Domain.Specification&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')

The specification to apply.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IReadOnlyList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The list of entities satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__)'></a>

## QueryableServiceExtensions.GetListAsync<TEntity,TRecord>(this IQueryableService<TEntity>, Expression<Func<TEntity,TRecord>>, Expression<Func<TEntity,bool>>, Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>>) Method

Gets a list of entities satisfying the specified selector, filter, and optional order generator.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<TRecord>> GetListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>> selector, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>? filter=null, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>? orderByGenerator=null)
    where TEntity : class
    where TRecord : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity'></a>

`TEntity`

The type of the entity.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TRecord'></a>

`TRecord`

The type of the result record.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).selector'></a>

`selector` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The selector expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).filter'></a>

`filter` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The filter expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).orderByGenerator'></a>

`orderByGenerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IOrderedQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The order generator expression.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IReadOnlyList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The list of entities satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_)'></a>

## QueryableServiceExtensions.GetListAsync<TEntity>(this IQueryableService<TEntity>, Specification<TEntity>) Method

Gets a list of entities satisfying the specified specification.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<TEntity>> GetListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, CloudyWing.FormModule.Domain.Specification<TEntity> spec)
    where TEntity : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity'></a>

`TEntity`

The type of the entity.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).spec'></a>

`spec` [CloudyWing.FormModule.Domain.Specification&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')

The specification to apply.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IReadOnlyList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The list of entities satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__)'></a>

## QueryableServiceExtensions.GetListAsync<TEntity>(this IQueryableService<TEntity>, Expression<Func<TEntity,bool>>, Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>>) Method

Gets a list of entities satisfying the specified filter and optional order generator.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<TEntity>> GetListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>? filter=null, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>? orderByGenerator=null)
    where TEntity : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity'></a>

`TEntity`

The type of the entity.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).filter'></a>

`filter` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The filter expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).orderByGenerator'></a>

`orderByGenerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IOrderedQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The order generator expression.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IReadOnlyList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The list of entities satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__)'></a>

## QueryableServiceExtensions.GetPagedListAsync<TEntity,TRecord>(this IQueryableService<TEntity>, Expression<Func<TEntity,TRecord>>, Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>>, int, int, Expression<Func<TEntity,bool>>) Method

Gets a paged list of entities satisfying the specified selector, order generator, page number, page size, and optional filter.

```csharp
public static System.Threading.Tasks.Task<CloudyWing.FormModule.Domain.IPagedList<TRecord>> GetPagedListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>> selector, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>> orderByGenerator, int pageNumber, int pageSize, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>? filter=null)
    where TEntity : class
    where TRecord : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity'></a>

`TEntity`

The type of the entity.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TRecord'></a>

`TRecord`

The type of the result record.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>, int, int, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).selector'></a>

`selector` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>, int, int, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>, int, int, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The selector expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).orderByGenerator'></a>

`orderByGenerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>, int, int, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IOrderedQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>, int, int, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The order generator expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).pageNumber'></a>

`pageNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The page number.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).pageSize'></a>

`pageSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The page size.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).filter'></a>

`filter` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>, int, int, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The filter expression.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[CloudyWing.FormModule.Domain.IPagedList&lt;](CloudyWing.FormModule.Domain.IPagedList_T_.md 'CloudyWing.FormModule.Domain.IPagedList<T>')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>, int, int, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TRecord')[&gt;](CloudyWing.FormModule.Domain.IPagedList_T_.md 'CloudyWing.FormModule.Domain.IPagedList<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The paged list of entities satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__)'></a>

## QueryableServiceExtensions.GetPagedListAsync<TEntity>(this IQueryableService<TEntity>, Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>>, int, int, Expression<Func<TEntity,bool>>) Method

Gets a paged list of entities satisfying the specified order generator, page number, page size, and optional filter.

```csharp
public static System.Threading.Tasks.Task<CloudyWing.FormModule.Domain.IPagedList<TEntity>> GetPagedListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>> orderByGenerator, int pageNumber, int pageSize, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>? filter=null)
    where TEntity : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity'></a>

`TEntity`

The type of the entity.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>, int, int, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).orderByGenerator'></a>

`orderByGenerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>, int, int, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IOrderedQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>, int, int, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The order generator expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).pageNumber'></a>

`pageNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The page number.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).pageSize'></a>

`pageSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The page size.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).filter'></a>

`filter` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>, int, int, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The filter expression.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[CloudyWing.FormModule.Domain.IPagedList&lt;](CloudyWing.FormModule.Domain.IPagedList_T_.md 'CloudyWing.FormModule.Domain.IPagedList<T>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Func_System.Linq.IQueryable_TEntity_,System.Linq.IOrderedQueryable_TEntity__,int,int,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetPagedListAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Func<System.Linq.IQueryable<TEntity>,System.Linq.IOrderedQueryable<TEntity>>, int, int, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IPagedList_T_.md 'CloudyWing.FormModule.Domain.IPagedList<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The paged list of entities satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_)'></a>

## QueryableServiceExtensions.GetSingleAsync<TEntity,TRecord>(this IQueryableService<TEntity>, Expression<Func<TEntity,TRecord>>, Specification<TEntity>) Method

Gets a single entity satisfying the specified selector and specification.

```csharp
public static System.Threading.Tasks.Task<TRecord> GetSingleAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>> selector, CloudyWing.FormModule.Domain.Specification<TEntity> spec)
    where TEntity : class
    where TRecord : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity'></a>

`TEntity`

The type of the entity.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord'></a>

`TRecord`

The type of the result record.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).selector'></a>

`selector` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The selector expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).spec'></a>

`spec` [CloudyWing.FormModule.Domain.Specification&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')

The specification to apply.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The single entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__)'></a>

## QueryableServiceExtensions.GetSingleAsync<TEntity,TRecord>(this IQueryableService<TEntity>, Expression<Func<TEntity,TRecord>>, Expression<Func<TEntity,bool>>) Method

Gets a single entity satisfying the specified selector and filter.

```csharp
public static System.Threading.Tasks.Task<TRecord> GetSingleAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>> selector, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>? filter=null)
    where TEntity : class
    where TRecord : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity'></a>

`TEntity`

The type of the entity.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TRecord'></a>

`TRecord`

The type of the result record.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).selector'></a>

`selector` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The selector expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).filter'></a>

`filter` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The filter expression.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The single entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_)'></a>

## QueryableServiceExtensions.GetSingleAsync<TEntity>(this IQueryableService<TEntity>, Specification<TEntity>) Method

Gets a single entity satisfying the specified specification.

```csharp
public static System.Threading.Tasks.Task<TEntity> GetSingleAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, CloudyWing.FormModule.Domain.Specification<TEntity> spec)
    where TEntity : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity'></a>

`TEntity`

The type of the entity.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).spec'></a>

`spec` [CloudyWing.FormModule.Domain.Specification&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')

The specification to apply.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The single entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__)'></a>

## QueryableServiceExtensions.GetSingleAsync<TEntity>(this IQueryableService<TEntity>, Expression<Func<TEntity,bool>>) Method

Gets a single entity satisfying the specified filter.

```csharp
public static System.Threading.Tasks.Task<TEntity> GetSingleAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>? filter=null)
    where TEntity : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity'></a>

`TEntity`

The type of the entity.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).filter'></a>

`filter` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The filter expression.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The single entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_)'></a>

## QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity,TRecord>(this IQueryableService<TEntity>, Expression<Func<TEntity,TRecord>>, Specification<TEntity>) Method

Gets the single or default entity satisfying the specified selector and specification.

```csharp
public static System.Threading.Tasks.Task<TRecord?> GetSingleOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>> selector, CloudyWing.FormModule.Domain.Specification<TEntity> spec)
    where TEntity : class
    where TRecord : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity'></a>

`TEntity`

The type of the entity.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord'></a>

`TRecord`

The type of the result record.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).selector'></a>

`selector` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The selector expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).spec'></a>

`spec` [CloudyWing.FormModule.Domain.Specification&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')

The specification to apply.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,CloudyWing.FormModule.Domain.Specification_TEntity_).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, CloudyWing.FormModule.Domain.Specification<TEntity>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The single or default entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__)'></a>

## QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity,TRecord>(this IQueryableService<TEntity>, Expression<Func<TEntity,TRecord>>, Expression<Func<TEntity,bool>>) Method

Gets the single or default entity satisfying the specified selector and filter.

```csharp
public static System.Threading.Tasks.Task<TRecord?> GetSingleOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>> selector, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>? filter=null)
    where TEntity : class
    where TRecord : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity'></a>

`TEntity`

The type of the entity.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TRecord'></a>

`TRecord`

The type of the result record.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).selector'></a>

`selector` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The selector expression.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).filter'></a>

`filter` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The filter expression.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TRecord](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity,TRecord_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,TRecord__,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TRecord 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity,TRecord>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,TRecord>>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TRecord')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The single or default entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_)'></a>

## QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity>(this IQueryableService<TEntity>, Specification<TEntity>) Method

Gets the single or default entity satisfying the specified specification.

```csharp
public static System.Threading.Tasks.Task<TEntity?> GetSingleOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, CloudyWing.FormModule.Domain.Specification<TEntity> spec)
    where TEntity : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity'></a>

`TEntity`

The type of the entity.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).spec'></a>

`spec` [CloudyWing.FormModule.Domain.Specification&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')

The specification to apply.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The single or default entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__)'></a>

## QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity>(this IQueryableService<TEntity>, Expression<Func<TEntity,bool>>) Method

Gets the single or default entity satisfying the specified filter.

```csharp
public static System.Threading.Tasks.Task<TEntity?> GetSingleOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>? filter=null)
    where TEntity : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity'></a>

`TEntity`

The type of the entity.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).filter'></a>

`filter` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The filter expression.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,System.Linq.Expressions.Expression_System.Func_TEntity,bool__).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.GetSingleOrDefaultAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, System.Linq.Expressions.Expression<System.Func<TEntity,bool>>).TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The single or default entity satisfying the conditions.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.IsExistsAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_)'></a>

## QueryableServiceExtensions.IsExistsAsync<TEntity>(this IQueryableService<TEntity>, Specification<TEntity>) Method

Checks if any entity satisfying the specified specification exists.

```csharp
public static System.Threading.Tasks.Task<bool> IsExistsAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity> service, CloudyWing.FormModule.Domain.Specification<TEntity> spec)
    where TEntity : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.IsExistsAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity'></a>

`TEntity`

The type of the entity.
#### Parameters

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.IsExistsAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).service'></a>

`service` [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.IsExistsAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.IsExistsAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')

The queryable service.

<a name='CloudyWing.FormModule.Domain.QueryableServiceExtensions.IsExistsAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).spec'></a>

`spec` [CloudyWing.FormModule.Domain.Specification&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.QueryableServiceExtensions.IsExistsAsync_TEntity_(thisCloudyWing.FormModule.Domain.IQueryableService_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).TEntity 'CloudyWing.FormModule.Domain.QueryableServiceExtensions.IsExistsAsync<TEntity>(this CloudyWing.FormModule.Domain.IQueryableService<TEntity>, CloudyWing.FormModule.Domain.Specification<TEntity>).TEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')

The specification to apply.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if any entity exists; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.Specification_T_'></a>

## Specification<T> Class

Represents a specification for querying entities of type [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_.T 'CloudyWing.FormModule.Domain.Specification<T>.T').

```csharp
public class Specification<T>
    where T : class
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.Specification_T_.T'></a>

`T`

The type of the entity.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Specification<T>
### Properties

<a name='CloudyWing.FormModule.Domain.Specification_T_.Filter'></a>

## Specification<T>.Filter Property

Gets or sets the filter expression to apply.

```csharp
public System.Linq.Expressions.Expression<System.Func<T,bool>>? Filter { get; set; }
```

#### Property Value
[System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_.T 'CloudyWing.FormModule.Domain.Specification<T>.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

<a name='CloudyWing.FormModule.Domain.Specification_T_.GroupBy'></a>

## Specification<T>.GroupBy Property

Gets or sets the group by expression to apply.

```csharp
public System.Linq.Expressions.Expression<System.Func<T,object>>? GroupBy { get; set; }
```

#### Property Value
[System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_.T 'CloudyWing.FormModule.Domain.Specification<T>.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

<a name='CloudyWing.FormModule.Domain.Specification_T_.OrderByGenerator'></a>

## Specification<T>.OrderByGenerator Property

Gets or sets the order generator expression to apply.

```csharp
public System.Func<System.Linq.IQueryable<T>,System.Linq.IOrderedQueryable<T>>? OrderByGenerator { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_.T 'CloudyWing.FormModule.Domain.Specification<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Linq.IOrderedQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_.T 'CloudyWing.FormModule.Domain.Specification<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IOrderedQueryable-1 'System.Linq.IOrderedQueryable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='CloudyWing.FormModule.Domain.Specification_T_.Skip'></a>

## Specification<T>.Skip Property

Gets or sets the number of entities to skip.

```csharp
public System.Nullable<int> Skip { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='CloudyWing.FormModule.Domain.Specification_T_.Take'></a>

## Specification<T>.Take Property

Gets or sets the number of entities to take.

```csharp
public System.Nullable<int> Take { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='CloudyWing.FormModule.Domain.SpecificationEvaluator_TEntity_'></a>

## SpecificationEvaluator<TEntity> Class

Provides methods for evaluating specifications and generating queries for entities of type [TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.SpecificationEvaluator_TEntity_.TEntity 'CloudyWing.FormModule.Domain.SpecificationEvaluator<TEntity>.TEntity').

```csharp
public static class SpecificationEvaluator<TEntity>
    where TEntity : class
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.SpecificationEvaluator_TEntity_.TEntity'></a>

`TEntity`

The type of the entity.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SpecificationEvaluator<TEntity>
### Methods

<a name='CloudyWing.FormModule.Domain.SpecificationEvaluator_TEntity_.GetQuery(System.Linq.IQueryable_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_)'></a>

## SpecificationEvaluator<TEntity>.GetQuery(IQueryable<TEntity>, Specification<TEntity>) Method

Generates the query based on the provided data source and specification.

```csharp
public static System.Linq.IQueryable<TEntity> GetQuery(System.Linq.IQueryable<TEntity> dataSource, CloudyWing.FormModule.Domain.Specification<TEntity> specification);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.SpecificationEvaluator_TEntity_.GetQuery(System.Linq.IQueryable_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).dataSource'></a>

`dataSource` [System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.SpecificationEvaluator_TEntity_.TEntity 'CloudyWing.FormModule.Domain.SpecificationEvaluator<TEntity>.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')

The data source to query.

<a name='CloudyWing.FormModule.Domain.SpecificationEvaluator_TEntity_.GetQuery(System.Linq.IQueryable_TEntity_,CloudyWing.FormModule.Domain.Specification_TEntity_).specification'></a>

`specification` [CloudyWing.FormModule.Domain.Specification&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.SpecificationEvaluator_TEntity_.TEntity 'CloudyWing.FormModule.Domain.SpecificationEvaluator<TEntity>.TEntity')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.Specification_T_ 'CloudyWing.FormModule.Domain.Specification<T>')

The specification to apply.

#### Returns
[System.Linq.IQueryable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')[TEntity](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.SpecificationEvaluator_TEntity_.TEntity 'CloudyWing.FormModule.Domain.SpecificationEvaluator<TEntity>.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.IQueryable-1 'System.Linq.IQueryable`1')  
The IQueryable representing the query based on the specification.
### Structs

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_'></a>

## ValueWatcher<T> Struct

Represents a value watcher that can hold a value of type [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T').

```csharp
public readonly struct ValueWatcher<T> :
System.IEquatable<CloudyWing.FormModule.Domain.ValueWatcher<T>>
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.T'></a>

`T`

The type of the value.

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')
### Constructors

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.ValueWatcher(T)'></a>

## ValueWatcher(T) Constructor

Initializes a new instance of the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') struct with the specified value.

```csharp
public ValueWatcher(T value);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.ValueWatcher(T).value'></a>

`value` [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')

The value to be stored.
### Properties

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.Empty'></a>

## ValueWatcher<T>.Empty Property

Gets an empty instance of the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') struct.

```csharp
public static CloudyWing.FormModule.Domain.ValueWatcher<T> Empty { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.HasValue'></a>

## ValueWatcher<T>.HasValue Property

Gets a value indicating whether the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') has a value.

```csharp
public bool HasValue { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.Value'></a>

## ValueWatcher<T>.Value Property

Gets the value stored in the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object.

```csharp
public T Value { get; }
```

#### Property Value
[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Thrown when the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object does not have a value.
### Methods

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.Equals(object)'></a>

## ValueWatcher<T>.Equals(object) Method

Indicates whether this instance and a specified object are equal.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.Equals(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The object to compare with the current instance.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [obj](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.Equals(object).obj 'CloudyWing.FormModule.Domain.ValueWatcher<T>.Equals(object).obj') and this instance are the same type and represent the same value; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.GetHashCode()'></a>

## ValueWatcher<T>.GetHashCode() Method

Computes the hash code for the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object.

```csharp
public override int GetHashCode();
```

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The hash code for the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object.

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.GetValueOrDefault()'></a>

## ValueWatcher<T>.GetValueOrDefault() Method

Gets the value stored in the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object, or the default value of type [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T') if it does not have a value.

```csharp
public T? GetValueOrDefault();
```

#### Returns
[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')  
The stored value or the default value of type T??.

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.GetValueOrDefault(T)'></a>

## ValueWatcher<T>.GetValueOrDefault(T) Method

Gets the value stored in the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object, or the specified default value if it does not have a value.

```csharp
public T? GetValueOrDefault(T? defaultValue);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.GetValueOrDefault(T).defaultValue'></a>

`defaultValue` [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')

The default value to return if the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object does not have a value.

#### Returns
[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')  
The stored value or the specified default value.

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.ToString()'></a>

## ValueWatcher<T>.ToString() Method

Returns a string that represents the current [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object.

```csharp
public override string ToString();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string representation of the current [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object.
### Operators

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Equality(CloudyWing.FormModule.Domain.ValueWatcher_T_,CloudyWing.FormModule.Domain.ValueWatcher_T_)'></a>

## ValueWatcher<T>.operator ==(ValueWatcher<T>, ValueWatcher<T>) Operator

Determines whether two [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') objects are equal.

```csharp
public static bool operator ==(CloudyWing.FormModule.Domain.ValueWatcher<T> left, CloudyWing.FormModule.Domain.ValueWatcher<T> right);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Equality(CloudyWing.FormModule.Domain.ValueWatcher_T_,CloudyWing.FormModule.Domain.ValueWatcher_T_).left'></a>

`left` [CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

The first [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object to compare.

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Equality(CloudyWing.FormModule.Domain.ValueWatcher_T_,CloudyWing.FormModule.Domain.ValueWatcher_T_).right'></a>

`right` [CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

The second [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object to compare.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the objects are equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Equality(CloudyWing.FormModule.Domain.ValueWatcher_T_,T)'></a>

## ValueWatcher<T>.operator ==(ValueWatcher<T>, T) Operator

Determines whether a [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object is equal to a value of type [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T').

```csharp
public static bool operator ==(CloudyWing.FormModule.Domain.ValueWatcher<T> left, T right);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Equality(CloudyWing.FormModule.Domain.ValueWatcher_T_,T).left'></a>

`left` [CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

The [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object to compare.

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Equality(CloudyWing.FormModule.Domain.ValueWatcher_T_,T).right'></a>

`right` [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')

The value to compare.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object and the value are equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Equality(T,CloudyWing.FormModule.Domain.ValueWatcher_T_)'></a>

## ValueWatcher<T>.operator ==(T, ValueWatcher<T>) Operator

Determines whether a value of type [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T') is equal to a [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object.

```csharp
public static bool operator ==(T left, CloudyWing.FormModule.Domain.ValueWatcher<T> right);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Equality(T,CloudyWing.FormModule.Domain.ValueWatcher_T_).left'></a>

`left` [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')

The value to compare.

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Equality(T,CloudyWing.FormModule.Domain.ValueWatcher_T_).right'></a>

`right` [CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

The [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object to compare.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the value and the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object are equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_ExplicitT(CloudyWing.FormModule.Domain.ValueWatcher_T_)'></a>

## ValueWatcher<T>.explicit operator T(ValueWatcher<T>) Operator

Explicitly converts a [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object to a value of type [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T').

```csharp
public static T explicit operator T(CloudyWing.FormModule.Domain.ValueWatcher<T> value);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_ExplicitT(CloudyWing.FormModule.Domain.ValueWatcher_T_).value'></a>

`value` [CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

The [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object to convert.

#### Returns
[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')  
The value stored in the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object.

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_ImplicitCloudyWing.FormModule.Domain.ValueWatcher_T_(T)'></a>

## ValueWatcher<T>.implicit operator ValueWatcher<T>(T) Operator

Implicitly converts a value of type [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T') to a [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object.

```csharp
public static CloudyWing.FormModule.Domain.ValueWatcher<T> implicit operator ValueWatcher<T>(T value);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_ImplicitCloudyWing.FormModule.Domain.ValueWatcher_T_(T).value'></a>

`value` [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')

The value to be stored in the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object.

#### Returns
[CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')  
A new [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object storing the specified value.

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Inequality(CloudyWing.FormModule.Domain.ValueWatcher_T_,CloudyWing.FormModule.Domain.ValueWatcher_T_)'></a>

## ValueWatcher<T>.operator !=(ValueWatcher<T>, ValueWatcher<T>) Operator

Determines whether two [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') objects are not equal.

```csharp
public static bool operator !=(CloudyWing.FormModule.Domain.ValueWatcher<T> left, CloudyWing.FormModule.Domain.ValueWatcher<T> right);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Inequality(CloudyWing.FormModule.Domain.ValueWatcher_T_,CloudyWing.FormModule.Domain.ValueWatcher_T_).left'></a>

`left` [CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

The first [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object to compare.

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Inequality(CloudyWing.FormModule.Domain.ValueWatcher_T_,CloudyWing.FormModule.Domain.ValueWatcher_T_).right'></a>

`right` [CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

The second [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object to compare.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the objects are not equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Inequality(CloudyWing.FormModule.Domain.ValueWatcher_T_,T)'></a>

## ValueWatcher<T>.operator !=(ValueWatcher<T>, T) Operator

Determines whether a [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object is not equal to a value of type [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T').

```csharp
public static bool operator !=(CloudyWing.FormModule.Domain.ValueWatcher<T> left, T right);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Inequality(CloudyWing.FormModule.Domain.ValueWatcher_T_,T).left'></a>

`left` [CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

The [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object to compare.

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Inequality(CloudyWing.FormModule.Domain.ValueWatcher_T_,T).right'></a>

`right` [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')

The value to compare.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object and the value are not equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Inequality(T,CloudyWing.FormModule.Domain.ValueWatcher_T_)'></a>

## ValueWatcher<T>.operator !=(T, ValueWatcher<T>) Operator

Determines whether a value of type [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T') is not equal to a [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object.

```csharp
public static bool operator !=(T left, CloudyWing.FormModule.Domain.ValueWatcher<T> right);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Inequality(T,CloudyWing.FormModule.Domain.ValueWatcher_T_).left'></a>

`left` [T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')

The value to compare.

<a name='CloudyWing.FormModule.Domain.ValueWatcher_T_.op_Inequality(T,CloudyWing.FormModule.Domain.ValueWatcher_T_).right'></a>

`right` [CloudyWing.FormModule.Domain.ValueWatcher&lt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')[T](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_.T 'CloudyWing.FormModule.Domain.ValueWatcher<T>.T')[&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>')

The [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object to compare.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the value and the [ValueWatcher&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.ValueWatcher_T_ 'CloudyWing.FormModule.Domain.ValueWatcher<T>') object are not equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

| Interfaces | |
| :--- | :--- |
| [IFormModuleMapper](CloudyWing.FormModule.Domain.IFormModuleMapper.md 'CloudyWing.FormModule.Domain.IFormModuleMapper') | Provides mapping functionality between editor and entity objects. |
| [IIdConverter&lt;TKey&gt;](CloudyWing.FormModule.Domain.IIdConverter_TKey_.md 'CloudyWing.FormModule.Domain.IIdConverter<TKey>') | Provides conversion functionality between a string representation and a key of type [TKey](CloudyWing.FormModule.Domain.IIdConverter_TKey_.md#CloudyWing.FormModule.Domain.IIdConverter_TKey_.TKey 'CloudyWing.FormModule.Domain.IIdConverter<TKey>.TKey'). |
| [IPagedList&lt;T&gt;](CloudyWing.FormModule.Domain.IPagedList_T_.md 'CloudyWing.FormModule.Domain.IPagedList<T>') | Represents a paged list of items, providing access to the page metadata and the ability to iterate over the items. |
| [IPagingMetadata](CloudyWing.FormModule.Domain.IPagingMetadata.md 'CloudyWing.FormModule.Domain.IPagingMetadata') | Represents metadata for paging. |
| [IQueryableService&lt;TEntity&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>') | Represents a service for querying entities of type [TEntity](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md#CloudyWing.FormModule.Domain.IQueryableService_TEntity_.TEntity 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>.TEntity'). |
| [IUserIdConverter&lt;TUserKey&gt;](CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.md 'CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey>') | Represents a converter for converting between a string representation and the type [TUserKey](CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.md#CloudyWing.FormModule.Domain.IUserIdConverter_TUserKey_.TUserKey 'CloudyWing.FormModule.Domain.IUserIdConverter<TUserKey>.TUserKey') of a user identifier. |
