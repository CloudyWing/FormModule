#### [CloudyWing.FormModule.Domain](index.md 'index')
### [CloudyWing.FormModule.Domain.FormModel](CloudyWing.FormModule.Domain.FormModel.md 'CloudyWing.FormModule.Domain.FormModel')

## IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey> Interface

Represents a service for managing forms.

```csharp
public interface IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey> :
CloudyWing.FormModule.Domain.IQueryableService<TForm>
    where TFormEditor : CloudyWing.FormModule.Domain.FormModel.FormEditor, new()
    where TFormDetailEditor : CloudyWing.FormModule.Domain.FormModel.FormDetailEditor<TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>, new()
    where TFormSectionEditor : CloudyWing.FormModule.Domain.FormModel.FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor>, new()
    where TFormQuestionEditor : CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor<TQuestionChoiceEditor>, new()
    where TQuestionChoiceEditor : CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormEditor'></a>

`TFormEditor`

The type of the form editor.

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormDetailEditor'></a>

`TFormDetailEditor`

The type of the form detail editor.

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormSectionEditor'></a>

`TFormSectionEditor`

The type of the form section editor.

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormQuestionEditor'></a>

`TFormQuestionEditor`

The type of the form question editor.

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TQuestionChoiceEditor'></a>

`TQuestionChoiceEditor`

The type of the question choice editor.

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TKey'></a>

`TKey`

The type of the primary key.

Derived  
&#8627; [FormService&lt;TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.FormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey_ 'CloudyWing.FormModule.Domain.FormModel.FormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TKey,TUserKey>')

Implements [CloudyWing.FormModule.Domain.IQueryableService&lt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')[TForm](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md#CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TForm 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TForm')[&gt;](CloudyWing.FormModule.Domain.IQueryableService_TEntity_.md 'CloudyWing.FormModule.Domain.IQueryableService<TEntity>')
### Methods

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.AllowDeleteAsync(string)'></a>

## IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.AllowDeleteAsync(string) Method

Checks whether deleting a form with the specified ID is allowed.

```csharp
System.Threading.Tasks.Task<bool> AllowDeleteAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.AllowDeleteAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if deleting the form is allowed; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.AllowDetailModifyAsync(string)'></a>

## IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.AllowDetailModifyAsync(string) Method

Checks whether modifying the details of a form with the specified ID is allowed.

```csharp
System.Threading.Tasks.Task<bool> AllowDetailModifyAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.AllowDetailModifyAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if modifying the form details is allowed; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.CreateAsync(TFormEditor)'></a>

## IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.CreateAsync(TFormEditor) Method

Creates a new form using the provided form editor.

```csharp
System.Threading.Tasks.Task<bool> CreateAsync(TFormEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.CreateAsync(TFormEditor).editor'></a>

`editor` [TFormEditor](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md#CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormEditor 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormEditor')

The form editor containing the form data.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form is created successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.CreateDetailsAsync(TFormDetailEditor)'></a>

## IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.CreateDetailsAsync(TFormDetailEditor) Method

Creates the details of a form using the provided form detail editor.

```csharp
System.Threading.Tasks.Task<bool> CreateDetailsAsync(TFormDetailEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.CreateDetailsAsync(TFormDetailEditor).editor'></a>

`editor` [TFormDetailEditor](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md#CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormDetailEditor 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormDetailEditor')

The form detail editor containing the form details data.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form details are created successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.DeleteAsync(string)'></a>

## IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.DeleteAsync(string) Method

Deletes a form with the specified ID.

```csharp
System.Threading.Tasks.Task<bool> DeleteAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.DeleteAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form to delete.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form is deleted successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.DeleteDetailsAsync(string)'></a>

## IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.DeleteDetailsAsync(string) Method

Deletes the details of a form with the specified form ID.

```csharp
System.Threading.Tasks.Task<bool> DeleteDetailsAsync(string? formId);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.DeleteDetailsAsync(string).formId'></a>

`formId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form for which to delete the details.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form details are deleted successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.UpdateAsync(TFormEditor)'></a>

## IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.UpdateAsync(TFormEditor) Method

Updates an existing form using the provided form editor.

```csharp
System.Threading.Tasks.Task<bool> UpdateAsync(TFormEditor editor);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.UpdateAsync(TFormEditor).editor'></a>

`editor` [TFormEditor](CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.md#CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormEditor 'CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormEditor')

The form editor containing the updated form data.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the form is updated successfully; otherwise, `false`.

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.VerifyCodeNotExistsAsync(CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput)'></a>

## IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.VerifyCodeNotExistsAsync(VerifyCodeExistsInput) Method

Verifies if a form with the specified code already exists.

```csharp
System.Threading.Tasks.Task<bool> VerifyCodeNotExistsAsync(CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput input);
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.VerifyCodeNotExistsAsync(CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput).input'></a>

`input` [VerifyCodeExistsInput](CloudyWing.FormModule.Domain.FormModel.md#CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput 'CloudyWing.FormModule.Domain.FormModel.VerifyCodeExistsInput')

The input containing the form code.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
`true` if the code doesn't exist; otherwise, `false`.