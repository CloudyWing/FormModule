#### [CloudyWing.FormModule.Domain](index.md 'index')
### [CloudyWing.FormModule.Domain](CloudyWing.FormModule.Domain.md 'CloudyWing.FormModule.Domain')

## IFormModuleMapper Interface

Provides mapping functionality between editor and entity objects.

```csharp
public interface IFormModuleMapper
```

Derived  
&#8627; [FormModuleMapper&lt;TKey,TUserKey&gt;](CloudyWing.FormModule.Domain.md#CloudyWing.FormModule.Domain.FormModuleMapper_TKey,TUserKey_ 'CloudyWing.FormModule.Domain.FormModuleMapper<TKey,TUserKey>')
### Methods

<a name='CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor)'></a>

## IFormModuleMapper.Map<TEditor,TEntity>(TEditor) Method

Maps properties from an editor object to a new instance of an entity object.

```csharp
TEntity Map<TEditor,TEntity>(TEditor source)
    where TEntity : new();
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor).TEditor'></a>

`TEditor`

The type of the editor object.

<a name='CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor).TEntity'></a>

`TEntity`

The type of the entity object.
#### Parameters

<a name='CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor).source'></a>

`source` [TEditor](CloudyWing.FormModule.Domain.IFormModuleMapper.md#CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor).TEditor 'CloudyWing.FormModule.Domain.IFormModuleMapper.Map<TEditor,TEntity>(TEditor).TEditor')

The source editor object.

#### Returns
[TEntity](CloudyWing.FormModule.Domain.IFormModuleMapper.md#CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor).TEntity 'CloudyWing.FormModule.Domain.IFormModuleMapper.Map<TEditor,TEntity>(TEditor).TEntity')  
A new instance of the mapped entity object.

<a name='CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor,TEntity)'></a>

## IFormModuleMapper.Map<TEditor,TEntity>(TEditor, TEntity) Method

Maps properties from an editor object to an existing instance of an entity object.

```csharp
void Map<TEditor,TEntity>(TEditor source, TEntity dest)
    where TEntity : new();
```
#### Type parameters

<a name='CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor,TEntity).TEditor'></a>

`TEditor`

The type of the editor object.

<a name='CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor,TEntity).TEntity'></a>

`TEntity`

The type of the entity object.
#### Parameters

<a name='CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor,TEntity).source'></a>

`source` [TEditor](CloudyWing.FormModule.Domain.IFormModuleMapper.md#CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor,TEntity).TEditor 'CloudyWing.FormModule.Domain.IFormModuleMapper.Map<TEditor,TEntity>(TEditor, TEntity).TEditor')

The source editor object.

<a name='CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor,TEntity).dest'></a>

`dest` [TEntity](CloudyWing.FormModule.Domain.IFormModuleMapper.md#CloudyWing.FormModule.Domain.IFormModuleMapper.Map_TEditor,TEntity_(TEditor,TEntity).TEntity 'CloudyWing.FormModule.Domain.IFormModuleMapper.Map<TEditor,TEntity>(TEditor, TEntity).TEntity')

The destination entity object.