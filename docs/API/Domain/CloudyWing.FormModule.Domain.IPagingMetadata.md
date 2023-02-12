#### [CloudyWing.FormModule.Domain](index.md 'index')
### [CloudyWing.FormModule.Domain](CloudyWing.FormModule.Domain.md 'CloudyWing.FormModule.Domain')

## IPagingMetadata Interface

Represents metadata for paging.

```csharp
public interface IPagingMetadata
```

Derived  
&#8627; [IPagedList&lt;T&gt;](CloudyWing.FormModule.Domain.IPagedList_T_.md 'CloudyWing.FormModule.Domain.IPagedList<T>')  
&#8627; [PagedList&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagedList_T_ 'CloudyWing.FormModule.Domain.PagedList<T>')  
&#8627; [PagingMetadata](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagingMetadata 'CloudyWing.FormModule.Domain.PagingMetadata')
### Properties

<a name='CloudyWing.FormModule.Domain.IPagingMetadata.FirstItemOnPage'></a>

## IPagingMetadata.FirstItemOnPage Property

Gets the index of the first item on the current page.

```csharp
int FirstItemOnPage { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.Domain.IPagingMetadata.HasNextPage'></a>

## IPagingMetadata.HasNextPage Property

Gets a value indicating whether there is a next page.

```csharp
bool HasNextPage { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.Domain.IPagingMetadata.HasPreviousPage'></a>

## IPagingMetadata.HasPreviousPage Property

Gets a value indicating whether there is a previous page.

```csharp
bool HasPreviousPage { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.Domain.IPagingMetadata.IsFirstPage'></a>

## IPagingMetadata.IsFirstPage Property

Gets a value indicating whether the current page is the first page.

```csharp
bool IsFirstPage { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.Domain.IPagingMetadata.IsLastPage'></a>

## IPagingMetadata.IsLastPage Property

Gets a value indicating whether the current page is the last page.

```csharp
bool IsLastPage { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormModule.Domain.IPagingMetadata.LastItemOnPage'></a>

## IPagingMetadata.LastItemOnPage Property

Gets the index of the last item on the current page.

```csharp
int LastItemOnPage { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.Domain.IPagingMetadata.PageCount'></a>

## IPagingMetadata.PageCount Property

Gets the total number of pages.

```csharp
int PageCount { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.Domain.IPagingMetadata.PageNumber'></a>

## IPagingMetadata.PageNumber Property

Gets the current page number.

```csharp
int PageNumber { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.Domain.IPagingMetadata.PageSize'></a>

## IPagingMetadata.PageSize Property

Gets the number of items per page.

```csharp
int PageSize { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.Domain.IPagingMetadata.TotalItemCount'></a>

## IPagingMetadata.TotalItemCount Property

Gets the total number of items.

```csharp
int TotalItemCount { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')