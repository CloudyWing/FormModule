#### [CloudyWing.FormModule](index.md 'index')

## CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding Namespace
### Classes

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding.EmptyStringModelBinder'></a>

## EmptyStringModelBinder Class

Provides a model binder that binds empty strings to [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty').

```csharp
public class EmptyStringModelBinder :
Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EmptyStringModelBinder

Implements [Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder 'Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding.EmptyStringModelBinderProvider'></a>

## EmptyStringModelBinderProvider Class

Provides a model binder provider that determines whether to use the [EmptyStringModelBinder](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding.EmptyStringModelBinder 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding.EmptyStringModelBinder') for binding string models.

```csharp
public class EmptyStringModelBinderProvider :
Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EmptyStringModelBinderProvider

Implements [Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider 'Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding.EnumerationModelBinder'></a>

## EnumerationModelBinder Class

Model binder for enumerations with a specified underlying value type.

```csharp
public class EnumerationModelBinder :
Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EnumerationModelBinder

Implements [Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder 'Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding.EnumerationModelBinderProvider'></a>

## EnumerationModelBinderProvider Class

Provides a model binder for enumeration models.

```csharp
public class EnumerationModelBinderProvider :
Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EnumerationModelBinderProvider

Implements [Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider 'Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding.TaipeiDateTimeOffsetModelBinder'></a>

## TaipeiDateTimeOffsetModelBinder Class

Provides a model binder that binds a string representation of a date and time to a [System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset') object using the Taipei time zone.

```csharp
public class TaipeiDateTimeOffsetModelBinder :
Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TaipeiDateTimeOffsetModelBinder

Implements [Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder 'Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding.TaipeiDateTimeOffsetModelBinderProvider'></a>

## TaipeiDateTimeOffsetModelBinderProvider Class

Provides a model binder provider that determines whether to use the [TaipeiDateTimeOffsetModelBinder](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding.TaipeiDateTimeOffsetModelBinder 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding.TaipeiDateTimeOffsetModelBinder') for binding [System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset') models.

```csharp
public class TaipeiDateTimeOffsetModelBinderProvider :
Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TaipeiDateTimeOffsetModelBinderProvider

Implements [Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider 'Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider')