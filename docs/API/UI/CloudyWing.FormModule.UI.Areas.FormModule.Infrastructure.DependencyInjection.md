#### [CloudyWing.FormModule](index.md 'index')

## CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection Namespace
### Classes

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.ApplicationOptions'></a>

## ApplicationOptions Class

Represents the application options.

```csharp
public class ApplicationOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ApplicationOptions
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.ApplicationOptions.ApplicationName'></a>

## ApplicationOptions.ApplicationName Property

Gets or sets the name of the application.

```csharp
public virtual string? ApplicationName { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder'></a>

## FormModuleApplicationOptionsBuilder Class

Builds application options for the form module.

```csharp
public class FormModuleApplicationOptionsBuilder
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormModuleApplicationOptionsBuilder
### Constructors

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder.FormModuleApplicationOptionsBuilder()'></a>

## FormModuleApplicationOptionsBuilder() Constructor

Initializes a new instance of the [FormModuleApplicationOptionsBuilder](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder') class.

```csharp
public FormModuleApplicationOptionsBuilder();
```
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder.ApplicationOptionsAction'></a>

## FormModuleApplicationOptionsBuilder.ApplicationOptionsAction Property

Gets or sets the action for configuring application options.

```csharp
public System.Action<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.ApplicationOptions>? ApplicationOptionsAction { get; set; }
```

#### Property Value
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[ApplicationOptions](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.ApplicationOptions 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.ApplicationOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder.PagingOptionsAction'></a>

## FormModuleApplicationOptionsBuilder.PagingOptionsAction Property

Gets or sets the action for configuring paging options.

```csharp
public System.Action<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.PagingOptions>? PagingOptionsAction { get; set; }
```

#### Property Value
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[PagingOptions](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.PagingOptions 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.PagingOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder.ServiceMessageProvider'></a>

## FormModuleApplicationOptionsBuilder.ServiceMessageProvider Property

Gets or sets the service message provider.

```csharp
public CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider ServiceMessageProvider { get; set; }
```

#### Property Value
[IServiceMessageProvider](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IServiceMessageProvider')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder.ServiceTypeMaps'></a>

## FormModuleApplicationOptionsBuilder.ServiceTypeMaps Property

Gets the service type maps.

```csharp
internal System.Collections.Generic.IDictionary<System.Type,System.Type> ServiceTypeMaps { get; }
```

#### Property Value
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder.UserFactory'></a>

## FormModuleApplicationOptionsBuilder.UserFactory Property

Gets or sets the factory function for creating the user context.

```csharp
public System.Func<System.IServiceProvider,CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext>? UserFactory { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[IUserContext](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models.IUserContext')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder.RegisterServiceType(System.Type,System.Type)'></a>

## FormModuleApplicationOptionsBuilder.RegisterServiceType(Type, Type) Method

Registers a service type and its implementation type.

```csharp
public void RegisterServiceType(System.Type serviceType, System.Type implementationType);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder.RegisterServiceType(System.Type,System.Type).serviceType'></a>

`serviceType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The service type.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder.RegisterServiceType(System.Type,System.Type).implementationType'></a>

`implementationType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The implementation type.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleBuilderApplicationExtensions'></a>

## FormModuleBuilderApplicationExtensions Class

Extension methods for FormModuleBuilder to add application-related functionality.

```csharp
public static class FormModuleBuilderApplicationExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormModuleBuilderApplicationExtensions
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleBuilderApplicationExtensions.AddApplication(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder)'></a>

## FormModuleBuilderApplicationExtensions.AddApplication(this FormModuleBuilder) Method

Adds application-related services to the FormModuleBuilder.

```csharp
public static CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder AddApplication(this CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder builder);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleBuilderApplicationExtensions.AddApplication(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder).builder'></a>

`builder` [CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder 'CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder')

The FormModuleBuilder instance.

#### Returns
[CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder 'CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder')  
A FormModuleBuilder instance.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleBuilderApplicationExtensions.AddApplication(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder,System.Action_CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder_)'></a>

## FormModuleBuilderApplicationExtensions.AddApplication(this FormModuleBuilder, Action<FormModuleApplicationOptionsBuilder>) Method

Adds application-related services to the FormModuleBuilder.

```csharp
public static CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder AddApplication(this CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder builder, System.Action<CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder> appOptionsAction);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleBuilderApplicationExtensions.AddApplication(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder,System.Action_CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder_).builder'></a>

`builder` [CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder 'CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder')

The FormModuleBuilder instance.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleBuilderApplicationExtensions.AddApplication(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder,System.Action_CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder_).appOptionsAction'></a>

`appOptionsAction` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[FormModuleApplicationOptionsBuilder](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleApplicationOptionsBuilder')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

An action to configure the application options.

#### Returns
[CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder 'CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder')  
A FormModuleBuilder instance.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleBuilderApplicationExtensions.AddDefaultUI(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder)'></a>

## FormModuleBuilderApplicationExtensions.AddDefaultUI(this FormModuleBuilder) Method

Adds default UI services to the FormModuleBuilder.

```csharp
public static CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder AddDefaultUI(this CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder builder);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleBuilderApplicationExtensions.AddDefaultUI(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder).builder'></a>

`builder` [CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder 'CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder')

The FormModuleBuilder instance.

#### Returns
[CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder 'CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder')  
A FormModuleBuilder instance.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleDefaultUIMvcConfigureOptions'></a>

## FormModuleDefaultUIMvcConfigureOptions Class

Configuration options for the default UI of the FormModule in MVC.

```csharp
public class FormModuleDefaultUIMvcConfigureOptions :
Microsoft.Extensions.Options.IPostConfigureOptions<Microsoft.AspNetCore.Mvc.MvcOptions>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormModuleDefaultUIMvcConfigureOptions

Implements [Microsoft.Extensions.Options.IPostConfigureOptions&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Options.IPostConfigureOptions-1 'Microsoft.Extensions.Options.IPostConfigureOptions`1')[Microsoft.AspNetCore.Mvc.MvcOptions](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.MvcOptions 'Microsoft.AspNetCore.Mvc.MvcOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Options.IPostConfigureOptions-1 'Microsoft.Extensions.Options.IPostConfigureOptions`1')
### Methods

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleDefaultUIMvcConfigureOptions.PostConfigure(string,Microsoft.AspNetCore.Mvc.MvcOptions)'></a>

## FormModuleDefaultUIMvcConfigureOptions.PostConfigure(string, MvcOptions) Method

Configures the MvcOptions for the default UI in MVC.

```csharp
public void PostConfigure(string name, Microsoft.AspNetCore.Mvc.MvcOptions options);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleDefaultUIMvcConfigureOptions.PostConfigure(string,Microsoft.AspNetCore.Mvc.MvcOptions).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the options.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.FormModuleDefaultUIMvcConfigureOptions.PostConfigure(string,Microsoft.AspNetCore.Mvc.MvcOptions).options'></a>

`options` [Microsoft.AspNetCore.Mvc.MvcOptions](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.MvcOptions 'Microsoft.AspNetCore.Mvc.MvcOptions')

The MvcOptions instance.

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.PagingOptions'></a>

## PagingOptions Class

Represents the paging options.

```csharp
public class PagingOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PagingOptions
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection.PagingOptions.PageSize'></a>

## PagingOptions.PageSize Property

Gets the number of items per page.

```csharp
public virtual int PageSize { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')