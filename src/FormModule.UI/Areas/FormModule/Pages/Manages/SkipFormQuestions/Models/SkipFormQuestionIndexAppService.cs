using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Domain.FormModel;
using CloudyWing.FormModule.Domain.SkipFormQuestionModel;
using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models {
    /// <summary>
    /// Represents an application service for the skip form question index.
    /// </summary>
    /// <typeparam name="TIndexViewModel">The type of the index view model.</typeparam>
    /// <typeparam name="TIndexRecordModel">The type of the index record model.</typeparam>
    /// <typeparam name="TSkipFormQuestionEditor">The type of the skip form question editor.</typeparam>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TSkipFormQuestionQueryEntity">The type of the skip form question query entity.</typeparam>
    /// <typeparam name="TFormDetailQueryEntity">The type of the form detail query entity.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TFormSection">The type of the form section.</typeparam>
    /// <typeparam name="TFormQuestion">The type of the form question.</typeparam>
    /// <typeparam name="TQuestionChoice">The type of the question choice.</typeparam>
    /// <typeparam name="TSkipFormQuestion">The type of the skip form question.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public class SkipFormQuestionIndexAppService<
        TIndexViewModel, TIndexRecordModel, TSkipFormQuestionEditor,
        TDbContext, TSkipFormQuestionQueryEntity, TFormDetailQueryEntity,
        TForm, TFormSection, TFormQuestion, TQuestionChoice, TSkipFormQuestion, TKey
    > : ApplicationService<TKey>, ISkipFormQuestionIndexAppService<TIndexViewModel, TIndexRecordModel>
        where TIndexViewModel : IndexViewModel, new()
        where TIndexRecordModel : IndexRecordModel, new()
        where TSkipFormQuestionEditor : SkipFormQuestionEditor, new()
        where TDbContext : DbContext
        where TSkipFormQuestionQueryEntity : SkipFormQuestionQueryEntity<TSkipFormQuestion, TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
        where TFormDetailQueryEntity : FormDetailQueryEntity<TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
        where TSkipFormQuestion : SkipFormQuestion<TKey>, new()
        where TForm : Form<TKey>, new()
        where TFormSection : FormSection<TKey>, new()
        where TFormQuestion : FormQuestion<TKey>, new()
        where TQuestionChoice : QuestionChoice<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkipFormQuestionIndexAppService{TIndexViewModel, TIndexRecordModel, TSkipFormQuestionEditor, TDbContext, TSkipFormQuestionQueryEntity, TFormDetailQueryEntity, TForm, TFormSection, TFormQuestion, TQuestionChoice, TSkipFormQuestion, TKey}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="skipFormQuestionService">The skip form question service.</param>
        /// <param name="skipFormQuestionQueryService">The skip form question query service.</param>
        /// <param name="formDetailQueryService">The form detail query service.</param>
        public SkipFormQuestionIndexAppService(
            IServiceProvider? serviceProvider,
            ISkipFormQuestionService<TSkipFormQuestionEditor, TSkipFormQuestion, TKey> skipFormQuestionService,
            IQueryableService<TSkipFormQuestionQueryEntity> skipFormQuestionQueryService,
            IQueryableService<TFormDetailQueryEntity> formDetailQueryService)
            : base(serviceProvider) {
            ExceptionUtils.ThrowIfNull(() => skipFormQuestionService);
            ExceptionUtils.ThrowIfNull(() => skipFormQuestionQueryService);
            ExceptionUtils.ThrowIfNull(() => formDetailQueryService);

            SkipFormQuestionService = skipFormQuestionService;
            SkipFormQuestionQueryService = skipFormQuestionQueryService;
            FormDetailQueryService = formDetailQueryService;
        }

        /// <summary>
        /// Gets the skip form question service.
        /// </summary>
        protected ISkipFormQuestionService<TSkipFormQuestionEditor, TSkipFormQuestion, TKey> SkipFormQuestionService { get; }

        /// <summary>
        /// Gets the skip form question query service.
        /// </summary>
        protected IQueryableService<TSkipFormQuestionQueryEntity> SkipFormQuestionQueryService { get; }

        /// <summary>
        /// Gets the form detail query service.
        /// </summary>
        protected IQueryableService<TFormDetailQueryEntity> FormDetailQueryService { get; }

        /// <inheritdoc/>
        public virtual async Task<TIndexViewModel> GetViewAsync(string? formId) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => formId);

            TKey? converted = IdConverter.ConvertIdFromString(formId);

            return await FormDetailQueryService.GetFirstOrDefaultAsync(
                x => new TIndexViewModel {
                    FormCode = x.Form.Code,
                    FormName = x.Form.Name
                },
                x => x.Form.Id.Equals(converted)
            );
        }

        /// <inheritdoc/>
        public virtual async Task<IPagedList<TIndexRecordModel>> GetPagedListAsync(string? formId, int pageNumber) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => formId);

            TKey? convertedFormId = IdConverter.ConvertIdFromString(formId);
            return await SkipFormQuestionQueryService.GetPagedListAsync(
                x => new TIndexRecordModel {
                    Id = x.Skip.Id.ToString()!,
                    QuestionText = x.Question.QuestionText,
                    ChoiceLabel = x.Choice!.Label,
                    SkipQuestionText = x.SkipQuestion.QuestionText
                },
                x => x.OrderBy(y => y.Form.Id).ThenBy(y => y.Question.DisplayOrder).ThenBy(y => y.Choice!.DisplayOrder).ThenBy(y => y.SkipQuestion.DisplayOrder),
                pageNumber, PagingOptions.PageSize,
                x => x.Form.Id.Equals(convertedFormId)
            );
        }

        /// <inheritdoc/>
        public virtual async Task<ApplicationResult<IPagedList<TIndexRecordModel>>> DeleteAsync(string? formId, string? id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => formId);
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);

            bool isOk = await SkipFormQuestionService.DeleteAsync(id);

            return new ApplicationResult<IPagedList<TIndexRecordModel>> {
                IsOk = isOk,
                Message = isOk
                    ? ServiceMessageProvider.DeleteSuccessMessageAccessor()
                    : ServiceMessageProvider.DeleteFailureMessageAccessor(),
                Data = await GetPagedListAsync(formId, 1)
            };
        }
    }
}
