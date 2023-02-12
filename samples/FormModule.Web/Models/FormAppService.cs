using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Web.Models.Entities;

namespace CloudyWing.FormModule.Web.Models {
    public class FormMenuAppService {
        private readonly IQueryableService<ApplicationForm> formQueryService;

        public FormMenuAppService(IQueryableService<ApplicationForm> formQueryService) {
            this.formQueryService = formQueryService ?? throw new ArgumentNullException(nameof(formQueryService));
        }

        public async Task<IReadOnlyList<FormMenu>> GetFormMenusAsync() {
            return await formQueryService.GetListAsync(x => new FormMenu {
                Code = x.Code,
                Name = x.Name
            });
        }
    }
}
