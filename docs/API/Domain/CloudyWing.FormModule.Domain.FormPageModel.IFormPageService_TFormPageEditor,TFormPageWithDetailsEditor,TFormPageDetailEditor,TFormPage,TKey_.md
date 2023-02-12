#### [CloudyWing.FormModule.Domain](index.md 'index')
### [CloudyWing.FormModule.Domain.FormPageModel](CloudyWing.FormModule.Domain.FormPageModel.md 'CloudyWing.FormModule.Domain.FormPageModel')

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

Implements [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TFormPage](CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.TFormPage 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.TFormPage')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Methods

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.CreateAsync(TFormPageEditor)'></a>

## IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.CreateAsync(TFormPageEditor) Method

Creates a new form page.

```csharp
System.Threading.Tasks.Task<bool> CreateAsync(TFormPageEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.CreateAsync(TFormPageEditor).editor'></a>

`editor` [TFormPageEditor](CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.TFormPageEditor 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.TFormPageEditor')

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

`editor` [TFormPageEditor](CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.TFormPageEditor 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.TFormPageEditor')

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

`editor` [TFormPageWithDetailsEditor](CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.md#CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_.TFormPageWithDetailsEditor 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>.TFormPageWithDetailsEditor')

The form page with details editor.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form page details are upserted successfully; otherwise, `false`.