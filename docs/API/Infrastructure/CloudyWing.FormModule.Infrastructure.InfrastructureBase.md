#### [CloudyWing.FormModule.Infrastructure](index.md 'index')
### [CloudyWing.FormModule.Infrastructure](CloudyWing.FormModule.Infrastructure.md 'CloudyWing.FormModule.Infrastructure')

## InfrastructureBase Class

Provides a basic class for infrastructure components.

```csharp
public class InfrastructureBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; InfrastructureBase
### Constructors

<a name='CloudyWing.FormModule.Infrastructure.InfrastructureBase.InfrastructureBase(System.IServiceProvider)'></a>

## InfrastructureBase(IServiceProvider) Constructor

Initializes a new instance of the [InfrastructureBase](CloudyWing.FormModule.Infrastructure.InfrastructureBase.md 'CloudyWing.FormModule.Infrastructure.InfrastructureBase') class.

```csharp
public InfrastructureBase(System.IServiceProvider? serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.InfrastructureBase.InfrastructureBase(System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The optional service provider used for dependency resolution.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Thrown when [serviceProvider](CloudyWing.FormModule.Infrastructure.InfrastructureBase.md#CloudyWing.FormModule.Infrastructure.InfrastructureBase.InfrastructureBase(System.IServiceProvider).serviceProvider 'CloudyWing.FormModule.Infrastructure.InfrastructureBase.InfrastructureBase(System.IServiceProvider).serviceProvider') is `null`.
### Properties

<a name='CloudyWing.FormModule.Infrastructure.InfrastructureBase.LazyServiceProvider'></a>

## InfrastructureBase.LazyServiceProvider Property

Gets the lazy service provider used for resolving services.

```csharp
protected CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider LazyServiceProvider { get; }
```

#### Property Value
[LazyServiceProvider](CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.md 'CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider')

<a name='CloudyWing.FormModule.Infrastructure.InfrastructureBase.Logger'></a>

## InfrastructureBase.Logger Property

Gets the logger obtained from the service provider.

```csharp
public Microsoft.Extensions.Logging.ILogger Logger { get; }
```

#### Property Value
[Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')

<a name='CloudyWing.FormModule.Infrastructure.InfrastructureBase.LoggerFactory'></a>

## InfrastructureBase.LoggerFactory Property

Gets the logger factory obtained from the service provider.

```csharp
protected Microsoft.Extensions.Logging.ILoggerFactory LoggerFactory { get; }
```

#### Property Value
[Microsoft.Extensions.Logging.ILoggerFactory](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILoggerFactory 'Microsoft.Extensions.Logging.ILoggerFactory')