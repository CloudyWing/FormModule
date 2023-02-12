using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Domain.FormModel;
using CloudyWing.FormModule.Domain.FormPageModel;
using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models {
    /// <summary>
    /// Represents the form page display application service.
    /// </summary>
    /// <typeparam name="TDisplaySettingsModel">The type of the display settings model.</typeparam>
    /// <typeparam name="TDisplaySectionSettingsModel">The type of the display section settings model.</typeparam>
    /// <typeparam name="TDisplayQuestionSettingsModel">The type of the display question settings model.</typeparam>
    /// <typeparam name="TDisplayChoiceSettingsModel">The type of the display choice settings model.</typeparam>
    /// <typeparam name="TDisplayResponseModel">The type of the display response model.</typeparam>
    /// <typeparam name="TDisplayQuestionResponseModel">The type of the display question response model.</typeparam>
    /// <typeparam name="TDisplayChoiceResponseModel">The type of the display choice response model.</typeparam>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TFormDetailQueryEntity">The type of the form detail query entity.</typeparam>
    /// <typeparam name="TFormPageDetailQueryEntity">The type of the form page detail query entity.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TFormSection">The type of the form section.</typeparam>
    /// <typeparam name="TFormQuestion">The type of the form question.</typeparam>
    /// <typeparam name="TQuestionChoice">The type of the question choice.</typeparam>
    /// <typeparam name="TFormPage">The type of the form page.</typeparam>
    /// <typeparam name="TFormPageDetail">The type of the form page detail.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public class FormPageDisplayAppService<
        TDisplaySettingsModel, TDisplaySectionSettingsModel, TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel,
        TDisplayResponseModel, TDisplayQuestionResponseModel, TDisplayChoiceResponseModel,
        TDbContext, TFormDetailQueryEntity, TFormPageDetailQueryEntity,
        TForm, TFormSection, TFormQuestion, TQuestionChoice, TFormPage, TFormPageDetail, TKey
    > : ApplicationService<TKey>,
        IFormPageDisplayAppService<TDisplaySettingsModel, TDisplaySectionSettingsModel, TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel, TDisplayResponseModel, TDisplayQuestionResponseModel, TDisplayChoiceResponseModel>
        where TDisplaySettingsModel : DisplaySettingsModel<TDisplaySectionSettingsModel, TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel>, new()
        where TDisplaySectionSettingsModel : DisplaySectionSettingsModel<TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel>, new()
        where TDisplayQuestionSettingsModel : DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>, new()
        where TDisplayChoiceSettingsModel : DisplayChoiceSettingsModel, new()
        where TDisplayResponseModel : DisplayResponseModel<TDisplayQuestionResponseModel, TDisplayChoiceResponseModel>, new()
        where TDisplayQuestionResponseModel : DisplayQuestionResponseModel<TDisplayChoiceResponseModel>, new()
        where TDisplayChoiceResponseModel : DisplayChoiceResponseModel, new()
        where TDbContext : DbContext
        where TFormDetailQueryEntity : FormDetailQueryEntity<TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
        where TFormPageDetailQueryEntity : FormPageDetailQueryEntity<TFormPageDetail, TFormPage, TForm, TKey>, new()
        where TForm : Form<TKey>, new()
        where TFormSection : FormSection<TKey>, new()
        where TFormQuestion : FormQuestion<TKey>, new()
        where TQuestionChoice : QuestionChoice<TKey>, new()
        where TFormPage : FormPage<TKey>, new()
        where TFormPageDetail : FormPageDetail<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormPageDisplayAppService{TDisplaySettingsModel, TDisplaySectionSettingsModel, TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel, TDisplayResponseModel, TDisplayQuestionResponseModel, TDisplayChoiceResponseModel, TDbContext, TFormDetailQueryEntity, TFormPageDetailQueryEntity, TForm, TFormSection, TFormQuestion, TQuestionChoice, TFormPage, TFormPageDetail, TKey}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="formDetailQueryService">The form detail query service.</param>
        /// <param name="formPageDetailQueryService">The form page detail query service.</param>
        public FormPageDisplayAppService(
            IServiceProvider? serviceProvider,
            IQueryableService<TFormDetailQueryEntity> formDetailQueryService,
            IQueryableService<TFormPageDetailQueryEntity> formPageDetailQueryService
        ) : base(serviceProvider) {
            ExceptionUtils.ThrowIfNull(() => formDetailQueryService);
            ExceptionUtils.ThrowIfNull(() => formPageDetailQueryService);

            FormDetailQueryService = formDetailQueryService;
            FormPageDetailQueryService = formPageDetailQueryService;
        }

        /// <summary>
        /// Gets the form detail query service.
        /// </summary>
        protected IQueryableService<TFormDetailQueryEntity> FormDetailQueryService { get; }

        /// <summary>
        /// Gets the form page detail query service.
        /// </summary>
        protected IQueryableService<TFormPageDetailQueryEntity> FormPageDetailQueryService { get; }

        /// <inheritdoc/>
        public virtual async Task<TDisplaySettingsModel> GetSettingsAsync(string? formId) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => formId);
            TKey? convertedFormId = IdConverter.ConvertIdFromString(formId);

            IReadOnlyList<TFormDetailQueryEntity> list =
                await FormDetailQueryService.GetListAsync(
                    x => x.Form.Id.Equals(convertedFormId),
                    x => x.OrderBy(y => y.Section.DisplayOrder)
                        .ThenBy(y => y.Question.DisplayOrder)
                        .ThenBy(y => y.Choice!.DisplayOrder)
                );

            TForm form = list[0].Form;

            return new TDisplaySettingsModel {
                FormId = IdConverter.ConvertIdToString(form.Id)!,
                Name = form.Name,
                IsInternal = form.IsInternal,
                Role = form.Role,
                CanUpdate = form.CanUpdate,
                Header = form.Header,
                Footer = form.Footer,
                Sections = list.GroupBy(x => x.Section.Id).Select(x => {
                    TFormSection section = x.First().Section;

                    return new TDisplaySectionSettingsModel {
                        Id = section.Id.ToString()!,
                        Name = section.Name!,
                        Questions = x.GroupBy(y => y.Question.Id).Select(y => {
                            TFormQuestion question = y.First().Question;

                            return new TDisplayQuestionSettingsModel {
                                Id = question.Id.ToString()!,
                                QuestionText = question.QuestionText!,
                                QuestionType = question.QuestionType,
                                IsRequired = question.IsRequired,
                                Choices = y.Where(z => z.Choice is not null).Select(z => new TDisplayChoiceSettingsModel {
                                    Id = z.Choice!.Id.ToString()!,
                                    Label = z.Choice.Label!,
                                    HasText = z.Choice.HasText
                                }).ToList()
                            };
                        }).ToList()
                    };
                }).ToList()
            };
        }

        /// <inheritdoc/>
        public virtual async Task<TDisplayResponseModel> GetResponseAsync(string? formId, string? id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => formId);
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);
            DateTimeOffset now = DateTimeOffset.UtcNow;
            TKey? convertedFormId = IdConverter.ConvertIdFromString(formId);
            TKey? convertedId = IdConverter.ConvertIdFromString(id);

            IReadOnlyList<TFormPageDetailQueryEntity> list = await FormPageDetailQueryService.GetListAsync(
                x => x.Form.Id.Equals(convertedFormId) && x.Page.Id.Equals(convertedId)
            );

            if (!list.Any()) {
                return new TDisplayResponseModel {
                    FormId = formId,
                };
            }

            TFormPage formPage = list[0].Page;

            return new TDisplayResponseModel {
                FormId = IdConverter.ConvertIdToString(formPage.FormId),
                FormPageId = IdConverter.ConvertIdToString(formPage.Id),
                Questions = list.GroupBy(x => x.PageDetail.FormQuestionId).Select(y => new TDisplayQuestionResponseModel {
                    FormQuestionId = IdConverter.ConvertIdToString(y.Key)!,
                    Response = y.SingleOrDefault(z => z.PageDetail.QuestionChoiceId is null)?.PageDetail.Response,
                    Choices = y.Where(z => z.PageDetail.QuestionChoiceId is not null).Select(z => {
                        string convertedChoiceId = IdConverter.ConvertIdToString(z.PageDetail.QuestionChoiceId)!;

                        return new TDisplayChoiceResponseModel {
                            QuestionChoiceId = convertedChoiceId,
                            IsChecked = !string.IsNullOrWhiteSpace(convertedChoiceId),
                            Response = z.PageDetail.Response
                        };
                    }).ToList()
                }).ToList()
            };
        }
    }
}
