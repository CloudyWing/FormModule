#### [CloudyWing.FormModule](index.md 'index')

## CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models Namespace
### Classes

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult'></a>

## ApplicationResult Class

Represents the result of an application operation.

```csharp
public class ApplicationResult
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ApplicationResult

Derived  
&#8627; [ApplicationResult&lt;T&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<T>')
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult.IsOk'></a>

## ApplicationResult.IsOk Property

Gets or sets a value indicating whether the operation is successful.

```csharp
public bool IsOk { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult.Message'></a>

## ApplicationResult.Message Property

Gets or sets a message associated with the result.

```csharp
public string? Message { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_'></a>

## ApplicationResult<T> Class

Represents the result of an application operation with additional data.

```csharp
public class ApplicationResult<T> : CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_.T'></a>

`T`

The type of the additional data.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ApplicationResult](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult') &#129106; ApplicationResult<T>
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_.Data'></a>

## ApplicationResult<T>.Data Property

Gets or sets the additional data.

```csharp
public T? Data { get; set; }
```

#### Property Value
[T](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult_T_.T 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationResult<T>.T')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService'></a>

## ApplicationService Class

Basic class for application services.

```csharp
public abstract class ApplicationService : CloudyWing.FormModule.Infrastructure.InfrastructureBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; ApplicationService

Derived  
&#8627; [ApplicationService&lt;TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>')
### Constructors

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService.ApplicationService(System.IServiceProvider)'></a>

## ApplicationService(IServiceProvider) Constructor

Initializes a new instance of the [ApplicationService](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService') class.

```csharp
protected ApplicationService(System.IServiceProvider? serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService.ApplicationService(System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService.HttpContext'></a>

## ApplicationService.HttpContext Property

Gets the current HttpContext.

```csharp
protected Microsoft.AspNetCore.Http.HttpContext HttpContext { get; }
```

#### Property Value
[Microsoft.AspNetCore.Http.HttpContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.HttpContext 'Microsoft.AspNetCore.Http.HttpContext')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService.IPAddressContext'></a>

## ApplicationService.IPAddressContext Property

Gets the IPAddressContext for the current request.

```csharp
protected CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext IPAddressContext { get; }
```

#### Property Value
[IPAddressContext](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService.LinkGenerator'></a>

## ApplicationService.LinkGenerator Property

Gets the LinkGenerator service.

```csharp
protected Microsoft.AspNetCore.Routing.LinkGenerator LinkGenerator { get; }
```

#### Property Value
[Microsoft.AspNetCore.Routing.LinkGenerator](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Routing.LinkGenerator 'Microsoft.AspNetCore.Routing.LinkGenerator')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService.PagingOptions'></a>

## ApplicationService.PagingOptions Property

Gets the PagingOptions from the configuration.

```csharp
protected CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.PagingOptions PagingOptions { get; }
```

#### Property Value
[PagingOptions](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.PagingOptions 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.PagingOptions')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService.ServiceMessageProvider'></a>

## ApplicationService.ServiceMessageProvider Property

Gets the service message provider.

```csharp
protected CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider ServiceMessageProvider { get; }
```

#### Property Value
[IServiceMessageProvider](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService.User'></a>

## ApplicationService.User Property

Gets the current user context.

```csharp
protected CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext User { get; }
```

#### Property Value
[IUserContext](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_'></a>

## ApplicationService<TKey> Class

Basic class for application services with a specific key type.

```csharp
public abstract class ApplicationService<TKey> : CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService
    where TKey : struct, System.IEquatable<TKey>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_.TKey'></a>

`TKey`

The type of the key.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormModule.Infrastructure.InfrastructureBase](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.InfrastructureBase 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') &#129106; [ApplicationService](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService') &#129106; ApplicationService<TKey>

Derived  
&#8627; [FormSubmissionCompletionAppService&lt;TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService_TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionCompletionAppService<TCompletionViewModel,TDbContext,TFormPageQueryEntity,TForm,TFormPage,TKey>')  
&#8627; [FormSubmissionIndexAppService&lt;TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService_TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models.FormSubmissionIndexAppService<TIndexViewModel,TIndexSectionViewModel,TIndexQuestionViewModel,TIndexChoiceViewModel,TIndexSkipViewModel,TIndexInputModel,TIndexQuestionInputModel,TIndexChoiceInputModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TSkipFormQuestionQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TFormPage,TFormPageDetail,TKey>')  
&#8627; [FormPageDisplayAppService&lt;TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService_TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageDisplayAppService<TDisplaySettingsModel,TDisplaySectionSettingsModel,TDisplayQuestionSettingsModel,TDisplayChoiceSettingsModel,TDisplayResponseModel,TDisplayQuestionResponseModel,TDisplayChoiceResponseModel,TDbContext,TFormDetailQueryEntity,TFormPageDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TFormPage,TFormPageDetail,TKey>')  
&#8627; [FormPageIndexAppService&lt;TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService_TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models.FormPageIndexAppService<TIndexInputModel,TIndexRecordModel,TFormPageEditor,TFormPageWithDetailsEditor,TFormPageDetailEditor,TForm,TFormPage,TKey>')  
&#8627; [FormEditAppService&lt;TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService_TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditAppService<TEditInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>')  
&#8627; [FormEditDetailsAppService&lt;TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService_TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormEditDetailsAppService<TEditDetailsViewModel,TEditDetailsInputModel,TEditDetailsSectionInputModel,TEditDetailsQuestionInputModel,TEditDetailsChoiceInputModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TDbContext,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TKey>')  
&#8627; [FormIndexAppService&lt;TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService_TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models.FormIndexAppService<TIndexRecordModel,TFormEditor,TFormDetailEditor,TFormSectionEditor,TFormQuestionEditor,TQuestionChoiceEditor,TForm,TKey>')  
&#8627; [SkipFormQuestionEditAppService&lt;TEditViewModel,TEditInputModel,TSkipFormQuestionEditor,TDbContext,TSkipFormQuestionQueryEntity,TFormQuestionQueryEntity,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models.SkipFormQuestionEditAppService_TEditViewModel,TEditInputModel,TSkipFormQuestionEditor,TDbContext,TSkipFormQuestionQueryEntity,TFormQuestionQueryEntity,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models.SkipFormQuestionEditAppService<TEditViewModel,TEditInputModel,TSkipFormQuestionEditor,TDbContext,TSkipFormQuestionQueryEntity,TFormQuestionQueryEntity,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TKey>')  
&#8627; [SkipFormQuestionIndexAppService&lt;TIndexViewModel,TIndexRecordModel,TSkipFormQuestionEditor,TDbContext,TSkipFormQuestionQueryEntity,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models.SkipFormQuestionIndexAppService_TIndexViewModel,TIndexRecordModel,TSkipFormQuestionEditor,TDbContext,TSkipFormQuestionQueryEntity,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models.SkipFormQuestionIndexAppService<TIndexViewModel,TIndexRecordModel,TSkipFormQuestionEditor,TDbContext,TSkipFormQuestionQueryEntity,TFormDetailQueryEntity,TForm,TFormSection,TFormQuestion,TQuestionChoice,TSkipFormQuestion,TKey>')
### Constructors

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_.ApplicationService(System.IServiceProvider)'></a>

## ApplicationService(IServiceProvider) Constructor

Initializes a new instance of the [ApplicationService&lt;TKey&gt;](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_ 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>') class.

```csharp
protected ApplicationService(System.IServiceProvider? serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_.ApplicationService(System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_.IdConverter'></a>

## ApplicationService<TKey>.IdConverter Property

Gets the ID converter for the specified key type.

```csharp
protected CloudyWing.FormModule.Domain.IIdConverter<TKey> IdConverter { get; }
```

#### Property Value
[CloudyWing.FormModule.Domain.IIdConverter&lt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IIdConverter-1 'CloudyWing.FormModule.Domain.IIdConverter`1')[TKey](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService_TKey_.TKey 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ApplicationService<TKey>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Domain.IIdConverter-1 'CloudyWing.FormModule.Domain.IIdConverter`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext'></a>

## IPAddressContext Class

Provides information about the IP address associated with an HTTP request.

```csharp
public class IPAddressContext
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IPAddressContext
### Constructors

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext.IPAddressContext(Microsoft.AspNetCore.Http.HttpContext)'></a>

## IPAddressContext(HttpContext) Constructor

Initializes a new instance of the [IPAddressContext](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext') class.

```csharp
public IPAddressContext(Microsoft.AspNetCore.Http.HttpContext httpContext);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext.IPAddressContext(Microsoft.AspNetCore.Http.HttpContext).httpContext'></a>

`httpContext` [Microsoft.AspNetCore.Http.HttpContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.HttpContext 'Microsoft.AspNetCore.Http.HttpContext')

The current [Microsoft.AspNetCore.Http.HttpContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.HttpContext 'Microsoft.AspNetCore.Http.HttpContext').
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext.UserHostAddress'></a>

## IPAddressContext.UserHostAddress Property

Gets the IP address of the client host.

```csharp
public string? UserHostAddress { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext.UserRealAddress'></a>

## IPAddressContext.UserRealAddress Property

Gets the real IP address of the client, considering X-Forwarded-For headers.

```csharp
public string? UserRealAddress { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext.ParsePriorityUsingIPv4(string)'></a>

## IPAddressContext.ParsePriorityUsingIPv4(string) Method

Parses an IP address string using IPv4 as the priority.

```csharp
public static System.Net.IPAddress ParsePriorityUsingIPv4(string ip);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext.ParsePriorityUsingIPv4(string).ip'></a>

`ip` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The IP address string to parse.

#### Returns
[System.Net.IPAddress](https://docs.microsoft.com/en-us/dotnet/api/System.Net.IPAddress 'System.Net.IPAddress')  
The parsed [System.Net.IPAddress](https://docs.microsoft.com/en-us/dotnet/api/System.Net.IPAddress 'System.Net.IPAddress').

#### Exceptions

[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
Thrown when the IP address string has an invalid format.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext.TryParsePriorityUsingIPv4(string,System.Net.IPAddress)'></a>

## IPAddressContext.TryParsePriorityUsingIPv4(string, IPAddress) Method

Tries to parse an IP address string using IPv4 as the priority.

```csharp
public static bool TryParsePriorityUsingIPv4(string ip, out System.Net.IPAddress? ipAddress);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext.TryParsePriorityUsingIPv4(string,System.Net.IPAddress).ip'></a>

`ip` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The IP address string to parse.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IPAddressContext.TryParsePriorityUsingIPv4(string,System.Net.IPAddress).ipAddress'></a>

`ipAddress` [System.Net.IPAddress](https://docs.microsoft.com/en-us/dotnet/api/System.Net.IPAddress 'System.Net.IPAddress')

When this method returns, contains the parsed [System.Net.IPAddress](https://docs.microsoft.com/en-us/dotnet/api/System.Net.IPAddress 'System.Net.IPAddress') if the parsing succeeded, or `null` if the parsing failed.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the parsing succeeded; otherwise, `false`.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase'></a>

## PageModelBase Class

Basic class for page models.

```csharp
public class PageModelBase : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Microsoft.AspNetCore.Mvc.RazorPages.PageModel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.RazorPages.PageModel 'Microsoft.AspNetCore.Mvc.RazorPages.PageModel') &#129106; PageModelBase
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.HeadTitle'></a>

## PageModelBase.HeadTitle Property

Gets or sets the title to be displayed in the page header.

```csharp
public string? HeadTitle { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.LazyServiceProvider'></a>

## PageModelBase.LazyServiceProvider Property

Gets the lazy service provider for lazy service resolution.

```csharp
protected CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider LazyServiceProvider { get; }
```

#### Property Value
[CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider 'CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.StatusNotification'></a>

## PageModelBase.StatusNotification Property

Gets or sets the status notification.

```csharp
public CloudyWing.FormModule.UI.Areas.FormModule.Pages.Shared.Models.NotificationViewModel? StatusNotification { get; set; }
```

#### Property Value
[CloudyWing.FormModule.UI.Areas.FormModule.Pages.Shared.Models.NotificationViewModel](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.UI.Areas.FormModule.Pages.Shared.Models.NotificationViewModel 'CloudyWing.FormModule.UI.Areas.FormModule.Pages.Shared.Models.NotificationViewModel')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.UserContext'></a>

## PageModelBase.UserContext Property

Gets the user context.

```csharp
protected CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext UserContext { get; }
```

#### Property Value
[IUserContext](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.GetTemporaryData_T_(string)'></a>

## PageModelBase.GetTemporaryData<T>(string) Method

Gets the temporary data.

```csharp
protected T? GetTemporaryData<T>(string key);
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.GetTemporaryData_T_(string).T'></a>

`T`

The type of the data.
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.GetTemporaryData_T_(string).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The key.

#### Returns
[T](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.GetTemporaryData_T_(string).T 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.GetTemporaryData<T>(string).T')  
The temporary data.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.GetTemporaryData_T_(string,T)'></a>

## PageModelBase.GetTemporaryData<T>(string, T) Method

Gets the temporary data.

```csharp
protected T GetTemporaryData<T>(string key, T defaultValue);
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.GetTemporaryData_T_(string,T).T'></a>

`T`

The type of the data.
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.GetTemporaryData_T_(string,T).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The key.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.GetTemporaryData_T_(string,T).defaultValue'></a>

`defaultValue` [T](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.GetTemporaryData_T_(string,T).T 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.GetTemporaryData<T>(string, T).T')

The default value.

#### Returns
[T](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.GetTemporaryData_T_(string,T).T 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.GetTemporaryData<T>(string, T).T')  
The temporary data.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.Json(object)'></a>

## PageModelBase.Json(object) Method

Creates a JsonResult with the specified data.

```csharp
protected virtual Microsoft.AspNetCore.Mvc.JsonResult Json(object? data);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.Json(object).data'></a>

`data` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The data to be serialized.

#### Returns
[Microsoft.AspNetCore.Mvc.JsonResult](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.JsonResult 'Microsoft.AspNetCore.Mvc.JsonResult')  
A JsonResult object.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.OnPageHandlerExecuting(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext)'></a>

## PageModelBase.OnPageHandlerExecuting(PageHandlerExecutingContext) Method

Called before the page handler is executed.

```csharp
public override void OnPageHandlerExecuting(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext context);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.OnPageHandlerExecuting(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext).context'></a>

`context` [Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext 'Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext')

The page handler executing context.

Implements [OnPageHandlerExecuting(PageHandlerExecutingContext)](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.Filters.IPageFilter.OnPageHandlerExecuting#Microsoft_AspNetCore_Mvc_Filters_IPageFilter_OnPageHandlerExecuting_Microsoft_AspNetCore_Mvc_Filters_PageHandlerExecutingContext_ 'Microsoft.AspNetCore.Mvc.Filters.IPageFilter.OnPageHandlerExecuting(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext)')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.SetTemporaryData_T_(string,T)'></a>

## PageModelBase.SetTemporaryData<T>(string, T) Method

Sets the temporary data.

```csharp
protected void SetTemporaryData<T>(string key, T data);
```
#### Type parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.SetTemporaryData_T_(string,T).T'></a>

`T`

The type of the data.
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.SetTemporaryData_T_(string,T).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The key.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.SetTemporaryData_T_(string,T).data'></a>

`data` [T](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.SetTemporaryData_T_(string,T).T 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.PageModelBase.SetTemporaryData<T>(string, T).T')

The data.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider'></a>

## ServiceMessageProvider Class

Represents a service message provider.

```csharp
public class ServiceMessageProvider :
CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ServiceMessageProvider

Implements [IServiceMessageProvider](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider')
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider.CreateFailureMessageAccessor'></a>

## ServiceMessageProvider.CreateFailureMessageAccessor Property

Gets or sets the accessor for the create failure message.

```csharp
public System.Func<string> CreateFailureMessageAccessor { get; set; }
```

Implements [CreateFailureMessageAccessor](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.CreateFailureMessageAccessor 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.CreateFailureMessageAccessor')

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider.CreateSuccessMessageAccessor'></a>

## ServiceMessageProvider.CreateSuccessMessageAccessor Property

Gets or sets the accessor for the create success message.

```csharp
public System.Func<string> CreateSuccessMessageAccessor { get; set; }
```

Implements [CreateSuccessMessageAccessor](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.CreateSuccessMessageAccessor 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.CreateSuccessMessageAccessor')

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider.DataExistsMessageAccessor'></a>

## ServiceMessageProvider.DataExistsMessageAccessor Property

Gets or sets the accessor for the data exists message.

```csharp
public System.Func<string> DataExistsMessageAccessor { get; set; }
```

Implements [DataExistsMessageAccessor](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DataExistsMessageAccessor 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DataExistsMessageAccessor')

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider.DeleteFailureMessageAccessor'></a>

## ServiceMessageProvider.DeleteFailureMessageAccessor Property

Gets or sets the accessor for the delete failure message.

```csharp
public System.Func<string> DeleteFailureMessageAccessor { get; set; }
```

Implements [DeleteFailureMessageAccessor](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DeleteFailureMessageAccessor 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DeleteFailureMessageAccessor')

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider.DeleteSuccessMessageAccessor'></a>

## ServiceMessageProvider.DeleteSuccessMessageAccessor Property

Gets or sets the accessor for the delete success message.

```csharp
public System.Func<string> DeleteSuccessMessageAccessor { get; set; }
```

Implements [DeleteSuccessMessageAccessor](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DeleteSuccessMessageAccessor 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DeleteSuccessMessageAccessor')

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider.DuplicateFormCodeCreateMessageAccessor'></a>

## ServiceMessageProvider.DuplicateFormCodeCreateMessageAccessor Property

Gets or sets the accessor for the duplicate form code create message.

```csharp
public System.Func<string> DuplicateFormCodeCreateMessageAccessor { get; set; }
```

Implements [DuplicateFormCodeCreateMessageAccessor](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DuplicateFormCodeCreateMessageAccessor 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DuplicateFormCodeCreateMessageAccessor')

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider.DuplicateFormCodeUpdateMessageAccessor'></a>

## ServiceMessageProvider.DuplicateFormCodeUpdateMessageAccessor Property

Gets or sets the accessor for the duplicate form code update message.

```csharp
public System.Func<string> DuplicateFormCodeUpdateMessageAccessor { get; set; }
```

Implements [DuplicateFormCodeUpdateMessageAccessor](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DuplicateFormCodeUpdateMessageAccessor 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DuplicateFormCodeUpdateMessageAccessor')

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider.QuestionRequiredMessageAccessor'></a>

## ServiceMessageProvider.QuestionRequiredMessageAccessor Property

Gets or sets the accessor for the question required message.

```csharp
public System.Func<string> QuestionRequiredMessageAccessor { get; set; }
```

Implements [QuestionRequiredMessageAccessor](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.QuestionRequiredMessageAccessor 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.QuestionRequiredMessageAccessor')

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider.TextRequiredIfCheckedMessageAccessor'></a>

## ServiceMessageProvider.TextRequiredIfCheckedMessageAccessor Property

Gets or sets the accessor for the text required if checked message.

```csharp
public System.Func<string> TextRequiredIfCheckedMessageAccessor { get; set; }
```

Implements [TextRequiredIfCheckedMessageAccessor](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.TextRequiredIfCheckedMessageAccessor 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.TextRequiredIfCheckedMessageAccessor')

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider.UnableToDeleteDetailDataAccessor'></a>

## ServiceMessageProvider.UnableToDeleteDetailDataAccessor Property

Gets or sets the accessor for the unable to delete detail data due to existing skip logic or form submission record message.

```csharp
public System.Func<string> UnableToDeleteDetailDataAccessor { get; set; }
```

Implements [UnableToDeleteDetailDataAccessor](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.UnableToDeleteDetailDataAccessor 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.UnableToDeleteDetailDataAccessor')

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider.UnableToDeleteFormAccessor'></a>

## ServiceMessageProvider.UnableToDeleteFormAccessor Property

Gets or sets the accessor for the unable to delete data because the form has set question message.

```csharp
public System.Func<string> UnableToDeleteFormAccessor { get; set; }
```

Implements [UnableToDeleteFormAccessor](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.UnableToDeleteFormAccessor 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.UnableToDeleteFormAccessor')

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider.UpdateFailureMessageAccessor'></a>

## ServiceMessageProvider.UpdateFailureMessageAccessor Property

Gets or sets the accessor for the update failure message.

```csharp
public System.Func<string> UpdateFailureMessageAccessor { get; set; }
```

Implements [UpdateFailureMessageAccessor](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.UpdateFailureMessageAccessor 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.UpdateFailureMessageAccessor')

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider.UpdateSuccessMessageAccessor'></a>

## ServiceMessageProvider.UpdateSuccessMessageAccessor Property

Gets or sets the accessor for the update success message.

```csharp
public System.Func<string> UpdateSuccessMessageAccessor { get; set; }
```

Implements [UpdateSuccessMessageAccessor](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.UpdateSuccessMessageAccessor 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.UpdateSuccessMessageAccessor')

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.UserContext'></a>

## UserContext Class

Represents the user context in the application.

```csharp
public class UserContext :
CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UserContext

Implements [IUserContext](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext')
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.UserContext.Role'></a>

## UserContext.Role Property

Gets or sets the role of the user.

```csharp
public string? Role { get; set; }
```

Implements [Role](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext.Role 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext.Role')

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.UserContext.UserId'></a>

## UserContext.UserId Property

Gets or sets the user ID.

```csharp
public string? UserId { get; set; }
```

Implements [UserId](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext.UserId 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext.UserId')

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.UserContext.HasPermission(string)'></a>

## UserContext.HasPermission(string) Method

Checks if the user has permission for the specified path.

```csharp
public virtual bool HasPermission(string? path);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.UserContext.HasPermission(string).path'></a>

`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path to check.

Implements [HasPermission(string)](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext.HasPermission(string) 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext.HasPermission(string)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the user has permission; otherwise, `false`.
### Interfaces

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider'></a>

## IServiceMessageProvider Interface

Represents a service message provider.

```csharp
public interface IServiceMessageProvider
```

Derived  
&#8627; [ServiceMessageProvider](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.ServiceMessageProvider')
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.CreateFailureMessageAccessor'></a>

## IServiceMessageProvider.CreateFailureMessageAccessor Property

Gets the accessor for the create failure message.

```csharp
System.Func<string> CreateFailureMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.CreateSuccessMessageAccessor'></a>

## IServiceMessageProvider.CreateSuccessMessageAccessor Property

Gets the accessor for the create success message.

```csharp
System.Func<string> CreateSuccessMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DataExistsMessageAccessor'></a>

## IServiceMessageProvider.DataExistsMessageAccessor Property

Gets the accessor for the data exists message.

```csharp
System.Func<string> DataExistsMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DeleteFailureMessageAccessor'></a>

## IServiceMessageProvider.DeleteFailureMessageAccessor Property

Gets the accessor for the delete failure message.

```csharp
System.Func<string> DeleteFailureMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DeleteSuccessMessageAccessor'></a>

## IServiceMessageProvider.DeleteSuccessMessageAccessor Property

Gets the accessor for the delete success message.

```csharp
System.Func<string> DeleteSuccessMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DuplicateFormCodeCreateMessageAccessor'></a>

## IServiceMessageProvider.DuplicateFormCodeCreateMessageAccessor Property

Gets the accessor for the duplicate form code create message.

```csharp
System.Func<string> DuplicateFormCodeCreateMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.DuplicateFormCodeUpdateMessageAccessor'></a>

## IServiceMessageProvider.DuplicateFormCodeUpdateMessageAccessor Property

Gets the accessor for the duplicate form code update message.

```csharp
System.Func<string> DuplicateFormCodeUpdateMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.QuestionRequiredMessageAccessor'></a>

## IServiceMessageProvider.QuestionRequiredMessageAccessor Property

Gets the accessor for the question required message.

```csharp
System.Func<string> QuestionRequiredMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.TextRequiredIfCheckedMessageAccessor'></a>

## IServiceMessageProvider.TextRequiredIfCheckedMessageAccessor Property

Gets the accessor for the text required if checked message.

```csharp
System.Func<string> TextRequiredIfCheckedMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.UnableToDeleteDetailDataAccessor'></a>

## IServiceMessageProvider.UnableToDeleteDetailDataAccessor Property

Gets the accessor for the unable to delete detail data due to existing skip logic or form submission record message.

```csharp
System.Func<string> UnableToDeleteDetailDataAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.UnableToDeleteFormAccessor'></a>

## IServiceMessageProvider.UnableToDeleteFormAccessor Property

Gets the accessor for the unable to delete data because the form has set question types message.

```csharp
System.Func<string> UnableToDeleteFormAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.UpdateFailureMessageAccessor'></a>

## IServiceMessageProvider.UpdateFailureMessageAccessor Property

Gets the accessor for the update failure message.

```csharp
System.Func<string> UpdateFailureMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider.UpdateSuccessMessageAccessor'></a>

## IServiceMessageProvider.UpdateSuccessMessageAccessor Property

Gets the accessor for the update success message.

```csharp
System.Func<string> UpdateSuccessMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext'></a>

## IUserContext Interface

Represents the user context in the application.

```csharp
public interface IUserContext
```

Derived  
&#8627; [UserContext](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.UserContext 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.UserContext')
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext.Role'></a>

## IUserContext.Role Property

Gets or sets the role of the user.

```csharp
string? Role { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext.UserId'></a>

## IUserContext.UserId Property

Gets or sets the user ID.

```csharp
string? UserId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext.HasPermission(string)'></a>

## IUserContext.HasPermission(string) Method

Checks if the user has permission for the specified path.

```csharp
bool HasPermission(string? path);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext.HasPermission(string).path'></a>

`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path to check.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the user has permission; otherwise, `false`.