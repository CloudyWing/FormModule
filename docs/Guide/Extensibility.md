# Extensibility

## 擴充資料表欄位
有關於如何在 `DbContext` 中新增欄位的說明，請參閱 [Configuration](./Configuration.md)，這裡不再重複說明。

以資料表 Forms 為例，展示如何擴充該資料表的欄位，其中`TKey` 為 `long`。

首先，新增一個名為 `ApplicationForm` 的類別，繼承自 `Form<long>`，並加入一個測試用的屬性 `DemoColumn`。
```csharp
public class ApplicationForm : Form<long> {
    public string? DemoColumn { get; set; }
}
```

接著，新增一個名為 `ApplicationFormEditor` 類別，繼承自 `FormEditor`，同樣地加入 `DemoColumn` 的屬性。
```csharp
public class ApplicationFormEditor : FormEditor {
    public ValueWatcher<string?> DemoColumn { get; set; }
}
```

然後，新增一個名為 `EditInputModel` 的類別，繼承自 RCL 的 `Manages.Forms.Models.EditInputModel`，並增加`DemoColumn` 的屬性和資料驗證註解。

```csharp
public class EditInputModel : UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel {
    [Required]
    [Display(Name = "Demo欄位")]
    public string? DemoColumn { get; set; }
}
```

接下來，新增一個名為 `FormEditAppService` 的類別，繼承自 RCL 的 `FormEditAppService`，並指定以下泛型參數型別：
* TEditInputModel：EditInputModel。
* TFormEditorel：ApplicationFormEditorel。
* TForm：ApplicationForm。
* TKey：long。

在該類別中覆寫需要異動的方法。
```csharp
public class FormEditAppService<TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>
    : FormEditAppService<EditInputModel, ApplicationFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, ApplicationForm, long>
    where TFormDetailEditor : FormDetailEditor<TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>, new()
    where TFormSectionEditor : FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor>, new()
    where TFormQuestionEditor : FormQuestionEditor<TQuestionChoiceEditor>, new()
    where TQuestionChoiceEditor : QuestionChoiceEditor, new() {
    public FormEditAppService(
        IServiceProvider? serviceProvider,
        IFormService<ApplicationFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, ApplicationForm, long> formService
    ) : base(serviceProvider, formService) { }

    public override async Task<EditInputModel> GetInputAsync(string id) {
        if (string.IsNullOrWhiteSpace(id)) {
            throw new ArgumentNullException(nameof(id));
        }

        long? convertedId = IdConverter.ConvertIdFromString(id)!;

        return await FormService.GetSingleAsync(
            x => new EditInputModel {
                Id = x.Id.ToString(),
                Name = x.Name,
                Code = x.Code,
                StartTime = x.StartTime,
                EndTime = x.EndTime,
                IsInternal = x.IsInternal,
                Role = x.Role,
                Header = x.Header,
                Footer = x.Footer,
                CanUpdate = x.CanUpdate,
                CompletionMessage = x.CompletionMessage,
                DemoColumn = x.DemoColumn // 新增欄位
            }, y => y.Id.Equals(convertedId)
        );
    }

    public override async Task<ApplicationResult> UpsertAsync(EditInputModel? input) {
        if (input is null) {
            throw new ArgumentNullException(nameof(input));
        }

        bool isExisting = await FormService.VerifyCodeNotExistsAsync(new VerifyCodeExistsInput {
            Id = input.Id,
            Code = input.Code!,
            StartTime = input.StartTime,
            EndTime = input.EndTime
        });

        if (isExisting) {
            return new ApplicationResult {
                IsOk = false,
                Message = ServiceMessageProvider.DuplicateFormCodeUpdateMessageAccessor()
            };
        }

        ApplicationFormEditor editor = new() {
            Code = input.Code,
            Name = input.Name,
            StartTime = input.StartTime,
            EndTime = input.EndTime,
            IsInternal = input.IsInternal,
            Role = input.Role,
            Header = input.Header,
            Footer = input.Footer,
            CanUpdate = input.CanUpdate,
            CompletionMessage = input.CompletionMessage,
            DemoColumn = input.DemoColumn, // 新增欄位
            ExecutedBy = User.UserId!
        };

        return string.IsNullOrWhiteSpace(input.Id)
            ? await CreateAsync(editor)
            : await UpdateAsync(input.Id, editor);
    }

    private async Task<ApplicationResult> CreateAsync(ApplicationFormEditor editor) {
        bool isOk = await FormService.CreateAsync(editor);

        return new ApplicationResult() {
            IsOk = isOk,
            Message = isOk
                ? ServiceMessageProvider.CreateSuccessMessageAccessor()
                : ServiceMessageProvider.CreateFailureMessageAccessor()
        };
    }

    private async Task<ApplicationResult> UpdateAsync(string id, ApplicationFormEditor editor) {
        editor.SetId(id);

        bool isOk = await FormService.UpdateAsync(editor);

        return new ApplicationResult {
            IsOk = isOk,
            Message = isOk
                ? ServiceMessageProvider.UpdateSuccessMessageAccessor()
                : ServiceMessageProvider.UpdateFailureMessageAccessor()
        };
    }
}
```
從「https://github.com/CloudyWing/FormModule/tree/main/src/FormModule.UI/Areas/FormModule/Pages/Manages/Forms」下載「Edit.cshtml」和「Edit.cshtml.cs」檔案，修改命名空間並新增欄位，然後將它們放置在「/Areas/FormModule/Pages/Manages/Forms」底下。

```html
@page
@model {YourProjectName}.Areas.FormModule.Pages.Manages.Forms.EditModel
@{
    Layout = "_FormLayout";
    Model.HeadTitle = "表單設定";
}

<form id="form" asp-action="Edit">
    <!--略過-->

    <!--新增以下內容-->
    <div class="row mb-3">
        <label asp-for="Input.DemoColumn" class="col-3 col-md-2 col-form-label required"></label>
        <div class="col-9 col-md-10">
            <textarea asp-for="Input.DemoColumn" class="form-control"></textarea>
            <span asp-validation-for="Input.DemoColumn" class="text-danger"></span>
        </div>
    </div>
</form>
```

若無特別處理頁面 Model，可以簡化程式碼簡化如下所示。在這個範例中 `EditInputModel` 是新建立的 `EditInputModel`，而不是原本的。
```csharp
namespace {YourProjectName}.Areas.FormModule.Pages.Manages.Forms {
    public class EditModel : UI.Areas.FormModule.Pages.Manages.Forms.EditModel<EditInputModel> {
        public EditModel(IFormEditAppService<EditInputModel> appService) 
            : base(appService) { }
    }
}
```

在「/Areas/FormModule/Pages/」底下新增「_ViewImports.cshtml」檔案，以便 Razor 頁面可以正確引用TagHelper。
```
@using {YourProjectName}.Areas.FormModule.Pages
@namespace {YourProjectName}.Areas.FormModule.Pages

@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
@addTagHelper *, CloudyWing.FormModule
```

在「Program.cs」中設定新的相依性注入設定。
```csharp
builder.Services.AddFormModule()
    .AddDomain<ApplicationDbContext>(opt => {
        opt.FormEditorType = typeof(ApplicationFormEditor);
        opt.FormPageServiceType = typeof(FormPageService);
    })
    .AddApplication(opt => {
        opt.UserFactory = provider => {
        opt.RegisterServiceType(typeof(IFormEditAppService<EditInputModel>), typeof(FormEditAppService<,,,>));
    })
    .AddDefaultUI();
```
## 客製化 Queryable Service
如果要在現有的 Queryable Service 增加 JOIN 的資料表，可參考以下方式：

新增 `FormPageQueryEntity` 的類別，繼承自原本的 `FormPageQueryEntity`，假設已有一個「Users」的資料表。
```csharp
public class FormPageQueryEntity : FormPageQueryEntity<ApplicationFormPage, ApplicationForm, long> {
    public Users User { get; set; }
}
```

接著，新增一個名為 `FormPageQueryService` 的類別。
```csharp
public class FormPageQueryService
    : FormPageQueryService<ApplicationDbContext, FormPageQueryEntity, ApplicationFormPage, ApplicationForm, long> {
    public FormPageQueryService(ApplicationDbContext? dbContext, IServiceProvider? serviceProvider)
        : base(dbContext, serviceProvider) { }

    public override IQueryable<FormPageQueryEntity> DataSource
        => (from fp in DbContext.Set<ApplicationFormPage>()
            join f in DbContext.Set<ApplicationForm>() on fp.FormId equals f.Id
            join u in DbContext.Set<User>() on fp.CreatedBy equals u.Id
            where fp.IsDeleted == false
            select new FormPageQueryEntity {
                Page = fp,
                Form = f,
                User = u
            }).AsNoTracking();
}
```

在「Program.cs」中，設定新的相依性注入設定。
```csharp
formModuleBuilder.AddDomain<ApplicationDbContext>(opt => {
    opt.FormPageQueryServiceType = typeof(FormPageQueryService);
});
```

## 權限控管
目前預設只有具有 `Role` 為 `Administrator` 的使用者才能操作表單設定相關功能，可以自訂`UserContext` 來調整權限。

建立一個名為 `ApplicationUserContext` 的類別，將 `Role` 改為 `Manage` 才能操作表單設定相關功能。
```csharp
public class ApplicationUserContext : UserContext {
    public override bool HasPermission(string? path) {
        return path?.Contains("/Manages/") != true || Role == "Manage";
    }
}
```

調整 `IUserContext` 的相依性設定。
```csharp
formModuleBuilder.AddApplication(opt => {
    opt.UserFactory = provider => {
        IHttpContextAccessor httpContextAccessor = provider.GetService<IHttpContextAccessor>();
        ISession session = httpContextAccessor.HttpContext.Session;

        return new ApplicationUserContext {
            UserId = session.GetString("UserId"),
            Role = session.GetString("Role")
        };
    };
});
```

## Features
* [Configuration](./Configuration.md)
* [UI Features](./UI_Features.md)
* [Domain API](./Domain_API.md)
* [Application API](./Application_API.md)
* [Data Validation](./Data_Validation.md)
