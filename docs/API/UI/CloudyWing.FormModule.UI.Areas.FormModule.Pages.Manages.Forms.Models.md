#### [CloudyWing.FormModule](index.md 'index')

## CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models Namespace
### Classes

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsChoiceInputModel'></a>

## EditDetailsChoiceInputModel Class

Represents the input model for a choice in editing form details.

```csharp
public class EditDetailsChoiceInputModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EditDetailsChoiceInputModel
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsChoiceInputModel.HasText'></a>

## EditDetailsChoiceInputModel.HasText Property

Gets or sets whether the choice allows entering additional text.

```csharp
public bool HasText { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsChoiceInputModel.Label'></a>

## EditDetailsChoiceInputModel.Label Property

Gets or sets the label for the choice.

```csharp
public string? Label { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsInputModel_TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_'></a>

## EditDetailsInputModel<TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel> Class

Represents the input model for editing form details.

```csharp
public class EditDetailsInputModel<TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel> :
System.ComponentModel.DataAnnotations.IValidatableObject
    where TEditDetailsSectionInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsSectionInputModel<TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>, new()
    where TEditDetailsQuestionInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>, new()
    where TEditDetailsChoiceInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsChoiceInputModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsInputModel_TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsSectionInputModel'></a>

`TEditDetailsSectionInputModel`

The type of section input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsInputModel_TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsQuestionInputModel'></a>

`TEditDetailsQuestionInputModel`

The type of question input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsInputModel_TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsChoiceInputModel'></a>

`TEditDetailsChoiceInputModel`

The type of choice input model.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EditDetailsInputModel<TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>

Implements [System.ComponentModel.DataAnnotations.IValidatableObject](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.IValidatableObject 'System.ComponentModel.DataAnnotations.IValidatableObject')
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsInputModel_TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.Id'></a>

## EditDetailsInputModel<TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.Id Property

Gets or sets the primary key for this form.

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsInputModel_TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.Sections'></a>

## EditDetailsInputModel<TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.Sections Property

Gets or sets the sections of the form.

```csharp
public System.Collections.Generic.List<TEditDetailsSectionInputModel> Sections { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TEditDetailsSectionInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsInputModel_TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsSectionInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsInputModel<TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.TEditDetailsSectionInputModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsInputModel_TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.Validate(System.ComponentModel.DataAnnotations.ValidationContext)'></a>

## EditDetailsInputModel<TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.Validate(ValidationContext) Method

Validates the input model.

```csharp
public virtual System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsInputModel_TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.Validate(System.ComponentModel.DataAnnotations.ValidationContext).validationContext'></a>

`validationContext` [System.ComponentModel.DataAnnotations.ValidationContext](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.ValidationContext 'System.ComponentModel.DataAnnotations.ValidationContext')

The validation context.

Implements [Validate(ValidationContext)](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.IValidatableObject.Validate#System_ComponentModel_DataAnnotations_IValidatableObject_Validate_System_ComponentModel_DataAnnotations_ValidationContext_ 'System.ComponentModel.DataAnnotations.IValidatableObject.Validate(System.ComponentModel.DataAnnotations.ValidationContext)')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.ComponentModel.DataAnnotations.ValidationResult](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.ValidationResult 'System.ComponentModel.DataAnnotations.ValidationResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The collection of validation results.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsQuestionInputModel_TEditDetailsChoiceInputModel_'></a>

## EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel> Class

Represents the input model for a form question in editing form details.

```csharp
public class EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel> :
System.ComponentModel.DataAnnotations.IValidatableObject
    where TEditDetailsChoiceInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsChoiceInputModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsQuestionInputModel_TEditDetailsChoiceInputModel_.TEditDetailsChoiceInputModel'></a>

`TEditDetailsChoiceInputModel`

The type of choice input model.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>

Implements [System.ComponentModel.DataAnnotations.IValidatableObject](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.IValidatableObject 'System.ComponentModel.DataAnnotations.IValidatableObject')
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsQuestionInputModel_TEditDetailsChoiceInputModel_.Choices'></a>

## EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>.Choices Property

Gets or sets the choices for the question.

```csharp
public System.Collections.Generic.List<TEditDetailsChoiceInputModel> Choices { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TEditDetailsChoiceInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsQuestionInputModel_TEditDetailsChoiceInputModel_.TEditDetailsChoiceInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>.TEditDetailsChoiceInputModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsQuestionInputModel_TEditDetailsChoiceInputModel_.IsRequired'></a>

## EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>.IsRequired Property

Gets or sets whether the question is required.

```csharp
public bool IsRequired { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsQuestionInputModel_TEditDetailsChoiceInputModel_.QuestionText'></a>

## EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>.QuestionText Property

Gets or sets the question text.

```csharp
public string? QuestionText { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsQuestionInputModel_TEditDetailsChoiceInputModel_.QuestionType'></a>

## EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>.QuestionType Property

Gets or sets the question type.

```csharp
public CloudyWing.FormModule.EntityFrameworkCore.QuestionType? QuestionType { get; set; }
```

#### Property Value
[CloudyWing.FormModule.EntityFrameworkCore.QuestionType](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.EntityFrameworkCore.QuestionType 'CloudyWing.FormModule.EntityFrameworkCore.QuestionType')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsQuestionInputModel_TEditDetailsChoiceInputModel_.Validate(System.ComponentModel.DataAnnotations.ValidationContext)'></a>

## EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>.Validate(ValidationContext) Method

Validates the question input model.

```csharp
public virtual System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsQuestionInputModel_TEditDetailsChoiceInputModel_.Validate(System.ComponentModel.DataAnnotations.ValidationContext).validationContext'></a>

`validationContext` [System.ComponentModel.DataAnnotations.ValidationContext](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.ValidationContext 'System.ComponentModel.DataAnnotations.ValidationContext')

The validation context.

Implements [Validate(ValidationContext)](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.IValidatableObject.Validate#System_ComponentModel_DataAnnotations_IValidatableObject_Validate_System_ComponentModel_DataAnnotations_ValidationContext_ 'System.ComponentModel.DataAnnotations.IValidatableObject.Validate(System.ComponentModel.DataAnnotations.ValidationContext)')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.ComponentModel.DataAnnotations.ValidationResult](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.ValidationResult 'System.ComponentModel.DataAnnotations.ValidationResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The collection of validation results.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsSectionInputModel_TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_'></a>

## EditDetailsSectionInputModel<TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel> Class

Represents the input model for a form section in editing form details.

```csharp
public class EditDetailsSectionInputModel<TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel> :
System.ComponentModel.DataAnnotations.IValidatableObject
    where TEditDetailsQuestionInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>, new()
    where TEditDetailsChoiceInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsChoiceInputModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsSectionInputModel_TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsQuestionInputModel'></a>

`TEditDetailsQuestionInputModel`

The type of question input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsSectionInputModel_TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsChoiceInputModel'></a>

`TEditDetailsChoiceInputModel`

The type of choice input model.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EditDetailsSectionInputModel<TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>

Implements [System.ComponentModel.DataAnnotations.IValidatableObject](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.IValidatableObject 'System.ComponentModel.DataAnnotations.IValidatableObject')
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsSectionInputModel_TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.Name'></a>

## EditDetailsSectionInputModel<TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.Name Property

Gets or sets the name of the section.

```csharp
public string? Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsSectionInputModel_TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.Questions'></a>

## EditDetailsSectionInputModel<TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.Questions Property

Gets or sets the questions in the section.

```csharp
public System.Collections.Generic.List<TEditDetailsQuestionInputModel> Questions { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TEditDetailsQuestionInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsSectionInputModel_TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsQuestionInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsSectionInputModel<TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.TEditDetailsQuestionInputModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsSectionInputModel_TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.Validate(System.ComponentModel.DataAnnotations.ValidationContext)'></a>

## EditDetailsSectionInputModel<TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.Validate(ValidationContext) Method

Validates the section input model.

```csharp
public virtual System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsSectionInputModel_TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.Validate(System.ComponentModel.DataAnnotations.ValidationContext).validationContext'></a>

`validationContext` [System.ComponentModel.DataAnnotations.ValidationContext](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.ValidationContext 'System.ComponentModel.DataAnnotations.ValidationContext')

The validation context.

Implements [Validate(ValidationContext)](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.IValidatableObject.Validate#System_ComponentModel_DataAnnotations_IValidatableObject_Validate_System_ComponentModel_DataAnnotations_ValidationContext_ 'System.ComponentModel.DataAnnotations.IValidatableObject.Validate(System.ComponentModel.DataAnnotations.ValidationContext)')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.ComponentModel.DataAnnotations.ValidationResult](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.ValidationResult 'System.ComponentModel.DataAnnotations.ValidationResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The collection of validation results.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsViewModel'></a>

## EditDetailsViewModel Class

Represents the view model for editing form details.

```csharp
public class EditDetailsViewModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EditDetailsViewModel
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsViewModel.Code'></a>

## EditDetailsViewModel.Code Property

Gets or sets the code for the form.

```csharp
public string? Code { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsViewModel.EndTime'></a>

## EditDetailsViewModel.EndTime Property

Gets or sets the end time for the form.

```csharp
public System.DateTimeOffset EndTime { get; set; }
```

#### Property Value
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsViewModel.Footer'></a>

## EditDetailsViewModel.Footer Property

Gets or sets the footer for the form.

```csharp
public string? Footer { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsViewModel.Header'></a>

## EditDetailsViewModel.Header Property

Gets or sets the header for the form.

```csharp
public string? Header { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsViewModel.Id'></a>

## EditDetailsViewModel.Id Property

Gets or sets the primary key for this form.

```csharp
public string? Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsViewModel.Name'></a>

## EditDetailsViewModel.Name Property

Gets or sets the name for the form.

```csharp
public string? Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsViewModel.StartTime'></a>

## EditDetailsViewModel.StartTime Property

Gets or sets the start time for the form.

```csharp
public System.DateTimeOffset StartTime { get; set; }
```

#### Property Value
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel'></a>

## EditInputModel Class

Represents an edit input model for the form.

```csharp
public class EditInputModel :
System.ComponentModel.DataAnnotations.IValidatableObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EditInputModel

Implements [System.ComponentModel.DataAnnotations.IValidatableObject](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.IValidatableObject 'System.ComponentModel.DataAnnotations.IValidatableObject')
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel.CanUpdate'></a>

## EditInputModel.CanUpdate Property

Gets or sets whether can be updated after submission.

```csharp
public bool CanUpdate { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel.Code'></a>

## EditInputModel.Code Property

Gets or sets the code for the form.

```csharp
public string? Code { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel.CompletionMessage'></a>

## EditInputModel.CompletionMessage Property

Gets or sets the message to be displayed upon completion.

```csharp
public string? CompletionMessage { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel.EndTime'></a>

## EditInputModel.EndTime Property

Gets or sets the end time for the form.

```csharp
public System.DateTimeOffset EndTime { get; set; }
```

#### Property Value
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel.Footer'></a>

## EditInputModel.Footer Property

Gets or sets the footer for the form.

```csharp
public string? Footer { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel.Header'></a>

## EditInputModel.Header Property

Gets or sets the header for the form.

```csharp
public string? Header { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel.Id'></a>

## EditInputModel.Id Property

Gets or sets the primary key for this form.

```csharp
public string? Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel.IsInternal'></a>

## EditInputModel.IsInternal Property

Gets or sets whether this is an internal form.

```csharp
public bool IsInternal { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel.Name'></a>

## EditInputModel.Name Property

Gets or sets the name for the form.

```csharp
public string? Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel.Role'></a>

## EditInputModel.Role Property

Gets or sets the role.

```csharp
public string? Role { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel.StartTime'></a>

## EditInputModel.StartTime Property

Gets or sets the start time for the form.

```csharp
public System.DateTimeOffset StartTime { get; set; }
```

#### Property Value
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel.Validate(System.ComponentModel.DataAnnotations.ValidationContext)'></a>

## EditInputModel.Validate(ValidationContext) Method

Validates the input model.

```csharp
public virtual System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel.Validate(System.ComponentModel.DataAnnotations.ValidationContext).validationContext'></a>

`validationContext` [System.ComponentModel.DataAnnotations.ValidationContext](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.ValidationContext 'System.ComponentModel.DataAnnotations.ValidationContext')

The validation context.

Implements [Validate(ValidationContext)](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.IValidatableObject.Validate#System_ComponentModel_DataAnnotations_IValidatableObject_Validate_System_ComponentModel_DataAnnotations_ValidationContext_ 'System.ComponentModel.DataAnnotations.IValidatableObject.Validate(System.ComponentModel.DataAnnotations.ValidationContext)')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.ComponentModel.DataAnnotations.ValidationResult](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.ValidationResult 'System.ComponentModel.DataAnnotations.ValidationResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection of validation results.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_'></a>

## FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey> Class

Represents the application service for form edit.

```csharp
public class FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey> : CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>,
CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService<TEditInputModel>
    where TEditInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel, new()
    where TFormEditor : CloudyWing.FormModule.Domain.FormModel.FormEditor, new()
    where TFormDetailEditor : CloudyWing.FormModule.Domain.FormModel.FormDetailEditor<TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>, new()
    where TFormSectionEditor : CloudyWing.FormModule.Domain.FormModel.FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor>, new()
    where TFormQuestionEditor : CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor<TQuestionChoiceEditor>, new()
    where TQuestionChoiceEditor : CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TEditInputModel'></a>

`TEditInputModel`

The type of the edit input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormEditor'></a>

`TFormEditor`

The type of the form editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormDetailEditor'></a>

`TFormDetailEditor`

The type of the form detail editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormSectionEditor'></a>

`TFormSectionEditor`

The type of the form section editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormQuestionEditor'></a>

`TFormQuestionEditor`

The type of the form question editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TQuestionChoiceEditor'></a>

`TQuestionChoiceEditor`

The type of the question choice editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [ApplicationService](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService') &#129106; [CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TKey')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>') &#129106; FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>

Implements [CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService_TEditInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService<TEditInputModel>')[TEditInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TEditInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TEditInputModel')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService_TEditInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService<TEditInputModel>')
### Constructors

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.FormEditAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_)'></a>

## FormEditAppService(IServiceProvider, IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>) Constructor

Initializes a new instance of the [FormEditAppService&lt;TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>') class.

```csharp
public FormEditAppService(System.IServiceProvider? serviceProvider, CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey> formService);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.FormEditAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.FormEditAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_).formService'></a>

`formService` [CloudyWing.FormModule.Domain.FormModel.IFormService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormDetailEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormDetailEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormDetailEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormSectionEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormSectionEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormSectionEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormQuestionEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormQuestionEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormQuestionEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TQuestionChoiceEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TQuestionChoiceEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TQuestionChoiceEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TForm](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TForm 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TForm')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')

The form service.
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.FormService'></a>

## FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.FormService Property

Gets the form service.

```csharp
protected CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey> FormService { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.FormModel.IFormService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormDetailEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormDetailEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormDetailEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormSectionEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormSectionEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormSectionEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormQuestionEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormQuestionEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormQuestionEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TQuestionChoiceEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TQuestionChoiceEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TQuestionChoiceEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TForm](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TForm 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TForm')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.GetInputAsync(string)'></a>

## FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.GetInputAsync(string) Method

Gets the edit input.

```csharp
public virtual System.Threading.Tasks.Task<TEditInputModel> GetInputAsync(string id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.GetInputAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the input.

Implements [GetInputAsync(string)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService_TEditInputModel_.GetInputAsync(string) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService<TEditInputModel>.GetInputAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEditInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TEditInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TEditInputModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The edit input.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.UpsertAsync(TEditInputModel)'></a>

## FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.UpsertAsync(TEditInputModel) Method

Upserts the input.

```csharp
public virtual System.Threading.Tasks.Task<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult> UpsertAsync(TEditInputModel? input);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.UpsertAsync(TEditInputModel).input'></a>

`input` [TEditInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TEditInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TEditInputModel')

The input to upsert.

Implements [UpsertAsync(TEditInputModel)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService_TEditInputModel_.UpsertAsync(TEditInputModel) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService<TEditInputModel>.UpsertAsync(TEditInputModel)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ApplicationResult](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The application result.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_'></a>

## FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey> Class

Represents the application service for form edit details.

```csharp
public class FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey> : CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>,
CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService<TEditDetailsViewModel, TEditDetailsInputModel, TEditDetailsSectionInputModel, TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>
    where TEditDetailsViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsViewModel, new()
    where TEditDetailsInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsInputModel<TEditDetailsSectionInputModel, TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>, new()
    where TEditDetailsSectionInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsSectionInputModel<TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>, new()
    where TEditDetailsQuestionInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>, new()
    where TEditDetailsChoiceInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsChoiceInputModel, new()
    where TFormEditor : CloudyWing.FormModule.Domain.FormModel.FormEditor, new()
    where TFormDetailEditor : CloudyWing.FormModule.Domain.FormModel.FormDetailEditor<TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>, new()
    where TFormSectionEditor : CloudyWing.FormModule.Domain.FormModel.FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor>, new()
    where TFormQuestionEditor : CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor<TQuestionChoiceEditor>, new()
    where TQuestionChoiceEditor : CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor, new()
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TFormDetailQueryEntity : CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity<TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TFormSection : CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>, new()
    where TFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>, new()
    where TQuestionChoice : CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TEditDetailsViewModel'></a>

`TEditDetailsViewModel`

The type of the edit details view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TEditDetailsInputModel'></a>

`TEditDetailsInputModel`

The type of the edit details input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TEditDetailsSectionInputModel'></a>

`TEditDetailsSectionInputModel`

The type of the edit details section input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TEditDetailsQuestionInputModel'></a>

`TEditDetailsQuestionInputModel`

The type of the edit details question input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TEditDetailsChoiceInputModel'></a>

`TEditDetailsChoiceInputModel`

The type of the edit details choice input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormEditor'></a>

`TFormEditor`

The type of the form editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormDetailEditor'></a>

`TFormDetailEditor`

The type of the form detail editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormSectionEditor'></a>

`TFormSectionEditor`

The type of the form section editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestionEditor'></a>

`TFormQuestionEditor`

The type of the form question editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TQuestionChoiceEditor'></a>

`TQuestionChoiceEditor`

The type of the question choice editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormDetailQueryEntity'></a>

`TFormDetailQueryEntity`

The type of the form detail query entity.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormSection'></a>

`TFormSection`

The type of the form section.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestion'></a>

`TFormQuestion`

The type of the form question.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TQuestionChoice'></a>

`TQuestionChoice`

The type of the question choice.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [ApplicationService](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService') &#129106; [CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TKey')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>') &#129106; FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>

Implements [CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>')[TEditDetailsViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TEditDetailsViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TEditDetailsViewModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>')[TEditDetailsInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TEditDetailsInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TEditDetailsInputModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>')[TEditDetailsSectionInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TEditDetailsSectionInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TEditDetailsSectionInputModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>')[TEditDetailsQuestionInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TEditDetailsQuestionInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TEditDetailsQuestionInputModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>')[TEditDetailsChoiceInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TEditDetailsChoiceInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TEditDetailsChoiceInputModel')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>')
### Constructors

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.FormEditDetailsAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_,CloudyWing.FormModule.Domain.IQueryableService_TFormDetailQueryEntity_)'></a>

## FormEditDetailsAppService(IServiceProvider, IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>, IQueryableService<TFormDetailQueryEntity>) Constructor

Initializes a new instance of the [FormEditDetailsAppService&lt;TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>') class.

```csharp
public FormEditDetailsAppService(System.IServiceProvider? serviceProvider, CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey> formService, CloudyWing.FormModule.Domain.IQueryableService<TFormDetailQueryEntity> formDetailQueryService);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.FormEditDetailsAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_,CloudyWing.FormModule.Domain.IQueryableService_TFormDetailQueryEntity_).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.FormEditDetailsAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_,CloudyWing.FormModule.Domain.IQueryableService_TFormDetailQueryEntity_).formService'></a>

`formService` [CloudyWing.FormModule.Domain.FormModel.IFormService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormDetailEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormDetailEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormDetailEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormSectionEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormSectionEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormSectionEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormQuestionEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestionEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormQuestionEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TQuestionChoiceEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TQuestionChoiceEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TQuestionChoiceEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TForm](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TForm 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TForm')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')

The form service.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.FormEditDetailsAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_,CloudyWing.FormModule.Domain.IQueryableService_TFormDetailQueryEntity_).formDetailQueryService'></a>

`formDetailQueryService` [CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TFormDetailQueryEntity](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormDetailQueryEntity 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormDetailQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')

The form detail query service.
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.FormDetailQueryService'></a>

## FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.FormDetailQueryService Property

Gets the form detail query service.

```csharp
protected CloudyWing.FormModule.Domain.IQueryableService<TFormDetailQueryEntity> FormDetailQueryService { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TFormDetailQueryEntity](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormDetailQueryEntity 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormDetailQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.FormService'></a>

## FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.FormService Property

Gets the form service.

```csharp
protected CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey> FormService { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.FormModel.IFormService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormDetailEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormDetailEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormDetailEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormSectionEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormSectionEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormSectionEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormQuestionEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TFormQuestionEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TFormQuestionEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TQuestionChoiceEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TQuestionChoiceEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TQuestionChoiceEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TForm](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TForm 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TForm')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.DeleteAsync(string)'></a>

## FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.DeleteAsync(string) Method

Deletes the details.

```csharp
public virtual System.Threading.Tasks.Task<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult> DeleteAsync(string id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.DeleteAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the details to delete.

Implements [DeleteAsync(string)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.DeleteAsync(string) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.DeleteAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ApplicationResult](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The application result.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.GetListAsync(string)'></a>

## FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.GetListAsync(string) Method

Gets the list of sections and questions.

```csharp
public virtual System.Threading.Tasks.Task<System.Collections.Generic.List<TEditDetailsSectionInputModel>> GetListAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.GetListAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the details.

Implements [GetListAsync(string)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.GetListAsync(string) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.GetListAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TEditDetailsSectionInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TEditDetailsSectionInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TEditDetailsSectionInputModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The list of sections and questions.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.GetViewAsync(string)'></a>

## FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.GetViewAsync(string) Method

Gets the details view.

```csharp
public virtual System.Threading.Tasks.Task<TEditDetailsViewModel> GetViewAsync(string id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.GetViewAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the details.

Implements [GetViewAsync(string)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.GetViewAsync(string) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.GetViewAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEditDetailsViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TEditDetailsViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TEditDetailsViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The details view.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.UpsertAsync(TEditDetailsInputModel)'></a>

## FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.UpsertAsync(TEditDetailsInputModel) Method

Upserts the details.

```csharp
public virtual System.Threading.Tasks.Task<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult> UpsertAsync(TEditDetailsInputModel? input);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.UpsertAsync(TEditDetailsInputModel).input'></a>

`input` [TEditDetailsInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_.TEditDetailsInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>.TEditDetailsInputModel')

The input to upsert.

Implements [UpsertAsync(TEditDetailsInputModel)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.UpsertAsync(TEditDetailsInputModel) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.UpsertAsync(TEditDetailsInputModel)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ApplicationResult](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The application result.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_'></a>

## FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey> Class

Represents the application service for form index.

```csharp
public class FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey> : CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>,
CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService<TIndexRecordModel>
    where TIndexRecordModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IndexRecordModel, new()
    where TFormEditor : CloudyWing.FormModule.Domain.FormModel.FormEditor, new()
    where TFormDetailEditor : CloudyWing.FormModule.Domain.FormModel.FormDetailEditor<TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>, new()
    where TFormSectionEditor : CloudyWing.FormModule.Domain.FormModel.FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor>, new()
    where TFormQuestionEditor : CloudyWing.FormModule.Domain.FormModel.FormQuestionEditor<TQuestionChoiceEditor>, new()
    where TQuestionChoiceEditor : CloudyWing.FormModule.Domain.FormModel.QuestionChoiceEditor, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TIndexRecordModel'></a>

`TIndexRecordModel`

The type of the index record model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormEditor'></a>

`TFormEditor`

The type of the form editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormDetailEditor'></a>

`TFormDetailEditor`

The type of the form detail editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormSectionEditor'></a>

`TFormSectionEditor`

The type of the form section editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormQuestionEditor'></a>

`TFormQuestionEditor`

The type of the form question editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TQuestionChoiceEditor'></a>

`TQuestionChoiceEditor`

The type of the question choice editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [ApplicationService](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService') &#129106; [CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TKey')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>') &#129106; FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>

Implements [CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService_TIndexRecordModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService<TIndexRecordModel>')[TIndexRecordModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TIndexRecordModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TIndexRecordModel')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService_TIndexRecordModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService<TIndexRecordModel>')
### Constructors

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.FormIndexAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_)'></a>

## FormIndexAppService(IServiceProvider, IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>) Constructor

Initializes a new instance of the [FormIndexAppService&lt;TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>') class.

```csharp
public FormIndexAppService(System.IServiceProvider? serviceProvider, CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey> formService);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.FormIndexAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.FormIndexAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormModel.IFormService_TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_).formService'></a>

`formService` [CloudyWing.FormModule.Domain.FormModel.IFormService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormDetailEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormDetailEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormDetailEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormSectionEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormSectionEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormSectionEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormQuestionEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormQuestionEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormQuestionEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TQuestionChoiceEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TQuestionChoiceEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TQuestionChoiceEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TForm](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TForm 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TForm')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')

The form service.
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.FormService'></a>

## FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.FormService Property

Gets the form service.

```csharp
protected CloudyWing.FormModule.Domain.FormModel.IFormService<TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey> FormService { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.FormModel.IFormService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormDetailEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormDetailEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormDetailEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormSectionEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormSectionEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormSectionEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TFormQuestionEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TFormQuestionEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TFormQuestionEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TQuestionChoiceEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TQuestionChoiceEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TQuestionChoiceEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TForm](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TForm 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TForm')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormModel.IFormService-7 'CloudyWing.FormModule.Domain.FormModel.IFormService`7')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.DeleteAsync(string)'></a>

## FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.DeleteAsync(string) Method

Deletes a record.

```csharp
public virtual System.Threading.Tasks.Task<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<CloudyWing.FormModule.Domain.IPagedList<TIndexRecordModel>>> DeleteAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.DeleteAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the record to delete.

Implements [DeleteAsync(string)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService_TIndexRecordModel_.DeleteAsync(string) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService<TIndexRecordModel>.DeleteAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<T>')[CloudyWing.FormModule.Domain.IPagedList&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[TIndexRecordModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TIndexRecordModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TIndexRecordModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The application result.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.GetPagedListAsync(int)'></a>

## FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.GetPagedListAsync(int) Method

Gets a paged list of index records.

```csharp
public virtual System.Threading.Tasks.Task<CloudyWing.FormModule.Domain.IPagedList<TIndexRecordModel>> GetPagedListAsync(int pageNumber);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.GetPagedListAsync(int).pageNumber'></a>

`pageNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The page number.

Implements [GetPagedListAsync(int)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService_TIndexRecordModel_.GetPagedListAsync(int) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService<TIndexRecordModel>.GetPagedListAsync(int)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[CloudyWing.FormModule.Domain.IPagedList&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[TIndexRecordModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_.TIndexRecordModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>.TIndexRecordModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The paged list of index records.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IndexRecordModel'></a>

## IndexRecordModel Class

Represents an index record model.

```csharp
public class IndexRecordModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IndexRecordModel
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IndexRecordModel.Code'></a>

## IndexRecordModel.Code Property

Gets or sets the code for the form.

```csharp
public string? Code { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IndexRecordModel.EndTime'></a>

## IndexRecordModel.EndTime Property

Gets or sets the end time for the form.

```csharp
public System.DateTimeOffset EndTime { get; set; }
```

#### Property Value
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IndexRecordModel.Id'></a>

## IndexRecordModel.Id Property

Gets or sets the id for the form.

```csharp
public string? Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IndexRecordModel.Name'></a>

## IndexRecordModel.Name Property

Gets or sets the name for the form.

```csharp
public string? Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IndexRecordModel.StartTime'></a>

## IndexRecordModel.StartTime Property

Gets or sets the start time for the form.

```csharp
public System.DateTimeOffset StartTime { get; set; }
```

#### Property Value
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')
### Interfaces

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService_TEditInputModel_'></a>

## IFormEditAppService<TEditInputModel> Interface

Represents the interface for a form edit application service.

```csharp
public interface IFormEditAppService<TEditInputModel>
    where TEditInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService_TEditInputModel_.TEditInputModel'></a>

`TEditInputModel`

The type of the edit input model.

Derived  
&#8627; [FormEditAppService&lt;TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService_TEditInputModel_.GetInputAsync(string)'></a>

## IFormEditAppService<TEditInputModel>.GetInputAsync(string) Method

Gets the edit input.

```csharp
System.Threading.Tasks.Task<TEditInputModel> GetInputAsync(string id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService_TEditInputModel_.GetInputAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the input.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEditInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService_TEditInputModel_.TEditInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService<TEditInputModel>.TEditInputModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The edit input.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService_TEditInputModel_.UpsertAsync(TEditInputModel)'></a>

## IFormEditAppService<TEditInputModel>.UpsertAsync(TEditInputModel) Method

Upserts the input.

```csharp
System.Threading.Tasks.Task<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult> UpsertAsync(TEditInputModel? input);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService_TEditInputModel_.UpsertAsync(TEditInputModel).input'></a>

`input` [TEditInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService_TEditInputModel_.TEditInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditAppService<TEditInputModel>.TEditInputModel')

The input to upsert.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ApplicationResult](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The application result.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_'></a>

## IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel> Interface

Represents the interface for a form edit details application service.

```csharp
public interface IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>
    where TEditDetailsViewModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsViewModel, new()
    where TEditDetailsInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsInputModel<TEditDetailsSectionInputModel, TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>, new()
    where TEditDetailsSectionInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsSectionInputModel<TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>, new()
    where TEditDetailsQuestionInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>, new()
    where TEditDetailsChoiceInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.EditDetailsChoiceInputModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsViewModel'></a>

`TEditDetailsViewModel`

The type of the edit details view model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsInputModel'></a>

`TEditDetailsInputModel`

The type of the edit details input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsSectionInputModel'></a>

`TEditDetailsSectionInputModel`

The type of the edit details section input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsQuestionInputModel'></a>

`TEditDetailsQuestionInputModel`

The type of the edit details question input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsChoiceInputModel'></a>

`TEditDetailsChoiceInputModel`

The type of the edit details choice input model.

Derived  
&#8627; [FormEditDetailsAppService&lt;TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.DeleteAsync(string)'></a>

## IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.DeleteAsync(string) Method

Deletes the details.

```csharp
System.Threading.Tasks.Task<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult> DeleteAsync(string id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.DeleteAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the details to delete.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ApplicationResult](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The application result.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.GetListAsync(string)'></a>

## IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.GetListAsync(string) Method

Gets the list of sections and questions.

```csharp
System.Threading.Tasks.Task<System.Collections.Generic.List<TEditDetailsSectionInputModel>> GetListAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.GetListAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the details.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TEditDetailsSectionInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsSectionInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.TEditDetailsSectionInputModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The list of sections and questions.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.GetViewAsync(string)'></a>

## IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.GetViewAsync(string) Method

Gets the details view.

```csharp
System.Threading.Tasks.Task<TEditDetailsViewModel> GetViewAsync(string id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.GetViewAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the details.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEditDetailsViewModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.TEditDetailsViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The details view.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.UpsertAsync(TEditDetailsInputModel)'></a>

## IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.UpsertAsync(TEditDetailsInputModel) Method

Upserts the details.

```csharp
System.Threading.Tasks.Task<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult> UpsertAsync(TEditDetailsInputModel? input);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.UpsertAsync(TEditDetailsInputModel).input'></a>

`input` [TEditDetailsInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel_.TEditDetailsInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel>.TEditDetailsInputModel')

The input to upsert.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ApplicationResult](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The application result.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService_TIndexRecordModel_'></a>

## IFormIndexAppService<TIndexRecordModel> Interface

Represents the interface for a form index application service.

```csharp
public interface IFormIndexAppService<TIndexRecordModel>
    where TIndexRecordModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IndexRecordModel
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService_TIndexRecordModel_.TIndexRecordModel'></a>

`TIndexRecordModel`

The type of the index record model.

Derived  
&#8627; [FormIndexAppService&lt;TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService_TIndexRecordModel_.DeleteAsync(string)'></a>

## IFormIndexAppService<TIndexRecordModel>.DeleteAsync(string) Method

Deletes a record.

```csharp
System.Threading.Tasks.Task<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<CloudyWing.FormModule.Domain.IPagedList<TIndexRecordModel>>> DeleteAsync(string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService_TIndexRecordModel_.DeleteAsync(string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the record to delete.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<T>')[CloudyWing.FormModule.Domain.IPagedList&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[TIndexRecordModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService_TIndexRecordModel_.TIndexRecordModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService<TIndexRecordModel>.TIndexRecordModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The application result.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService_TIndexRecordModel_.GetPagedListAsync(int)'></a>

## IFormIndexAppService<TIndexRecordModel>.GetPagedListAsync(int) Method

Gets a paged list of index records.

```csharp
System.Threading.Tasks.Task<CloudyWing.FormModule.Domain.IPagedList<TIndexRecordModel>> GetPagedListAsync(int pageNumber);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService_TIndexRecordModel_.GetPagedListAsync(int).pageNumber'></a>

`pageNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The page number.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[CloudyWing.FormModule.Domain.IPagedList&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[TIndexRecordModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService_TIndexRecordModel_.TIndexRecordModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.IFormIndexAppService<TIndexRecordModel>.TIndexRecordModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The paged list of index records.