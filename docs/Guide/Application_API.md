# Application API

Application Service 的命名方式為「{資料夾（單數形式）}{Razor 頁面名稱}AppService」。每個 Razor 頁面對應一個 Application Service 介面，並提供預設的實作類別，使用泛型 ViewModel 定義。

Application Service 的責任是將 Razor 頁面傳入的參數或 ViewModel 轉換後，調用 Domain Service 和 Queryable Service 來處理資料，然後將結果轉換為 Razor 頁面所需的資料或 ViewModel 進行回傳。

如果 Application Service 負責查詢資料，則直接回傳查詢結果。如果是執行行為（例如新增、刪除資料），則回傳 `ApplicationResult`。`ApplicationResult` 的程式碼如下：

```csharp
public class ApplicationResult {
    public bool IsOk { get; set; }

    public string? Message { get; set; }
}

public class ApplicationResult<T> : ApplicationResult {
    public T? Data { get; set; }
}
```

## ViewModels
ViewModel 的命名方式為「{Razor 頁面名稱}{類型}Model」。大部分情況下，如果是輸入資料，類型為「Input」，(例如：`IndexInputModel`)；如果是顯示資料，類型為「View」，(例如：`IndexViewModel`)；如果是表格資料，類型為「Record」，(例如：`IndexRecordModel`)。在其他情況下，可以根據需要自行定義類型。

## Features
* [Configuration](./Configuration.md)
* [UI Features](./UI_Features.md)
* [Domain API](./Domain_API.md)
* [Extensibility](./Extensibility.md)
* [Data Validation](./Data_Validation.md)
