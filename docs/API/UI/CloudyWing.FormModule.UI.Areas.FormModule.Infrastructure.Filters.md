#### [CloudyWing.FormModule](index.md 'index')

## CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters Namespace
### Classes

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.StopAutoValidationAttribute'></a>

## StopAutoValidationAttribute Class

Specifies that automatic validation should be stopped for a method.

```csharp
public class StopAutoValidationAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; StopAutoValidationAttribute

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationExecutionAttribute'></a>

## ValidationExecutionAttribute Class

Attribute used to define actions to execute before and after model validation in a page handler method.

```csharp
public class ValidationExecutionAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; ValidationExecutionAttribute
### Constructors

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationExecutionAttribute.ValidationExecutionAttribute()'></a>

## ValidationExecutionAttribute() Constructor

Initializes a new instance of the [ValidationExecutionAttribute](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationExecutionAttribute 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationExecutionAttribute') class.

```csharp
public ValidationExecutionAttribute();
```

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationExecutionAttribute.ValidationExecutionAttribute(string)'></a>

## ValidationExecutionAttribute(string) Constructor

Initializes a new instance of the [ValidationExecutionAttribute](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationExecutionAttribute 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationExecutionAttribute') class.

```csharp
public ValidationExecutionAttribute(string? onExecutedAction);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationExecutionAttribute.ValidationExecutionAttribute(string).onExecutedAction'></a>

`onExecutedAction` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The on executed action.
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationExecutionAttribute.OnExecutingAction'></a>

## ValidationExecutionAttribute.OnExecutingAction Property

The action to execute before model validation.

```csharp
public string? OnExecutingAction { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationExecutionAttribute.OnFailExecutedAction'></a>

## ValidationExecutionAttribute.OnFailExecutedAction Property

The action to execute after model validation, if validation fails.

```csharp
public string? OnFailExecutedAction { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationExecutionAttribute.OnFailResultAction'></a>

## ValidationExecutionAttribute.OnFailResultAction Property

The method name to execute when validation fails and returns a PageResult.

```csharp
public string? OnFailResultAction { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationExecutionAttribute.OnSuccessExecutedAction'></a>

## ValidationExecutionAttribute.OnSuccessExecutedAction Property

The action to execute after model validation, if validation succeeds.

```csharp
public string? OnSuccessExecutedAction { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationPropertyAttribute'></a>

## ValidationPropertyAttribute Class

Specifies the property to be validated for a method.

```csharp
public class ValidationPropertyAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; ValidationPropertyAttribute
### Constructors

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationPropertyAttribute.ValidationPropertyAttribute(string)'></a>

## ValidationPropertyAttribute(string) Constructor

Initializes a new instance of the [ValidationPropertyAttribute](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationPropertyAttribute 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationPropertyAttribute') class with the specified property name.

```csharp
public ValidationPropertyAttribute(string propertyName);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationPropertyAttribute.ValidationPropertyAttribute(string).propertyName'></a>

`propertyName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the property to be validated.
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters.ValidationPropertyAttribute.PropertyName'></a>

## ValidationPropertyAttribute.PropertyName Property

Gets or sets the name of the property to be validated.

```csharp
public string PropertyName { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')