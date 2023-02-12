#### [CloudyWing.FormModule.Infrastructure](index.md 'index')
### [CloudyWing.FormModule.Infrastructure.DependencyInjection](CloudyWing.FormModule.Infrastructure.DependencyInjection.md 'CloudyWing.FormModule.Infrastructure.DependencyInjection')

## LazyServiceProvider Class

Provides a lazy service provider.

```csharp
public class LazyServiceProvider
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; LazyServiceProvider
### Constructors

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.LazyServiceProvider(System.IServiceProvider)'></a>

## LazyServiceProvider(IServiceProvider) Constructor

Initializes a new instance of the [LazyServiceProvider](CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.md 'CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider') class with the specified service provider.

```csharp
public LazyServiceProvider(System.IServiceProvider serviceProvider);
```
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.LazyServiceProvider(System.IServiceProvider).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The underlying service provider.
### Methods

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.GetService(System.Type)'></a>

## LazyServiceProvider.GetService(Type) Method

Gets the service of the specified type.

```csharp
public object GetService(System.Type serviceType);
```
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.GetService(System.Type).serviceType'></a>

`serviceType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type of the service.

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The service of the specified type.

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.GetService(System.Type,System.Func_System.IServiceProvider,object_)'></a>

## LazyServiceProvider.GetService(Type, Func<IServiceProvider,object>) Method

Gets the service of the specified type using the provided factory method.

```csharp
public object GetService(System.Type serviceType, System.Func<System.IServiceProvider,object> factory);
```
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.GetService(System.Type,System.Func_System.IServiceProvider,object_).serviceType'></a>

`serviceType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type of the service.

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.GetService(System.Type,System.Func_System.IServiceProvider,object_).factory'></a>

`factory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The factory method to create the service.

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The service of the specified type.

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.GetService_T_()'></a>

## LazyServiceProvider.GetService<T>() Method

Gets the service of the specified type.

```csharp
public T GetService<T>()
    where T : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.GetService_T_().T'></a>

`T`

The type of the service.

#### Returns
[T](CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.md#CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.GetService_T_().T 'CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.GetService<T>().T')  
The service of the specified type.

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.GetService_T_(System.Func_System.IServiceProvider,object_)'></a>

## LazyServiceProvider.GetService<T>(Func<IServiceProvider,object>) Method

Gets the service of the specified type using the provided factory method.

```csharp
public T GetService<T>(System.Func<System.IServiceProvider,object> factory)
    where T : class;
```
#### Type parameters

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.GetService_T_(System.Func_System.IServiceProvider,object_).T'></a>

`T`

The type of the service.
#### Parameters

<a name='CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.GetService_T_(System.Func_System.IServiceProvider,object_).factory'></a>

`factory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The factory method to create the service.

#### Returns
[T](CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.md#CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.GetService_T_(System.Func_System.IServiceProvider,object_).T 'CloudyWing.FormModule.Infrastructure.DependencyInjection.LazyServiceProvider.GetService<T>(System.Func<System.IServiceProvider,object>).T')  
The service of the specified type.