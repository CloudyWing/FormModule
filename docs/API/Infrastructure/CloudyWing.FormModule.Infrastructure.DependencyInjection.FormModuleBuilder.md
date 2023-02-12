#### [CloudyWing.FormModule.Infrastructure](index.md 'index')
### [CloudyWing.FormModule.Infrastructure.DependencyInjection](CloudyWing.FormModule.Infrastructure.DependencyInjection.md 'CloudyWing.FormModule.Infrastructure.DependencyInjection')

## FormModuleBuilder Class

Builder class for constructing a FormModule.

```csharp
public class FormModuleBuilder
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormModuleBuilder
### Constructors

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder.FormModuleBuilder(Microsoft.Extensions.DependencyInjection.IServiceCollection,CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper)'></a>

## FormModuleBuilder(IServiceCollection, GenericTypeMapper) Constructor

Initializes a new instance of the [FormModuleBuilder](CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder.md 'CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder') class.

```csharp
public FormModuleBuilder(Microsoft.Extensions.DependencyInjection.IServiceCollection services, CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper genericTypeMapper);
```
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder.FormModuleBuilder(Microsoft.Extensions.DependencyInjection.IServiceCollection,CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The IServiceCollection to add services to.

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder.FormModuleBuilder(Microsoft.Extensions.DependencyInjection.IServiceCollection,CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper).genericTypeMapper'></a>

`genericTypeMapper` [GenericTypeMapper](CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.md 'CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper')

The GenericTypeMapper instance.
### Properties

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder.GenericTypeMapper'></a>

## FormModuleBuilder.GenericTypeMapper Property

Gets the GenericTypeMapper instance.

```csharp
public CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper GenericTypeMapper { get; }
```

#### Property Value
[GenericTypeMapper](CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper.md 'CloudyWing.FormModule.Infrastructure.Util.GenericTypeMapper')

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder.Services'></a>

## FormModuleBuilder.Services Property

Gets the IServiceCollection instance.

```csharp
public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
```

#### Property Value
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')