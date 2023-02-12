# FormModule
FormModule 是一個以研究為目的的專案，旨在探討如何以 Razor Class Library 封裝模組功能，並實現高度擴充性的設計，以表單模組為例。

## Projects
 * [FormModule.UI](./src/FormModule.UI/)：  
 使用 Razor Class Library 架構開發，負責模組的用戶介面，包括表單的建立、填寫等功能，並且包含應用層的實作，[API 文件](./docs/API/UI/index.md)。

 * [FormModule.Infrastructure](./src/FormModule.Infrastructure/)：  
 包含了一些基礎設施的實作，例如靜態工具、通用擴充方法等等，[API 文件](./docs/API/Infrastructure/index.md)。
 * [FormModule.Domain](./src/FormModule.Domain/)： 包含了業務邏輯的領域層實作，[API 文件](./docs/API/Domain/index.md)。
 * [FormModule.EntityFrameworkCore](./src/FormModule.EntityFrameworkCore/)：  
 使用 Entity Framework 6.0.0 實作資料存取層的功能，包含 Entity Framework 的 DbContext、Entity 等實作，[API 文件](./docs/API/EntityFrameworkCore/CloudyWing.FormModule.EntityFrameworkCore.md)。

 ## Guide Document
* [Configuration](./docs/Guide/Configuration.md)
* [UI Features](./docs/Guide/UI_Features.md)
* [Domain API](./docs/Guide/Domain_API.md)
* [Application API](./docs/Guide/Application_API.md)
* [Extensibility](./docs/Guide/Extensibility.md)
* [Data Validation](./docs/Guide/Data_Validation.md)

## License
This project is MIT [licensed](./LICENSE.md).