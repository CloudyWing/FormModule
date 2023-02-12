#### [CloudyWing.FormModule.Domain](index.md 'index')
### [CloudyWing.FormModule.Domain.SkipFormQuestionModel](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md 'CloudyWing.FormModule.Domain.SkipFormQuestionModel')

## ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey> Interface

Interface for the skip form question service.

```csharp
public interface ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey> :
CloudyWing.FormModule.Domain.IQueryableService<TSkipFormQuestion>
    where TSkipFormQuestionEditor : CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionEditor, new()
    where TSkipFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.SkipFormQuestion<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.TSkipFormQuestionEditor'></a>

`TSkipFormQuestionEditor`

The type of the skip form question editor.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.TSkipFormQuestion'></a>

`TSkipFormQuestion`

The type of the skip form question.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.TKey'></a>

`TKey`

The type of the key.

Derived  
&#8627; [SkipFormQuestionService&lt;TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService_TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.SkipFormQuestionService<TSkipFormQuestionEditor,TDbContext,TSkipFormQuestion,TKey,TUserKey>')

Implements [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TSkipFormQuestion](CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.TSkipFormQuestion 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>.TSkipFormQuestion')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Methods

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.CreateAsync(TSkipFormQuestionEditor)'></a>

## ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>.CreateAsync(TSkipFormQuestionEditor) Method

Creates a new skip form question.

```csharp
System.Threading.Tasks.Task<bool> CreateAsync(TSkipFormQuestionEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.CreateAsync(TSkipFormQuestionEditor).editor'></a>

`editor` [TSkipFormQuestionEditor](CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.TSkipFormQuestionEditor 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>.TSkipFormQuestionEditor')

The skip form question editor.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the skip form question is created successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.DeleteAsync(string)'></a>

## ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>.DeleteAsync(string) Method

Deletes a skip form question.

```csharp
System.Threading.Tasks.Task<bool> DeleteAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.DeleteAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the skip form question.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the skip form question is deleted successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.IsExistsAsync(CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput)'></a>

## ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>.IsExistsAsync(IsExistsInput) Method

Checks if a skip form question exists.

```csharp
System.Threading.Tasks.Task<bool> IsExistsAsync(CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput input);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.IsExistsAsync(CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput).input'></a>

`input` [IsExistsInput](CloudyWing.FormModule.Domain.SkipFormQuestionModel.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.IsExistsInput')

The input parameters.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the skip form question exists; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.UpdateAsync(TSkipFormQuestionEditor)'></a>

## ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>.UpdateAsync(TSkipFormQuestionEditor) Method

Updates an existing skip form question.

```csharp
System.Threading.Tasks.Task<bool> UpdateAsync(TSkipFormQuestionEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.UpdateAsync(TSkipFormQuestionEditor).editor'></a>

`editor` [TSkipFormQuestionEditor](CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.md#CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService_TSkipFormQuestionEditor,TSkipFormQuestion,TKey_.TSkipFormQuestionEditor 'CloudyWing.FormModule.Domain.SkipFormQuestionModel.ISkipFormQuestionService<TSkipFormQuestionEditor,TSkipFormQuestion,TKey>.TSkipFormQuestionEditor')

The skip form question editor.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the skip form question is updated successfully; otherwise, `false`.