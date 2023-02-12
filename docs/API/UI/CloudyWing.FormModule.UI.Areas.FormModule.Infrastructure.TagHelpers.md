#### [CloudyWing.FormModule](index.md 'index')

## CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.TagHelpers Namespace
### Classes

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.TagHelpers.DropDownListTagHelper'></a>

## DropDownListTagHelper Class

Custom tag helper for creating dropdown lists with AJAX support.

```csharp
public class DropDownListTagHelper : Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Microsoft.AspNetCore.Razor.TagHelpers.TagHelper](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Razor.TagHelpers.TagHelper 'Microsoft.AspNetCore.Razor.TagHelpers.TagHelper') &#129106; [Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper 'Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper') &#129106; DropDownListTagHelper
### Constructors

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.TagHelpers.DropDownListTagHelper.DropDownListTagHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator)'></a>

## DropDownListTagHelper(IHtmlGenerator) Constructor

Creates a new [DropDownListTagHelper](CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.TagHelpers.md#CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.TagHelpers.DropDownListTagHelper 'CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.TagHelpers.DropDownListTagHelper').

```csharp
public DropDownListTagHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator generator);
```
#### Parameters

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.TagHelpers.DropDownListTagHelper.DropDownListTagHelper(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator).generator'></a>

`generator` [Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator 'Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator')

The [Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator 'Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator').
### Properties

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.TagHelpers.DropDownListTagHelper.AjaxUrl'></a>

## DropDownListTagHelper.AjaxUrl Property

Gets or sets the URL for AJAX requests.

```csharp
public string AjaxUrl { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.TagHelpers.DropDownListTagHelper.ChangeCallback'></a>

## DropDownListTagHelper.ChangeCallback Property

Gets or sets the change callback.

```csharp
public string? ChangeCallback { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.TagHelpers.DropDownListTagHelper.ExtraParams'></a>

## DropDownListTagHelper.ExtraParams Property

Gets or sets the extra parameters dictionary.

```csharp
public System.Collections.Generic.IDictionary<string,string> ExtraParams { get; set; }
```

#### Property Value
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.TagHelpers.DropDownListTagHelper.NonUsedLabel'></a>

## DropDownListTagHelper.NonUsedLabel Property

Gets or sets the non-used label.

```csharp
public string? NonUsedLabel { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.TagHelpers.DropDownListTagHelper.OptionLabel'></a>

## DropDownListTagHelper.OptionLabel Property

Gets or sets the option label.

```csharp
public string? OptionLabel { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.TagHelpers.DropDownListTagHelper.SelectGroup'></a>

## DropDownListTagHelper.SelectGroup Property

Gets or sets the select group.

```csharp
public string SelectGroup { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')