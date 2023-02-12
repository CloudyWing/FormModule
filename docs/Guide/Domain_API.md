# Domain API

## Services
相關功能以「{資料表名稱(單數形式)}Model」的命名空間進行組織，如果是主從資料表，則統一放在主資料表的命名空間下。新增或修改資料的 DTO 命名統一使用「Editor」結尾，其他 DTO 使用「Input」結尾。

目前的 Service 分為兩類：Domain Service 和 Queryable Service。Domain Service 的命名方式是以「{資料表名稱(單數形式)}Service」，主要負責處理新增、修改 和刪除的操作，同時也是該資料表的 Queryable Service。主從資料表的操作會統一在主資料表的 Service 中處理。多資料表查詢的 Queryable Service 的命名方式是以「{主資料表名稱(單數形式)}QueryService」，搭配的 Entity 命名為「{主資料表名稱(單數形式)}QueryEntity」，以將需要 JOIN 的資料表都設定為該實體的屬性。Entity、Editor 和 QueryEntity 都使用泛型定義，因此可以根據需要進行擴充。

目前已經有的 Service 如下：

### FormModel
主要負責處理「Forms」、「FormSections」為、「FormQuestions」和「QuestionChoices」的資料邏輯。
* IFormService：定義有關「新增」、「修改」、「刪除」和「檢核」的 API。
* FormService：實作 `IFormService` 和 `IQueryableService<TForm>`。
* FormQuestionQueryService：以「FormQuestions」為為主表 JOIN「FormSections」和「FForms」。
* FormDetailQueryService：以「Forms」為主表，並 JOIN「FormSections」、「FormQuestions」、「QuestionChoices」。

### FormPageModel
主要負責處理「FormPages」、「FormPageDetails」的資料邏輯。
IFormPageService：定義有關「新增」、「修改」、「刪除」和「檢核」的 API。
FormPageService：實作 `IFormPageService` 和 `IQueryableService<TFormPage>`。
FormPageQueryService：以「FormPages」為主表 JOIN「FForms」。
FormPageDetailQueryService：以「FormPageDetails」為主表，JOIN「FormPages」和「Forms」。

### SkipFormQuestionModel
主要負責「SkipFormQuestions」的資料邏輯。
ISkipFormQuestionService：定義有關「新增」、「修改」、「刪除」和「檢核」的 API。
SkipFormQuestionService：實作ISkipFormQuestionService 和 `IQueryableService<TSkipFormQuestion>`。
SkipFormQuestionQueryService：以「SkipFormQuestion」為主表，並 JOIN「Forms」、「FormSections」、「FormQuestions」、「QuestionChoices」。

## Editors
如果需包含 `Id` 屬性，則繼承 `EditorBase`，其中`Id` 只提供 Get，要設值使用包含 `Id` 的建構函式或是使用 `SetId()` 設值。新增資料時，由 Domain Service 新增完資料後設定 `Id`，修改資料則由 Application Service 設值。如果資料表有 `CreatedBy` 或 `UpdatedBy`，則由 Editor 的 `ExecutedBy` 屬性設值。  
新增時必填，但修改可不填的屬性使用型別 `ValueWatcher<T>`，在映射時，如果這屬性沒有設過值，會忽略，避免將 Entity 屬性設為空值。

## IdConverter
* IIdConverter：定義`ConvertIdFromString()`，將 `Id` 從`string`型別轉為`TKey`型別，定義`ConvertIdToString()`，將 `Id` 從`TKey`轉為`string`型別。
* IUserIdConverter：定義`ConvertUserIdFromString()`，將 `Id` 從`string`型別轉為`TUserKey`型別，定義`ConvertUserIdToString()`，將 `Id` 從`TUserKey`轉為`string`型別。
* IdConverter：預設實作`IIdConverter`和`IUserIdConverter`。

## FormModuleMapper
用來處理 Editor 轉換 成Entity 邏輯
* IFormModuleMapper：定義 `Map` 方法。
* FormModuleMapper：實作`IFormModuleMapper`，目前預設轉換規則如下：
  1. 屬性映射僅針對具有以下條件的屬性：公開的、非靜態的。對於DTO屬性，必須允許讀取(Get)；對於Entity屬性，必須允許讀取(Get)和寫入(Set)。大部分的映射是基於屬性名稱的匹配(不區分大小寫)。
  2. 基本型別映射：如果DTO的屬性型別是一般的基本型別，則直接將該屬性值映射到 Entity 的相應屬性。
  3. 「ValueWatcher<>」型別處理：如果DTO的屬性型別是 「ValueWatcher<>」，則只有當該屬性的「HasValue」為「true」時，才會將該屬性的「Value」 映射到 Entity 的相應屬性。
  4. 特殊映射處理：如果DTO屬性名稱以「Id」結尾且型別為「string」，而 Entity 屬性為「TKey」，則使用「IdConverter.ConvertIdFromString()」進行轉換。
  5. 資料異動者與時間處理：如果DTO屬性名稱為「ExecutedBy」，則會檢查 Entity 是否具有「CreatedBy」、「CreatedAt」、「UpdatedBy」和 「UpdatedAt」屬性，並依以下規則處理：
   * 如果Entity的「CreatedAt」為default值，代表是新增資料，則「CreatedAt」寫入目前時間，「CreatedBy」寫入「ExecutedBy」的值。
   * 「UpdatedAt」寫入目前時間，「UpdatedBy」寫入「ExecutedBy」的值。

## Features
* [Configuration](./Configuration.md)
* [UI Features](./UI_Features.md)
* [Application API](./Application_API.md)
* [Extensibility](./Extensibility.md)
* [Data Validation](./Data_Validation.md)
