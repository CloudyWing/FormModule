# Configuration

## Database Configuration
建立一個繼承自 `FormModuleDbContext<TKey, TUserKey>` 的新 `DbContext`。`TKey` 代表 FormModule 的主鍵類型，而 `TUserKey` 代表寫入資料庫時使用的使用者 ID 類型。
```csharp
public class ApplicationDbContext : FormModuleDbContext<long, string> {
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
}
```

如果需要自訂實體類型，請參考以下範例：
```csharp
public class ApplicationDbContext
    : FormModuleDbContext<ApplicationForm, FormSection<long>, FormQuestion<long>, QuestionChoice<long>, PassFormQuestion<long>, ApplicationFormPage, FormPageDetail<long>, long, string> {
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ApplicationForm>(b => {
            b.Property(u => u.DemoColumn)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode()
                .IsFixedLength(false);
        });

        modelBuilder.Entity<ApplicationFormPage>(b => {
            b.Property(u => u.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);
        });
    }
}
```

## 相依性設定
有關 FormModule 的相依性設定，需先呼叫  `AddFormModule()` 建立 `FormModuleBuilder` 實例。
```csharp
FormModuleBuilder formModuleBuilder = builder.Services.AddFormModule()
```

### 設定 FormModule Domain
使用 `AddDomain()` 方法註冊與領域相關的相依性類型。
```csharp
formModuleBuilder.AddDomain<ApplicationDbContext>();
```

使用不帶任何參數的 `AddDomain()`，將套用預設配置，如果要自訂與領域相關的相依性，可以提供參數以指定不同的類型：
```csharp
formModuleBuilder.AddDomain<ApplicationDbContext>(opt => {
    // MapperType
    opt.MapperType = typeof(FormModuleMapper<short, string>);
    // IdConverterType
    opt.IdConverterType = typeof(IdConverter<short, string>);
    // UserIdConverterType
    opt.UserIdConverterType = typeof(IdConverter<short, string>);
    // EditorType
    opt.FormEditorType = typeof(ApplicationFormEditor);
    // QueryableServiceType
    opt.FormPageQueryServiceType = typeof(FormPageQueryService);
    // DomainServiceType
    opt.FormPageServiceType = typeof(FormPageService);
});
```

### 設定 FormModule Application
使用 `AddApplication()` 方法註冊與使用者介面相關的相依性類型。
```csharp
formModuleBuilder.AddApplication();
```

使用不帶任何參數的 `AddApplication()` 將套用預設配置，如果要自訂與使用者介面相關的相依性，可以提供參數以指定不同的行為：
```csharp
formModuleBuilder.AddApplication(opt => {
     // 從 Session 取得 UserContext 資訊。需要進一步設定才能從 Session 擷取資料：Services.AddSession() 和 app.UseSession()
    opt.UserFactory = provider => {
        IHttpContextAccessor httpContextAccessor = provider.GetService<IHttpContextAccessor>();
        ISession session = httpContextAccessor.HttpContext.Session;

        return new UserContext {
            UserId = session.GetString("UserId"),
            Role = session.GetString("Role")
        };
    };
    // 設定分頁的頁面大小。預設為 10 頁
    opt.PagingOptionsAction = pagingOptions => {
        pagingOptions.PageSize = 20;
    };
    // 設定應用程式模組名稱。預設為「表單模組」
    opt.ApplicationOptionsAction = applicationOptions => {
    opt.ApplicationOptionsAction = applicationOptions => {
        applicationOptions.ApplicationName = "表單模組Test";
    };
    // 註冊 Application Service 實作
    opt.RegisterServiceType(typeof(IFormIndexAppService<IndexRecordModel>), typeof(FormIndexAppService));
    opt.RegisterServiceType(typeof(IFormEditAppService<EditInputModel>), typeof(FormEditAppService<,,,>));

    // 設定 Service 訊息
     ServiceMessageProvider provider = new() {
        CreateSuccessMessageAccessor = () => "新增成功。",
        CreateFailureMessageAccessor = () => "新增失敗。",
        UpdateSuccessMessageAccessor = () => "更新成功。",
        UpdateFailureMessageAccessor = () => "更新失敗。",
        DeleteSuccessMessageAccessor = () => "刪除成功。",
        DeleteFailureMessageAccessor = () => "刪除失敗。",
        DuplicateFormCodeCreateMessageAccessor = () => "無法新增資料，已存在相同代碼的問卷且開放時間有重疊。",
        DuplicateFormCodeUpdateMessageAccessor = () => "無法更新資料，已存在相同代碼的問卷且開放時間有重疊。",
        UnableToDeleteDetailDataAccessor = () => "無法刪除明細資料，因為已存在跳題設定或表單填寫紀錄。",
        UnableToDeleteFormAccessor = () => "無法刪除表單設定資料，此表單已有設定題型。",
        DataExistsMessageAccessor = () => "資料已存在。",
        QuestionRequiredMessageAccessor = () => "請填寫此問題。",
        TextRequiredIfCheckedMessageAccessor = () => "如果勾選項目，請填寫文字。"
    };
    opt.ServiceMessageProvider = provider;
});
```

透過這些自訂的參數，可以根據需要設定使用者介面相關的相依性行為，並自訂 `UserFactory`、分頁選項、應用程式選項、註冊 Application Service 實作和設定 Service 訊息。

### 設定 RazorPagesOptions 和 MvcOptions 
使用 `AddDefaultUI()` 方法設定 RazorPagesOptions 和 MvcOptions，該設定目前包括以下內容：
* ModelBinderProviders: 設定 `ModelBinderProviders`，以滿足 FormModule 的需求。其中包含以下設定：
    1. EnumerationModelBinderProvider: 支援 `EnumerationBase` 的衍生類型。
    2. EmptyStringModelBinderProvider: 將為 null 或空白的 `string` 值轉換為空字串。
    3. TaipeiDateTimeOffsetModelBinderProvider: 處理台北時區中的 `DateTimeOffset` 值。

以下為程式碼範例：
```csharp
formModuleBuilder.AddDefaultUI();
```

## Features
* [UI Features](./UI_Features.md)
* [Domain API](./Domain_API.md)
* [Application API](./Application_API.md)
* [Extensibility](./Extensibility.md)
* [Data Validation](./Data_Validation.md)
