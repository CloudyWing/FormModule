using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Domain.FormPageModel;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models;
using CloudyWing.FormModule.Web.Areas.FormModule.Models.FormPageModel;
using CloudyWing.FormModule.Web.Models.Entities;

namespace CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.FormPages.Models {
    public class FormPageIndexAppService
        : FormPageIndexAppService<IndexInputModel, IndexRecordModel, FormPageEditor, FormPageWithDetailsEditor<FormPageDetailEditor>, FormPageDetailEditor, ApplicationForm, ApplicationFormPage, long> {
        public FormPageIndexAppService(
            IServiceProvider? serviceProvider,
            IFormPageService<FormPageEditor, FormPageWithDetailsEditor<FormPageDetailEditor>, FormPageDetailEditor, ApplicationFormPage, long> formPageService,
            IQueryableService<ApplicationForm> formQueryService,
            IQueryableService<FormPageQueryEntity> formPageQueryService
        ) : base(serviceProvider, formPageService, formQueryService) {
            FormPageQueryService = formPageQueryService;
        }

        protected IQueryableService<FormPageQueryEntity> FormPageQueryService { get; }

        /// <inheritdoc/>
        public override async Task<IPagedList<IndexRecordModel>> GetPagedListAsync(IndexInputModel input, int pageNumber) {
            if (input is null) {
                throw new ArgumentNullException(nameof(input));
            }

            long? convertedFormId = IdConverter.ConvertIdFromString(input.FormId);

            if (convertedFormId is null) {
                return new PagedList<IndexRecordModel>(
                    new List<IndexRecordModel>(),
                    new PagingMetadata(1, PagingOptions.PageSize, 0)
                );
            }

            return await FormPageQueryService.GetPagedListAsync(
                x => new IndexRecordModel {
                    Id = x.Page.Id.ToString()!,
                    FormId = x.Page.FormId.ToString()!,
                    SecurityCode = x.Page.SecurityCode,
                    CompletionTime = x.Page.CompletionTime,
                    IP = x.Page.IP,
                    UserName = x.User.Name
                },
                x => x.OrderBy(y => y.Page.CompletionTime),
                pageNumber, PagingOptions.PageSize,
                x => x.Page.FormId.Equals(convertedFormId)
            );
        }
    }
}
