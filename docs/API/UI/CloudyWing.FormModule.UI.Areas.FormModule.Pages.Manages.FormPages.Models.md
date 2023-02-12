#### [CloudyWing.FormModule](index.md 'index')

## CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models Namespace
### Classes

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceResponseModel'></a>

## DisplayChoiceResponseModel Class

Represents the display choice response model.

```csharp
public class DisplayChoiceResponseModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DisplayChoiceResponseModel
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceResponseModel.IsChecked'></a>

## DisplayChoiceResponseModel.IsChecked Property

Gets or sets a value indicating whether the choice is checked.

```csharp
public bool IsChecked { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceResponseModel.QuestionChoiceId'></a>

## DisplayChoiceResponseModel.QuestionChoiceId Property

Gets or sets the question choice ID.

```csharp
public string? QuestionChoiceId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceResponseModel.Response'></a>

## DisplayChoiceResponseModel.Response Property

Gets or sets the response to the choice.

```csharp
public string? Response { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceSettingsModel'></a>

## DisplayChoiceSettingsModel Class

Represents the display choice settings model.

```csharp
public class DisplayChoiceSettingsModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DisplayChoiceSettingsModel
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceSettingsModel.HasText'></a>

## DisplayChoiceSettingsModel.HasText Property

Gets or sets a value indicating whether the choice has text.

```csharp
public bool HasText { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceSettingsModel.Id'></a>

## DisplayChoiceSettingsModel.Id Property

Gets or sets the ID of the choice.

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceSettingsModel.Label'></a>

## DisplayChoiceSettingsModel.Label Property

Gets or sets the label of the choice.

```csharp
public string Label { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionResponseModel_TDisplayChoiceResponseModel_'></a>

## DisplayQuestionResponseModel<TDisplayChoiceResponseModel> Class

Represents the display question response model.

```csharp
public class DisplayQuestionResponseModel<TDisplayChoiceResponseModel>
    where TDisplayChoiceResponseModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceResponseModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionResponseModel_TDisplayChoiceResponseModel_.TDisplayChoiceResponseModel'></a>

`TDisplayChoiceResponseModel`

The type of the display choice response model.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DisplayQuestionResponseModel<TDisplayChoiceResponseModel>
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionResponseModel_TDisplayChoiceResponseModel_.Choices'></a>

## DisplayQuestionResponseModel<TDisplayChoiceResponseModel>.Choices Property

Gets or sets the choices for the question response.

```csharp
public System.Collections.Generic.List<TDisplayChoiceResponseModel> Choices { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TDisplayChoiceResponseModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionResponseModel_TDisplayChoiceResponseModel_.TDisplayChoiceResponseModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionResponseModel<TDisplayChoiceResponseModel>.TDisplayChoiceResponseModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionResponseModel_TDisplayChoiceResponseModel_.FormQuestionId'></a>

## DisplayQuestionResponseModel<TDisplayChoiceResponseModel>.FormQuestionId Property

Gets or sets the form question ID.

```csharp
public string FormQuestionId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionResponseModel_TDisplayChoiceResponseModel_.Response'></a>

## DisplayQuestionResponseModel<TDisplayChoiceResponseModel>.Response Property

Gets or sets the response to the question.

```csharp
public string? Response { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionSettingsModel_TDisplayChoiceSettingsModel_'></a>

## DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel> Class

Represents the display question settings model.

```csharp
public class DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>
    where TDisplayChoiceSettingsModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceSettingsModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionSettingsModel_TDisplayChoiceSettingsModel_.TDisplayChoiceSettingsModel'></a>

`TDisplayChoiceSettingsModel`

The type of the display choice settings model.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionSettingsModel_TDisplayChoiceSettingsModel_.Choices'></a>

## DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>.Choices Property

Gets or sets the choices for the question.

```csharp
public System.Collections.Generic.List<TDisplayChoiceSettingsModel> Choices { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TDisplayChoiceSettingsModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionSettingsModel_TDisplayChoiceSettingsModel_.TDisplayChoiceSettingsModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>.TDisplayChoiceSettingsModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionSettingsModel_TDisplayChoiceSettingsModel_.Id'></a>

## DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>.Id Property

Gets or sets the ID of the question.

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionSettingsModel_TDisplayChoiceSettingsModel_.IsRequired'></a>

## DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>.IsRequired Property

Gets or sets a value indicating whether the question is required.

```csharp
public bool IsRequired { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionSettingsModel_TDisplayChoiceSettingsModel_.QuestionText'></a>

## DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>.QuestionText Property

Gets or sets the question text.

```csharp
public string QuestionText { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionSettingsModel_TDisplayChoiceSettingsModel_.QuestionType'></a>

## DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>.QuestionType Property

Gets or sets the question type.

```csharp
public CloudyWing.FormModule.EntityFrameworkCore.QuestionType? QuestionType { get; set; }
```

#### Property Value
[CloudyWing.FormModule.EntityFrameworkCore.QuestionType](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.EntityFrameworkCore.QuestionType 'CloudyWing.FormModule.EntityFrameworkCore.QuestionType')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayResponseModel_TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_'></a>

## DisplayResponseModel<TDisplayQuestionResponseModel,TDisplayChoiceResponseModel> Class

Represents the display response model.

```csharp
public class DisplayResponseModel<TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>
    where TDisplayQuestionResponseModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionResponseModel<TDisplayChoiceResponseModel>, new()
    where TDisplayChoiceResponseModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceResponseModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayResponseModel_TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.TDisplayQuestionResponseModel'></a>

`TDisplayQuestionResponseModel`

The type of the display question response model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayResponseModel_TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.TDisplayChoiceResponseModel'></a>

`TDisplayChoiceResponseModel`

The type of the display choice response model.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DisplayResponseModel<TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayResponseModel_TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.FormId'></a>

## DisplayResponseModel<TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>.FormId Property

Gets or sets the form ID.

```csharp
public string FormId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayResponseModel_TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.FormPageId'></a>

## DisplayResponseModel<TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>.FormPageId Property

Gets or sets the form page ID.

```csharp
public string? FormPageId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayResponseModel_TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.Questions'></a>

## DisplayResponseModel<TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>.Questions Property

Gets or sets the questions in the response.

```csharp
public System.Collections.Generic.List<TDisplayQuestionResponseModel> Questions { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TDisplayQuestionResponseModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayResponseModel_TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.TDisplayQuestionResponseModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayResponseModel<TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>.TDisplayQuestionResponseModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayResponseModel_TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.SecurityCode'></a>

## DisplayResponseModel<TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>.SecurityCode Property

Gets or sets the security code.

```csharp
public string? SecurityCode { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySectionSettingsModel_TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_'></a>

## DisplaySectionSettingsModel<TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel> Class

Represents the display section settings model.

```csharp
public class DisplaySectionSettingsModel<TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>
    where TDisplayQuestionSettingsModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>, new()
    where TDisplayChoiceSettingsModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceSettingsModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySectionSettingsModel_TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.TDisplayQuestionSettingsModel'></a>

`TDisplayQuestionSettingsModel`

The type of the display question settings model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySectionSettingsModel_TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.TDisplayChoiceSettingsModel'></a>

`TDisplayChoiceSettingsModel`

The type of the display choice settings model.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DisplaySectionSettingsModel<TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySectionSettingsModel_TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.Id'></a>

## DisplaySectionSettingsModel<TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>.Id Property

Gets or sets the ID of the section.

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySectionSettingsModel_TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.Name'></a>

## DisplaySectionSettingsModel<TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>.Name Property

Gets or sets the name of the section.

```csharp
public string Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySectionSettingsModel_TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.Questions'></a>

## DisplaySectionSettingsModel<TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>.Questions Property

Gets or sets the questions in the section.

```csharp
public System.Collections.Generic.List<TDisplayQuestionSettingsModel> Questions { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TDisplayQuestionSettingsModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySectionSettingsModel_TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.TDisplayQuestionSettingsModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySectionSettingsModel<TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>.TDisplayQuestionSettingsModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel_TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_'></a>

## DisplaySettingsModel<TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel> Class

Represents the display settings model.

```csharp
public class DisplaySettingsModel<TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>
    where TDisplaySectionSettingsModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySectionSettingsModel<TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel>, new()
    where TDisplayQuestionSettingsModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>, new()
    where TDisplayChoiceSettingsModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceSettingsModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel_TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.TDisplaySectionSettingsModel'></a>

`TDisplaySectionSettingsModel`

The type of the display section settings model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel_TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.TDisplayQuestionSettingsModel'></a>

`TDisplayQuestionSettingsModel`

The type of the display question settings model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel_TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.TDisplayChoiceSettingsModel'></a>

`TDisplayChoiceSettingsModel`

The type of the display choice settings model.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DisplaySettingsModel<TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel_TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.CanUpdate'></a>

## DisplaySettingsModel<TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>.CanUpdate Property

Gets or sets a value indicating whether the form can be updated.

```csharp
public bool CanUpdate { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel_TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.Footer'></a>

## DisplaySettingsModel<TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>.Footer Property

Gets or sets the footer of the form.

```csharp
public string? Footer { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel_TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.FormId'></a>

## DisplaySettingsModel<TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>.FormId Property

Gets or sets the form ID.

```csharp
public string FormId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel_TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.Header'></a>

## DisplaySettingsModel<TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>.Header Property

Gets or sets the header of the form.

```csharp
public string? Header { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel_TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.IsInternal'></a>

## DisplaySettingsModel<TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>.IsInternal Property

Gets or sets a value indicating whether the form is internal.

```csharp
public bool IsInternal { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel_TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.Name'></a>

## DisplaySettingsModel<TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>.Name Property

Gets or sets the name of the form.

```csharp
public string? Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel_TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.Role'></a>

## DisplaySettingsModel<TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>.Role Property

Gets or sets the role of the form.

```csharp
public string? Role { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel_TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.Sections'></a>

## DisplaySettingsModel<TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>.Sections Property

Gets or sets the sections of the form.

```csharp
public System.Collections.Generic.List<TDisplaySectionSettingsModel> Sections { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TDisplaySectionSettingsModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel_TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel_.TDisplaySectionSettingsModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel<TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel>.TDisplaySectionSettingsModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_'></a>

## FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey> Class

Represents the form page display application service.

```csharp
public class FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey> : CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>,
CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService<TDisplaySettingsModel, TDisplaySectionSettingsModel, TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel, TDisplayResponseModel, TDisplayQuestionResponseModel, TDisplayChoiceResponseModel>
    where TDisplaySettingsModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel<TDisplaySectionSettingsModel, TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel>, new()
    where TDisplaySectionSettingsModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySectionSettingsModel<TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel>, new()
    where TDisplayQuestionSettingsModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>, new()
    where TDisplayChoiceSettingsModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceSettingsModel, new()
    where TDisplayResponseModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayResponseModel<TDisplayQuestionResponseModel, TDisplayChoiceResponseModel>, new()
    where TDisplayQuestionResponseModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionResponseModel<TDisplayChoiceResponseModel>, new()
    where TDisplayChoiceResponseModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceResponseModel, new()
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TFormDetailQueryEntity : CloudyWing.FormModule.Domain.FormModel.FormDetailQueryEntity<TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
    where TFormPageDetailQueryEntity : CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailQueryEntity<TFormPageDetail, TFormPage, TForm, TKey>, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TFormSection : CloudyWing.FormModule.EntityFrameworkCore.FormSection<TKey>, new()
    where TFormQuestion : CloudyWing.FormModule.EntityFrameworkCore.FormQuestion<TKey>, new()
    where TQuestionChoice : CloudyWing.FormModule.EntityFrameworkCore.QuestionChoice<TKey>, new()
    where TFormPage : CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>, new()
    where TFormPageDetail : CloudyWing.FormModule.EntityFrameworkCore.FormPageDetail<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplaySettingsModel'></a>

`TDisplaySettingsModel`

The type of the display settings model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplaySectionSettingsModel'></a>

`TDisplaySectionSettingsModel`

The type of the display section settings model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplayQuestionSettingsModel'></a>

`TDisplayQuestionSettingsModel`

The type of the display question settings model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplayChoiceSettingsModel'></a>

`TDisplayChoiceSettingsModel`

The type of the display choice settings model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplayResponseModel'></a>

`TDisplayResponseModel`

The type of the display response model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplayQuestionResponseModel'></a>

`TDisplayQuestionResponseModel`

The type of the display question response model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplayChoiceResponseModel'></a>

`TDisplayChoiceResponseModel`

The type of the display choice response model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDbContext'></a>

`TDbContext`

The type of the database context.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TFormDetailQueryEntity'></a>

`TFormDetailQueryEntity`

The type of the form detail query entity.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TFormPageDetailQueryEntity'></a>

`TFormPageDetailQueryEntity`

The type of the form page detail query entity.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TFormSection'></a>

`TFormSection`

The type of the form section.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TFormQuestion'></a>

`TFormQuestion`

The type of the form question.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TQuestionChoice'></a>

`TQuestionChoice`

The type of the question choice.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TFormPage'></a>

`TFormPage`

The type of the form page.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TFormPageDetail'></a>

`TFormPageDetail`

The type of the form page detail.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [ApplicationService](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService') &#129106; [CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.TKey')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>') &#129106; FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>

Implements [CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>')[TDisplaySettingsModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplaySettingsModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.TDisplaySettingsModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>')[TDisplaySectionSettingsModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplaySectionSettingsModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.TDisplaySectionSettingsModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>')[TDisplayQuestionSettingsModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplayQuestionSettingsModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.TDisplayQuestionSettingsModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>')[TDisplayChoiceSettingsModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplayChoiceSettingsModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.TDisplayChoiceSettingsModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>')[TDisplayResponseModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplayResponseModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.TDisplayResponseModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>')[TDisplayQuestionResponseModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplayQuestionResponseModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.TDisplayQuestionResponseModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>')[TDisplayChoiceResponseModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplayChoiceResponseModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.TDisplayChoiceResponseModel')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>')
### Constructors

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.FormPageDisplayAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.IQueryableService_TFormDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TFormPageDetailQueryEntity_)'></a>

## FormPageDisplayAppService(IServiceProvider, IQueryableService<TFormDetailQueryEntity>, IQueryableService<TFormPageDetailQueryEntity>) Constructor

Initializes a new instance of the [FormPageDisplayAppService&lt;TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>') class.

```csharp
public FormPageDisplayAppService(System.IServiceProvider? serviceProvider, CloudyWing.FormModule.Domain.IQueryableService<TFormDetailQueryEntity> formDetailQueryService, CloudyWing.FormModule.Domain.IQueryableService<TFormPageDetailQueryEntity> formPageDetailQueryService);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.FormPageDisplayAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.IQueryableService_TFormDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TFormPageDetailQueryEntity_).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.FormPageDisplayAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.IQueryableService_TFormDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TFormPageDetailQueryEntity_).formDetailQueryService'></a>

`formDetailQueryService` [CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TFormDetailQueryEntity](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TFormDetailQueryEntity 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.TFormDetailQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')

The form detail query service.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.FormPageDisplayAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.IQueryableService_TFormDetailQueryEntity_,CloudyWing.FormModule.Domain.IQueryableService_TFormPageDetailQueryEntity_).formPageDetailQueryService'></a>

`formPageDetailQueryService` [CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TFormPageDetailQueryEntity](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TFormPageDetailQueryEntity 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.TFormPageDetailQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')

The form page detail query service.
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.FormDetailQueryService'></a>

## FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.FormDetailQueryService Property

Gets the form detail query service.

```csharp
protected CloudyWing.FormModule.Domain.IQueryableService<TFormDetailQueryEntity> FormDetailQueryService { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TFormDetailQueryEntity](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TFormDetailQueryEntity 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.TFormDetailQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.FormPageDetailQueryService'></a>

## FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.FormPageDetailQueryService Property

Gets the form page detail query service.

```csharp
protected CloudyWing.FormModule.Domain.IQueryableService<TFormPageDetailQueryEntity> FormPageDetailQueryService { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TFormPageDetailQueryEntity](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TFormPageDetailQueryEntity 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.TFormPageDetailQueryEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.GetResponseAsync(string,string)'></a>

## FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.GetResponseAsync(string, string) Method

Gets the display response asynchronously.

```csharp
public virtual System.Threading.Tasks.Task<TDisplayResponseModel> GetResponseAsync(string? formId, string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.GetResponseAsync(string,string).formId'></a>

`formId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.GetResponseAsync(string,string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form page.

Implements [GetResponseAsync(string, string)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.GetResponseAsync(string,string) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>.GetResponseAsync(string, string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TDisplayResponseModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplayResponseModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.TDisplayResponseModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The display response model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.GetSettingsAsync(string)'></a>

## FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.GetSettingsAsync(string) Method

Gets the display settings asynchronously.

```csharp
public virtual System.Threading.Tasks.Task<TDisplaySettingsModel> GetSettingsAsync(string? formId);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.GetSettingsAsync(string).formId'></a>

`formId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form.

Implements [GetSettingsAsync(string)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.GetSettingsAsync(string) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>.GetSettingsAsync(string)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TDisplaySettingsModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_.TDisplaySettingsModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>.TDisplaySettingsModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The display settings model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_'></a>

## FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey> Class

Represents the form page index application service.

```csharp
public class FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey> : CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>,
CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService<TIndexInputModel, TIndexRecordModel>
    where TIndexInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IndexInputModel, new()
    where TIndexRecordModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IndexRecordModel, new()
    where TFormPageEditor : CloudyWing.FormModule.Domain.FormPageModel.FormPageEditor, new()
    where TFormPageWithDetailsEditor : CloudyWing.FormModule.Domain.FormPageModel.FormPageWithDetailsEditor<TFormPageDetailEditor>, new()
    where TFormPageDetailEditor : CloudyWing.FormModule.Domain.FormPageModel.FormPageDetailEditor, new()
    where TForm : CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>, new()
    where TFormPage : CloudyWing.FormModule.EntityFrameworkCore.FormPage<TKey>, new()
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TIndexInputModel'></a>

`TIndexInputModel`

The type of the index input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TIndexRecordModel'></a>

`TIndexRecordModel`

The type of the index record model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TFormPageEditor'></a>

`TFormPageEditor`

The type of the form page editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TFormPageWithDetailsEditor'></a>

`TFormPageWithDetailsEditor`

The type of the form page with details editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TFormPageDetailEditor'></a>

`TFormPageDetailEditor`

The type of the form page detail editor.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TForm'></a>

`TForm`

The type of the form.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TFormPage'></a>

`TFormPage`

The type of the form page.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [ApplicationService](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService') &#129106; [CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TKey')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>') &#129106; FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>

Implements [CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel>')[TIndexInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TIndexInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TIndexInputModel')[,](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel>')[TIndexRecordModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TIndexRecordModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TIndexRecordModel')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel>')
### Constructors

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.FormPageIndexAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_,CloudyWing.FormModule.Domain.IQueryableService_TForm_)'></a>

## FormPageIndexAppService(IServiceProvider, IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey>, IQueryableService<TForm>) Constructor

Initializes a new instance of the [FormPageIndexAppService&lt;TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>') class.

```csharp
public FormPageIndexAppService(System.IServiceProvider? serviceProvider, CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey> formPageService, CloudyWing.FormModule.Domain.IQueryableService<TForm> formQueryService);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.FormPageIndexAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_,CloudyWing.FormModule.Domain.IQueryableService_TForm_).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.FormPageIndexAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_,CloudyWing.FormModule.Domain.IQueryableService_TForm_).formPageService'></a>

`formPageService` [CloudyWing.FormModule.Domain.FormPageModel.IFormPageService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPageEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TFormPageEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TFormPageEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPageWithDetailsEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TFormPageWithDetailsEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TFormPageWithDetailsEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPageDetailEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TFormPageDetailEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TFormPageDetailEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPage](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TFormPage 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TFormPage')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')

The form page service.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.FormPageIndexAppService(System.IServiceProvider,CloudyWing.FormModule.Domain.FormPageModel.IFormPageService_TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey_,CloudyWing.FormModule.Domain.IQueryableService_TForm_).formQueryService'></a>

`formQueryService` [CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TForm](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TForm 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TForm')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')

The form query service.
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.FormPageService'></a>

## FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.FormPageService Property

Gets the form page service.

```csharp
protected CloudyWing.FormModule.Domain.FormPageModel.IFormPageService<TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TFormPage,TKey> FormPageService { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.FormPageModel.IFormPageService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPageEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TFormPageEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TFormPageEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPageWithDetailsEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TFormPageWithDetailsEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TFormPageWithDetailsEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPageDetailEditor](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TFormPageDetailEditor 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TFormPageDetailEditor')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TFormPage](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TFormPage 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TFormPage')[,](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.FormPageModel.IFormPageService-5 'CloudyWing.FormModule.Domain.FormPageModel.IFormPageService`5')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.FormQueryService'></a>

## FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.FormQueryService Property

Gets the form query service.

```csharp
protected CloudyWing.FormModule.Domain.IQueryableService<TForm> FormQueryService { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.IQueryableService&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')[TForm](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TForm 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TForm')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IQueryableService-1 'CloudyWing.FormModule.Domain.IQueryableService`1')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.DeleteAsync(string,TIndexInputModel)'></a>

## FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.DeleteAsync(string, TIndexInputModel) Method

Deletes a form page.

```csharp
public virtual System.Threading.Tasks.Task<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<CloudyWing.FormModule.Domain.IPagedList<TIndexRecordModel>>> DeleteAsync(string? id, TIndexInputModel input);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.DeleteAsync(string,TIndexInputModel).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form page to delete.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.DeleteAsync(string,TIndexInputModel).input'></a>

`input` [TIndexInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TIndexInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TIndexInputModel')

The index input model.

Implements [DeleteAsync(string, TIndexInputModel)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.DeleteAsync(string,TIndexInputModel) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel>.DeleteAsync(string, TIndexInputModel)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<T>')[CloudyWing.FormModule.Domain.IPagedList&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[TIndexRecordModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TIndexRecordModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TIndexRecordModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
An application result containing the status and updated paged list.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.GetFormsAsync()'></a>

## FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.GetFormsAsync() Method

Gets the list of forms.

```csharp
public virtual System.Threading.Tasks.Task<System.Collections.Generic.List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>> GetFormsAsync();
```

Implements [GetFormsAsync()](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.GetFormsAsync() 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel>.GetFormsAsync()')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Microsoft.AspNetCore.Mvc.Rendering.SelectListItem](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.Rendering.SelectListItem 'Microsoft.AspNetCore.Mvc.Rendering.SelectListItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The list of select list items representing the forms.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.GetPagedListAsync(TIndexInputModel,int)'></a>

## FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.GetPagedListAsync(TIndexInputModel, int) Method

Gets a paged list of index record models.

```csharp
public virtual System.Threading.Tasks.Task<CloudyWing.FormModule.Domain.IPagedList<TIndexRecordModel>> GetPagedListAsync(TIndexInputModel input, int pageNumber);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.GetPagedListAsync(TIndexInputModel,int).input'></a>

`input` [TIndexInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TIndexInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TIndexInputModel')

The index input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.GetPagedListAsync(TIndexInputModel,int).pageNumber'></a>

`pageNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The page number.

Implements [GetPagedListAsync(TIndexInputModel, int)](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.GetPagedListAsync(TIndexInputModel,int) 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel>.GetPagedListAsync(TIndexInputModel, int)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[CloudyWing.FormModule.Domain.IPagedList&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[TIndexRecordModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_.TIndexRecordModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>.TIndexRecordModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The paged list of index record models.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IndexInputModel'></a>

## IndexInputModel Class

Represents an index input model.

```csharp
public class IndexInputModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IndexInputModel
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IndexInputModel.FormId'></a>

## IndexInputModel.FormId Property

Gets or sets the form ID.

```csharp
public string? FormId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IndexRecordModel'></a>

## IndexRecordModel Class

Represents an index record model.

```csharp
public class IndexRecordModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IndexRecordModel
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IndexRecordModel.CompletionTime'></a>

## IndexRecordModel.CompletionTime Property

Gets or sets the completion time of the form page.

```csharp
public System.Nullable<System.DateTimeOffset> CompletionTime { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IndexRecordModel.FormId'></a>

## IndexRecordModel.FormId Property

Gets or sets the ID of the form that this form page belongs to.

```csharp
public string FormId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IndexRecordModel.Id'></a>

## IndexRecordModel.Id Property

Gets or sets the ID for this form page.

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IndexRecordModel.IP'></a>

## IndexRecordModel.IP Property

Gets or sets the IP address of the user who submitted the form page.

```csharp
public string IP { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IndexRecordModel.SecurityCode'></a>

## IndexRecordModel.SecurityCode Property

Gets or sets the security code for this form page.

```csharp
public string SecurityCode { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Interfaces

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_'></a>

## IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel> Interface

Represents the interface for the form page display application service.

```csharp
public interface IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>
    where TDisplaySettingsModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySettingsModel<TDisplaySectionSettingsModel, TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel>, new()
    where TDisplaySectionSettingsModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplaySectionSettingsModel<TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel>, new()
    where TDisplayQuestionSettingsModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>, new()
    where TDisplayChoiceSettingsModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceSettingsModel, new()
    where TDisplayResponseModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayResponseModel<TDisplayQuestionResponseModel, TDisplayChoiceResponseModel>, new()
    where TDisplayQuestionResponseModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayQuestionResponseModel<TDisplayChoiceResponseModel>, new()
    where TDisplayChoiceResponseModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.DisplayChoiceResponseModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.TDisplaySettingsModel'></a>

`TDisplaySettingsModel`

The type of the display settings model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.TDisplaySectionSettingsModel'></a>

`TDisplaySectionSettingsModel`

The type of the display section settings model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.TDisplayQuestionSettingsModel'></a>

`TDisplayQuestionSettingsModel`

The type of the display question settings model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.TDisplayChoiceSettingsModel'></a>

`TDisplayChoiceSettingsModel`

The type of the display choice settings model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.TDisplayResponseModel'></a>

`TDisplayResponseModel`

The type of the display response model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.TDisplayQuestionResponseModel'></a>

`TDisplayQuestionResponseModel`

The type of the display question response model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.TDisplayChoiceResponseModel'></a>

`TDisplayChoiceResponseModel`

The type of the display choice response model.

Derived  
&#8627; [FormPageDisplayAppService&lt;TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.GetResponseAsync(string,string)'></a>

## IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>.GetResponseAsync(string, string) Method

Gets the display response asynchronously.

```csharp
System.Threading.Tasks.Task<TDisplayResponseModel> GetResponseAsync(string? formId, string? id);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.GetResponseAsync(string,string).formId'></a>

`formId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.GetResponseAsync(string,string).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form page.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TDisplayResponseModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.TDisplayResponseModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>.TDisplayResponseModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The display response model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.GetSettingsAsync(string)'></a>

## IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>.GetSettingsAsync(string) Method

Gets the display settings asynchronously.

```csharp
System.Threading.Tasks.Task<TDisplaySettingsModel> GetSettingsAsync(string? formId);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.GetSettingsAsync(string).formId'></a>

`formId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TDisplaySettingsModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel_.TDisplaySettingsModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel>.TDisplaySettingsModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The display settings model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_'></a>

## IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel> Interface

Represents the interface for the form page index application service.

```csharp
public interface IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel>
    where TIndexInputModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IndexInputModel, new()
    where TIndexRecordModel : CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IndexRecordModel, new()
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.TIndexInputModel'></a>

`TIndexInputModel`

The type of the index input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.TIndexRecordModel'></a>

`TIndexRecordModel`

The type of the index record model.

Derived  
&#8627; [FormPageIndexAppService&lt;TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.DeleteAsync(string,TIndexInputModel)'></a>

## IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel>.DeleteAsync(string, TIndexInputModel) Method

Deletes a form page.

```csharp
System.Threading.Tasks.Task<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<CloudyWing.FormModule.Domain.IPagedList<TIndexRecordModel>>> DeleteAsync(string? id, TIndexInputModel input);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.DeleteAsync(string,TIndexInputModel).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID of the form page to delete.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.DeleteAsync(string,TIndexInputModel).input'></a>

`input` [TIndexInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.TIndexInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel>.TIndexInputModel')

The index input model.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult&lt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<T>')[CloudyWing.FormModule.Domain.IPagedList&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[TIndexRecordModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.TIndexRecordModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel>.TIndexRecordModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
An application result containing the status and updated paged list.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.GetFormsAsync()'></a>

## IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel>.GetFormsAsync() Method

Gets the list of forms.

```csharp
System.Threading.Tasks.Task<System.Collections.Generic.List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>> GetFormsAsync();
```

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Microsoft.AspNetCore.Mvc.Rendering.SelectListItem](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.Rendering.SelectListItem 'Microsoft.AspNetCore.Mvc.Rendering.SelectListItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The list of select list items representing the forms.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.GetPagedListAsync(TIndexInputModel,int)'></a>

## IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel>.GetPagedListAsync(TIndexInputModel, int) Method

Gets a paged list of index record models.

```csharp
System.Threading.Tasks.Task<CloudyWing.FormModule.Domain.IPagedList<TIndexRecordModel>> GetPagedListAsync(TIndexInputModel input, int pageNumber);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.GetPagedListAsync(TIndexInputModel,int).input'></a>

`input` [TIndexInputModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.TIndexInputModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel>.TIndexInputModel')

The index input model.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.GetPagedListAsync(TIndexInputModel,int).pageNumber'></a>

`pageNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The page number.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[CloudyWing.FormModule.Domain.IPagedList&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[TIndexRecordModel](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService_TIndexInputModel,TIndexRecordModel_.TIndexRecordModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.IFormPageIndexAppService<TIndexInputModel,TIndexRecordModel>.TIndexRecordModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IPagedList-1 'CloudyWing.FormModule.Domain.IPagedList`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The paged list of index record models.