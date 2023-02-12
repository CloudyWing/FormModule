using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Shared.Models {
    public class NotificationViewModel {
        public NotificationViewModel() : this("", NotificationLevel.None) { }

        public NotificationViewModel(ApplicationResult result)
            : this(result?.Message ?? "", result?.IsOk ?? true) { }

        public NotificationViewModel(string message, bool isOk)
            : this(message, isOk ? NotificationLevel.Success : NotificationLevel.Warning) { }

        public NotificationViewModel(string message, NotificationLevel level = NotificationLevel.Info) {
            Message = message;
            Level = level;
        }

        public string Message { get; set; }

        public NotificationLevel Level { get; set; }
    }
}
