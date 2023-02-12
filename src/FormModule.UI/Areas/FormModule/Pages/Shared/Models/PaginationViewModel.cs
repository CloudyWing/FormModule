using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Shared.Models {
    public class PaginationViewModel : PagingMetadata {
        public PaginationViewModel(IPagingMetadata pagingMetadata, string? formId, string? page, string? pageHandler = null)
            : base(pagingMetadata.PageNumber, pagingMetadata.PageSize, pagingMetadata.TotalItemCount) {

            ExceptionUtils.ThrowIfNull(() => pagingMetadata);
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => formId);
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => page);

            FormId = formId;
            Page = page;
            PageHandler = pageHandler;
        }

        public string FormId { get; }

        public string Page { get; }

        public string? PageHandler { get; }
    }
}
