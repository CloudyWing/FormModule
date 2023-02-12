### [CloudyWing.FormModule.EntityFrameworkCore](CloudyWing.FormModule.EntityFrameworkCore.md 'CloudyWing.FormModule.EntityFrameworkCore')

## Form<TKey> Class

The form in form module.

```csharp
public class Form<TKey>
    where TKey : struct, System.IEquatable<TKey>, System.ValueType?, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.TKey'></a>

`TKey`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Form<TKey>
### Properties

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.CanUpdate'></a>

## Form<TKey>.CanUpdate Property

Gets or sets whether this form can be updated after submission.

```csharp
public bool CanUpdate { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.Code'></a>

## Form<TKey>.Code Property

Gets or sets the code for the form.

```csharp
public string? Code { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.CompletionMessage'></a>

## Form<TKey>.CompletionMessage Property

Gets or sets the message to be displayed upon completion of the form.

```csharp
public string? CompletionMessage { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.CreatedAt'></a>

## Form<TKey>.CreatedAt Property

Gets or sets the creation time for the form.

```csharp
public System.DateTimeOffset CreatedAt { get; set; }
```

#### Property Value
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.CreatedBy'></a>

## Form<TKey>.CreatedBy Property

Gets or sets the primary key of the user who created the form.

```csharp
public string CreatedBy { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.DetailCreatedAt'></a>

## Form<TKey>.DetailCreatedAt Property

Gets or sets the creation time for the form detail.

```csharp
public System.Nullable<System.DateTimeOffset> DetailCreatedAt { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.DetailCreatedBy'></a>

## Form<TKey>.DetailCreatedBy Property

Gets or sets the primary key of the user who created the form detail.

```csharp
public string? DetailCreatedBy { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.DetailUpdatedAt'></a>

## Form<TKey>.DetailUpdatedAt Property

Gets or sets the time of the last update for the form detail.

```csharp
public System.Nullable<System.DateTimeOffset> DetailUpdatedAt { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.DetailUpdatedBy'></a>

## Form<TKey>.DetailUpdatedBy Property

Gets or sets the primary key of the user who updated the form detail.

```csharp
public string? DetailUpdatedBy { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.EndTime'></a>

## Form<TKey>.EndTime Property

Gets or sets the end time for the form.

```csharp
public System.DateTimeOffset EndTime { get; set; }
```

#### Property Value
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.Footer'></a>

## Form<TKey>.Footer Property

Gets or sets the footer for the form.

```csharp
public string? Footer { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.Header'></a>

## Form<TKey>.Header Property

Gets or sets the header for the form.

```csharp
public string? Header { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.Id'></a>

## Form<TKey>.Id Property

Gets or sets the primary key for this form.

```csharp
public TKey Id { get; set; }
```

#### Property Value
[TKey](CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.md#CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.TKey 'CloudyWing.FormModule.EntityFrameworkCore.Form<TKey>.TKey')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.IsInternal'></a>

## Form<TKey>.IsInternal Property

Gets or sets whether this is an internal form.

```csharp
public bool IsInternal { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.Name'></a>

## Form<TKey>.Name Property

Gets or sets the name for the form.

```csharp
public string? Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.Role'></a>

## Form<TKey>.Role Property

Gets or sets the role for the form.

```csharp
public string? Role { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.StartTime'></a>

## Form<TKey>.StartTime Property

Gets or sets the start time for the form.

```csharp
public System.DateTimeOffset StartTime { get; set; }
```

#### Property Value
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.UpdatedAt'></a>

## Form<TKey>.UpdatedAt Property

Gets or sets the time of the last update for the form.

```csharp
public System.DateTimeOffset UpdatedAt { get; set; }
```

#### Property Value
[System.DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/System.DateTimeOffset 'System.DateTimeOffset')

<a name='CloudyWing.FormModule.EntityFrameworkCore.Form_TKey_.UpdatedBy'></a>

## Form<TKey>.UpdatedBy Property

Gets or sets the primary key of the user who updated the form.

```csharp
public string UpdatedBy { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')