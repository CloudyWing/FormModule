#### [CloudyWing.FormModule.Domain](index.md 'index')

## CloudyWing.FormModule.Domain.DependencyInjection Namespace
### Classes

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleBuilderDomainExtensions'></a>

## FormModuleBuilderDomainExtensions Class

Extension methods for FormModuleBuilder to add domain-related functionality.

```csharp
public static class FormModuleBuilderDomainExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormModuleBuilderDomainExtensions
### Methods

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleBuilderDomainExtensions.AddDomain_TDbContext_(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder)'></a>

## FormModuleBuilderDomainExtensions.AddDomain<TDbContext>(this FormModuleBuilder) Method

Adds domain-related services to the FormModuleBuilder.

```csharp
public static CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder AddDomain<TDbContext>(this CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder builder)
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleBuilderDomainExtensions.AddDomain_TDbContext_(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder).TDbContext'></a>

`TDbContext`

The type of the DbContext.
#### Parameters

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleBuilderDomainExtensions.AddDomain_TDbContext_(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder).builder'></a>

`builder` [CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder 'CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder')

The FormModuleBuilder instance.

#### Returns
[CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder 'CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder')  
A FormModuleBuilder instance.

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleBuilderDomainExtensions.AddDomain_TDbContext_(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder,System.Action_CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder_,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime)'></a>

## FormModuleBuilderDomainExtensions.AddDomain<TDbContext>(this FormModuleBuilder, Action<FormModuleDomainOptionsBuilder>, ServiceLifetime, ServiceLifetime) Method

Adds domain-related services to the FormModuleBuilder.

```csharp
public static CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder AddDomain<TDbContext>(this CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder builder, System.Action<CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder> domainOptionsAction, Microsoft.Extensions.DependencyInjection.ServiceLifetime contextLifetime=Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped, Microsoft.Extensions.DependencyInjection.ServiceLifetime optionsLifetime=Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped)
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext;
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleBuilderDomainExtensions.AddDomain_TDbContext_(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder,System.Action_CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder_,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TDbContext'></a>

`TDbContext`

The type of the DbContext.
#### Parameters

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleBuilderDomainExtensions.AddDomain_TDbContext_(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder,System.Action_CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder_,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime).builder'></a>

`builder` [CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder 'CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder')

The FormModuleBuilder instance.

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleBuilderDomainExtensions.AddDomain_TDbContext_(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder,System.Action_CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder_,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime).domainOptionsAction'></a>

`domainOptionsAction` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[FormModuleDomainOptionsBuilder](CloudyWing.FormModule.Domain.DependencyInjection.md#CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder 'CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

An action to configure the domain options.

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleBuilderDomainExtensions.AddDomain_TDbContext_(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder,System.Action_CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder_,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime).contextLifetime'></a>

`contextLifetime` [Microsoft.Extensions.DependencyInjection.ServiceLifetime](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.ServiceLifetime 'Microsoft.Extensions.DependencyInjection.ServiceLifetime')

The lifetime of the DbContext service.

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleBuilderDomainExtensions.AddDomain_TDbContext_(thisCloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder,System.Action_CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder_,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime).optionsLifetime'></a>

`optionsLifetime` [Microsoft.Extensions.DependencyInjection.ServiceLifetime](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.ServiceLifetime 'Microsoft.Extensions.DependencyInjection.ServiceLifetime')

The lifetime of the options services.

#### Returns
[CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder](https://docs.microsoft.com/en-us/dotnet/api/CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder 'CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder')  
A FormModuleBuilder instance.

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder'></a>

## FormModuleDomainOptionsBuilder Class

Builder class for constructing FormModule domain options.

```csharp
public class FormModuleDomainOptionsBuilder
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormModuleDomainOptionsBuilder
### Constructors

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.FormModuleDomainOptionsBuilder()'></a>

## FormModuleDomainOptionsBuilder() Constructor

Initializes a new instance of the [FormModuleDomainOptionsBuilder](CloudyWing.FormModule.Domain.DependencyInjection.md#CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder 'CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder') class.

```csharp
public FormModuleDomainOptionsBuilder();
```
### Properties

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.EditorTypeMaps'></a>

## FormModuleDomainOptionsBuilder.EditorTypeMaps Property

Gets the editor type maps.

```csharp
internal System.Collections.Generic.IDictionary<string,System.Type> EditorTypeMaps { get; }
```

#### Property Value
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.FormDetailEditorType'></a>

## FormModuleDomainOptionsBuilder.FormDetailEditorType Property

Gets or sets the form detail editor type.

```csharp
public System.Type FormDetailEditorType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.FormDetailQueryServiceType'></a>

## FormModuleDomainOptionsBuilder.FormDetailQueryServiceType Property

Gets or sets the form detail query service type.

```csharp
public System.Type? FormDetailQueryServiceType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.FormEditorType'></a>

## FormModuleDomainOptionsBuilder.FormEditorType Property

Gets or sets the form editor type.

```csharp
public System.Type FormEditorType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.FormPageDetailEditorType'></a>

## FormModuleDomainOptionsBuilder.FormPageDetailEditorType Property

Gets or sets the form page details editor type.

```csharp
public System.Type FormPageDetailEditorType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.FormPageDetailQueryServiceType'></a>

## FormModuleDomainOptionsBuilder.FormPageDetailQueryServiceType Property

Gets or sets the form page detail query service type.

```csharp
public System.Type? FormPageDetailQueryServiceType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.FormPageEditorType'></a>

## FormModuleDomainOptionsBuilder.FormPageEditorType Property

Gets or sets the form page editor type.

```csharp
public System.Type FormPageEditorType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.FormPageQueryServiceType'></a>

## FormModuleDomainOptionsBuilder.FormPageQueryServiceType Property

Gets or sets the form page query service type.

```csharp
public System.Type? FormPageQueryServiceType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.FormPageServiceType'></a>

## FormModuleDomainOptionsBuilder.FormPageServiceType Property

Gets or sets the form page service type.

```csharp
public System.Type? FormPageServiceType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.FormPageWithDetailsEditorType'></a>

## FormModuleDomainOptionsBuilder.FormPageWithDetailsEditorType Property

Gets or sets the form page with details editor type.

```csharp
public System.Type FormPageWithDetailsEditorType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.FormQuestionEditorType'></a>

## FormModuleDomainOptionsBuilder.FormQuestionEditorType Property

Gets or sets the form question editor type.

```csharp
public System.Type FormQuestionEditorType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.FormQuestionQueryServiceType'></a>

## FormModuleDomainOptionsBuilder.FormQuestionQueryServiceType Property

Gets or sets the form question query service type.

```csharp
public System.Type? FormQuestionQueryServiceType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.FormSectionEditorType'></a>

## FormModuleDomainOptionsBuilder.FormSectionEditorType Property

Gets or sets the form section editor type.

```csharp
public System.Type FormSectionEditorType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.FormServiceType'></a>

## FormModuleDomainOptionsBuilder.FormServiceType Property

Gets or sets the form service type.

```csharp
public System.Type? FormServiceType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.IdConverterType'></a>

## FormModuleDomainOptionsBuilder.IdConverterType Property

Gets or sets the ID converter type.

```csharp
public System.Type? IdConverterType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.MapperType'></a>

## FormModuleDomainOptionsBuilder.MapperType Property

Gets or sets the mapper type.

```csharp
public System.Type? MapperType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.QuestionChoiceEditorType'></a>

## FormModuleDomainOptionsBuilder.QuestionChoiceEditorType Property

Gets or sets the question choice editor type.

```csharp
public System.Type QuestionChoiceEditorType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.SkipFormQuestionEditorType'></a>

## FormModuleDomainOptionsBuilder.SkipFormQuestionEditorType Property

Gets or sets the skip form question editor type.

```csharp
public System.Type SkipFormQuestionEditorType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.SkipFormQuestionQueryServiceType'></a>

## FormModuleDomainOptionsBuilder.SkipFormQuestionQueryServiceType Property

Gets or sets the skip form question query service type.

```csharp
public System.Type? SkipFormQuestionQueryServiceType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.SkipFormQuestionServiceType'></a>

## FormModuleDomainOptionsBuilder.SkipFormQuestionServiceType Property

Gets or sets the skip form question service type.

```csharp
public System.Type? SkipFormQuestionServiceType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='CloudyWing.FormModule.Domain.DependencyInjection.FormModuleDomainOptionsBuilder.UserIdConverterType'></a>

## FormModuleDomainOptionsBuilder.UserIdConverterType Property

Gets or sets the user ID converter type.

```csharp
public System.Type? UserIdConverterType { get; set; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')