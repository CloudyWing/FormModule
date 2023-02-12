# Data Validation

## 前端驗證
如果有需要使用 ASP.NET Core 內建的前端驗證，請確保已經引用了以下 JavaScript 檔案，並在「_Layout.cshtml」 中進行引用。預設情況下並未引用「jQuery」，因此無法提供前端驗證功能。
1. jquery.min.js
2. jquery.validate.min.js
3. jquery.validate.unobtrusive.min.js

## 後端驗證
如果頁面 Model 繼承自 `PageModelBase`，則自動會執行後端驗證，不需要自己在 `if (ModelState.IsValid)` 中進行判斷。後端驗證的預設規則如下：
1.	在 Handler 簡單型別參數上設定 DataAnnotation 進行檢核，無需將 DataAnnotation 綁定在 ViewModel 的屬性上。
2.	如果 Handler 未設定 `IgnoreAutoValidationAttribute`，則自動進行檢核。
3.	檢核失敗時，根據不同的來源方式進行回應：
  * 如果 `HttpMethod` 為 `Get`，則回傳 `NotFoundResult`(404)。
* 如果是 AJAX，則使用 JSON 格式回傳 `ApplicationResult`，其中屬性 `IsOk` 為 `false`，`Message` 為第一個檢核錯誤訊息。
* 其他狀況直接回傳 `PageResult`。

如果 Handler 只需要驗證特定的屬性，可以使用 `ValidationPropertyAttribute`，如下 `OnPostAsync()` 只會檢核 `Input1`，`OnPostGetQuestionsAsync()`，只會檢核 `command`。
```csharp
[BindProperty]
public EditInputModel Input1 { get; set; } = default!;

[BindProperty]
public EditInputModel Input2 { get; set; } = default!;

[ValidationProperty(nameof(Input1))]
public async Task<IActionResult> OnPostAsync() {
    // 略過
}

[ValidationProperty("")]
public async Task<IActionResult> OnPostGetQuestionsAsync([FromBody] SelectCommand command) {
    // 略過
}
```

如果希望檢核前後自動執行其他行為，可使用`ValidationExecutionAttribute`，目前提供以下屬性：
* OnExecutingAction：檢核前執行。
* OnFailExecutedAction：檢核失敗執行。
* OnSuccessExecutedAction：檢核成功執行。
* OnFailResultAction：驗證失敗時直接設定回應結果，而不執行後續動作（前面提到的 Result 設定）。
建構函式的 `onExecutedAction` 參數會同時設定 `OnFailExecutedAction` 和 `OnSuccessExecutedAction`。

如果參數是簡單變數，可直接增加 Data Annotation 來驗證資料，而不需要封裝成 ViewModel。

以下是一個範例，當驗證失敗時返回 `NotFound()` 而不是執行 `Page()`；當驗證成功時 `InitializeAsync()` 方法來初始化資料。
```csharp
[ValidationExecution(OnFailResultAction = nameof(NotFound), OnSuccessExecutedAction = nameof(InitializeAsync))]
public async Task OnPostDeleteAsync([Required] string id) {
    ApplicationResult<IPagedList<IndexRecordModel>> result = await appService.DeleteAsync(id, Input);

    StatusNotification = new NotificationViewModel(result);
    Records = result.Data!;
}

private async Task InitializeAsync() {
    Forms = await appService.GetFormsAsync();
}
```

## Features
* [Configuration](./Configuration.md)
* [UI Features](./UI_Features.md)
* [Domain API](./Domain_API.md)
* [Application API](./Application_API.md)
* [Extensibility](./Extensibility.md)
