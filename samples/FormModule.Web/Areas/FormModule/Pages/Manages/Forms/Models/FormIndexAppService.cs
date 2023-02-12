using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Domain.FormModel;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models;
using CloudyWing.FormModule.Web.Areas.FormModule.Models.FormModel;
using CloudyWing.FormModule.Web.Models.Entities;

namespace CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.Forms.Models {
    public class FormIndexAppService
        : FormIndexAppService<
            IndexRecordModel,
            ApplicationFormEditor,
            FormDetailEditor<FormSectionEditor<FormQuestionEditor<QuestionChoiceEditor>, QuestionChoiceEditor>, FormQuestionEditor<QuestionChoiceEditor>, QuestionChoiceEditor>,
            FormSectionEditor<FormQuestionEditor<QuestionChoiceEditor>, QuestionChoiceEditor>,
            FormQuestionEditor<QuestionChoiceEditor>,
            QuestionChoiceEditor,
            ApplicationForm,
            long
        > {
        public FormIndexAppService(
            IServiceProvider? serviceProvider,
            IFormService<
                ApplicationFormEditor,
                FormDetailEditor<FormSectionEditor<FormQuestionEditor<QuestionChoiceEditor>, QuestionChoiceEditor>, FormQuestionEditor<QuestionChoiceEditor>, QuestionChoiceEditor>,
                FormSectionEditor<FormQuestionEditor<QuestionChoiceEditor>, QuestionChoiceEditor>,
                FormQuestionEditor<QuestionChoiceEditor>,
                QuestionChoiceEditor,
                ApplicationForm,
                long
            > formService
        ) : base(serviceProvider, formService) { }

        public override async Task<IPagedList<IndexRecordModel>> GetPagedListAsync(int pageNumber) {
            return await FormService.GetPagedListAsync(
                x => new IndexRecordModel {
                    Id = x.Id.ToString(),
                    Name = x.Name,
                    Code = x.Code,
                    StartTime = x.StartTime,
                    EndTime = x.EndTime,
                    DemoColumn = x.DemoColumn
                },
                x => x.OrderByDescending(y => y.StartTime),
                pageNumber,
                PagingOptions.PageSize
            );
        }
    }
}
