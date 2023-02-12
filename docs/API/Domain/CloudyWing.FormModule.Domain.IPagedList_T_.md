#### [CloudyWing.FormModule.Domain](index.md 'index')
### [CloudyWing.FormModule.Domain](CloudyWing.FormModule.Domain.md 'CloudyWing.FormModule.Domain')

## IPagedList<T> Interface

Represents a paged list of items, providing access to the page metadata and the ability to iterate over the items.

```csharp
public interface IPagedList<out T> :
CloudyWing.FormModule.Domain.IPagingMetadata,
System.Collections.Generic.IEnumerable<T>,
System.Collections.IEnumerable
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.IPagedList_T_.T'></a>

`T`

The type of items in the paged list.

Derived  
&#8627; [PagedList&lt;T&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.PagedList_T_ 'CloudyWing.FormModule.Domain.PagedList<T>')

Implements [IPagingMetadata](CloudyWing.FormModule.Domain.IPagingMetadata.md 'CloudyWing.FormModule.Domain.IPagingMetadata'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](CloudyWing.FormModule.Domain.IPagedList_T_.md#CloudyWing.FormModule.Domain.IPagedList_T_.T 'CloudyWing.FormModule.Domain.IPagedList<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')
### Properties

<a name='CloudyWing.FormModule.Domain.IPagedList_T_.Count'></a>

## IPagedList<T>.Count Property

Gets the total number of items in the paged list.

```csharp
int Count { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='CloudyWing.FormModule.Domain.IPagedList_T_.this[int]'></a>

## IPagedList<T>.this[int] Property

Gets the item at the specified index in the paged list.

```csharp
T this[int index] { get; }
```
#### Parameters

<a name='CloudyWing.FormModule.Domain.IPagedList_T_.this[int].index'></a>

`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The zero-based index of the item to retrieve.

#### Property Value
[T](CloudyWing.FormModule.Domain.IPagedList_T_.md#CloudyWing.FormModule.Domain.IPagedList_T_.T 'CloudyWing.FormModule.Domain.IPagedList<T>.T')