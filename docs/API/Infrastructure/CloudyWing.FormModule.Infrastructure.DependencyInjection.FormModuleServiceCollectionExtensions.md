#### [CloudyWing.FormModule.Infrastructure](index.md 'index')
### [CloudyWing.FormModule.Infrastructure.DependencyInjection](CloudyWing.FormModule.Infrastructure.DependencyInjection.md 'CloudyWing.FormModule.Infrastructure.DependencyInjection')

## FormModuleServiceCollectionExtensions Class

Extension methods for IServiceCollection to add a FormModule.

```csharp
public static class FormModuleServiceCollectionExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormModuleServiceCollectionExtensions
### Methods

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleServiceCollectionExtensions.AddFormModule(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection)'></a>

## FormModuleServiceCollectionExtensions.AddFormModule(this IServiceCollection) Method

Adds a FormModule to the IServiceCollection.

```csharp
public static CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder AddFormModule(this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
```
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleServiceCollectionExtensions.AddFormModule(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The IServiceCollection to add services to.

#### Returns
[FormModuleBuilder](CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder.md 'CloudyWing.FormModule.Infrastructure.DependencyInjection.FormModuleBuilder')  
A FormModuleBuilder instance.