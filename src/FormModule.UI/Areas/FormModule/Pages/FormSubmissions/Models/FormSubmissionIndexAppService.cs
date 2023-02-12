using System.Linq.Expressions;
using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Domain.FormModel;
using CloudyWing.FormModule.Domain.FormPageModel;
using CloudyWing.FormModule.Domain.SkipFormQuestionModel;
using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models {
    /// <summary>
    /// Represents the application service for form submission index.
    /// </summary>
    /// <typeparam name="TIndexViewModel">The type of the index view model.</typeparam>
    /// <typeparam name="TIndexSectionViewModel">The type of the index section view model.</typeparam>
    /// <typeparam name="TIndexQuestionViewModel">The type of the index question view model.</typeparam>
    /// <typeparam name="TIndexChoiceViewModel">The type of the index choice view model.</typeparam>
    /// <typeparam name="TIndexSkipViewModel">The type of the index skip view model.</typeparam>
    /// <typeparam name="TIndexInputModel">The type of the index input model.</typeparam>
    /// <typeparam name="TIndexQuestionInputModel">The type of the index question input model.</typeparam>
    /// <typeparam name="TIndexChoiceInputModel">The type of the index choice input model.</typeparam>
    /// <typeparam name="TFormPageEditor">The type of the form page editor.</typeparam>
    /// <typeparam name="TFormPageWithDetailsEditor">The type of the form page with details editor.</typeparam>
    /// <typeparam name="TFormPageDetailEditor">The type of the form page detail editor.</typeparam>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TFormDetailQueryEntity">The type of the form detail query entity.</typeparam>
    /// <typeparam name="TFormPageDetailQueryEntity">The type of the form page detail query entity.</typeparam>
    /// <typeparam name="TSkipFormQuestionQueryEntity">The type of the skip form question query entity.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TFormSection">The type of the form section.</typeparam>
    /// <typeparam name="TFormQuestion">The type of the form question.</typeparam>
    /// <typeparam name="TQuestionChoice">The type of the question choice.</typeparam>
    /// <typeparam name="TSkipFormQuestion">The type of the skip form question.</typeparam>
    /// <typeparam name="TFormPage">The type of the form page.</typeparam>
    /// <typeparam name="TFormPageDetail">The type of the form page detail.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public class FormSubmissionIndexAppService<
            TIndexViewModel, TIndexSectionViewModel, TIndexQuestionViewModel, TIndexChoiceViewModel, TIndexSkipViewModel, TIndexInputModel, TIndexQuestionInputModel, TIndexChoiceInputModel,
            TFormPageEditor, TFormPageWithDetailsEditor, TFormPageDetailEditor,
            TDbContext, TFormDetailQueryEntity, TFormPageDetailQueryEntity, TSkipFormQuestionQueryEntity,
            TForm, TFormSection, TFormQuestion, TQuestionChoice, TSkipFormQuestion, TFormPage, TFormPageDetail, TKey
        >
        : ApplicationService<TKey>,
        IFormSubmissionIndexAppService<TIndexViewModel, TIndexSectionViewModel, TIndexQuestionViewModel, TIndexChoiceViewModel, TIndexSkipViewModel, TIndexInputModel, TIndexQuestionInputModel, TIndexChoiceInputModel>
        where TIndexViewModel : IndexViewModel<TIndexSectionViewModel, TIndexQuestionViewModel, TIndexChoiceViewModel, TIndexSkipViewModel>, new()
        where TIndexSectionViewModel : IndexSectionViewModel<TIndexQuestionViewModel, TIndexChoiceViewModel>, new()
        where TIndexQuestionViewModel : IndexQuestionViewModel<TIndexChoiceViewModel>, new()
        where TIndexChoiceViewModel : IndexChoiceViewModel, new()
        where TIndexSkipViewModel : IndexSkipViewModel, new()
        where TIndexInputModel : IndexInputModel<TIndexQuestionInputModel, TIndexChoiceInputModel>, new()
        where TIndexQuestionInputModel : IndexQuestionInputModel<TIndexChoiceInputModel>, new()
        where TIndexChoiceInputModel : IndexChoiceInputModel, new()
        where TFormPageEditor : FormPageEditor, new()
        where TFormPageWithDetailsEditor : FormPageWithDetailsEditor<TFormPageDetailEditor>, new()
        where TFormPageDetailEditor : FormPageDetailEditor, new()
        where TDbContext : DbContext
        where TFormDetailQueryEntity : FormDetailQueryEntity<TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
        where TFormPageDetailQueryEntity : FormPageDetailQueryEntity<TFormPageDetail, TFormPage, TForm, TKey>, new()
        where TSkipFormQuestionQueryEntity : SkipFormQuestionQueryEntity<TSkipFormQuestion, TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
        where TForm : Form<TKey>, new()
        where TFormSection : FormSection<TKey>, new()
        where TFormQuestion : FormQuestion<TKey>, new()
        where TQuestionChoice : QuestionChoice<TKey>, new()
        where TSkipFormQuestion : SkipFormQuestion<TKey>, new()
        where TFormPage : FormPage<TKey>, new()
        where TFormPageDetail : FormPageDetail<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormSubmissionIndexAppService{TIndexViewModel, TIndexSectionViewModel, TIndexQuestionViewModel, TIndexChoiceViewModel, TIndexSkipViewModel, TIndexInputModel, TIndexQuestionInputModel, TIndexChoiceInputModel, TFormPageEditor, TFormPageWithDetailsEditor, TFormPageDetailEditor, TDbContext, TFormDetailQueryEntity, TFormPageDetailQueryEntity, TSkipFormQuestionQueryEntity, TForm, TFormSection, TFormQuestion, TQuestionChoice, TSkipFormQuestion, TFormPage, TFormPageDetail, TKey}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="formPageService">The form page service.</param>
        /// <param name="formDetailQueryService">The form detail query service.</param>
        /// <param name="formPageDetailQueryService">The form page detail query service.</param>
        /// <param name="skipFormQuestionQueryService">The skip form question query service.</param>
        public FormSubmissionIndexAppService(
            IServiceProvider? serviceProvider,
            IFormPageService<TFormPageEditor, TFormPageWithDetailsEditor, TFormPageDetailEditor, TFormPage, TKey> formPageService,
            IQueryableService<TFormDetailQueryEntity> formDetailQueryService,
            IQueryableService<TFormPageDetailQueryEntity> formPageDetailQueryService,
            IQueryableService<TSkipFormQuestionQueryEntity> skipFormQuestionQueryService
        ) : base(serviceProvider) {
            ExceptionUtils.ThrowIfNull(() => formPageService);
            ExceptionUtils.ThrowIfNull(() => formDetailQueryService);
            ExceptionUtils.ThrowIfNull(() => formPageDetailQueryService);
            ExceptionUtils.ThrowIfNull(() => skipFormQuestionQueryService);

            FormPageService = formPageService;
            FormDetailQueryService = formDetailQueryService;
            FormPageDetailQueryService = formPageDetailQueryService;
            SkipFormQuestionQueryService = skipFormQuestionQueryService;
        }

        /// <summary>
        /// Gets the form page service.
        /// </summary>
        protected IFormPageService<TFormPageEditor, TFormPageWithDetailsEditor, TFormPageDetailEditor, TFormPage, TKey> FormPageService { get; }

        /// <summary>
        /// Gets the form detail query service.
        /// </summary>
        protected IQueryableService<TFormDetailQueryEntity> FormDetailQueryService { get; }

        /// <summary>
        /// Gets the form page detail query service.
        /// </summary>
        protected IQueryableService<TFormPageDetailQueryEntity> FormPageDetailQueryService { get; }

        /// <summary>
        /// Gets the skip form question query service.
        /// </summary>
        protected IQueryableService<TSkipFormQuestionQueryEntity> SkipFormQuestionQueryService { get; }

        /// <inheritdoc/>
        public virtual async Task<TIndexViewModel> GetViewAsync(string? code) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => code);
            DateTimeOffset now = DateTimeOffset.UtcNow;

            return await GetViewModelInternalAsync(x => x.Form.Code == code && x.Form.StartTime <= now && x.Form.EndTime >= now);
        }

        /// <inheritdoc/>
        private async Task<TIndexViewModel> GetViewModelInternalAsync(
            Expression<Func<TFormDetailQueryEntity, bool>> filter
        ) {
            IReadOnlyList<TFormDetailQueryEntity> list =
                await FormDetailQueryService.GetListAsync(
                    filter,
                    x => x.OrderBy(y => y.Section.DisplayOrder)
                        .ThenBy(y => y.Question.DisplayOrder)
                        .ThenBy(y => y.Choice!.DisplayOrder)
                );

            if (list.Count == 0) {
                return new TIndexViewModel();
            }

            TForm form = list[0].Form;

            return new TIndexViewModel {
                FormId = IdConverter.ConvertIdToString(form.Id)!,
                Name = form.Name,
                IsInternal = form.IsInternal,
                Role = form.Role,
                CanUpdate = form.CanUpdate,
                Header = form.Header,
                Footer = form.Footer,
                Sections = list.GroupBy(x => x.Section.Id).Select(x => {
                    TFormSection section = x.First().Section;

                    return new TIndexSectionViewModel {
                        Id = section.Id.ToString()!,
                        Name = section.Name!,
                        Questions = x.GroupBy(y => y.Question.Id).Select(y => {
                            TFormQuestion question = y.First().Question;

                            return new TIndexQuestionViewModel {
                                Id = question.Id.ToString()!,
                                QuestionText = question.QuestionText!,
                                QuestionType = question.QuestionType,
                                IsRequired = question.IsRequired,
                                Choices = y.Where(z => z.Choice is not null).Select(z => new TIndexChoiceViewModel {
                                    Id = z.Choice!.Id.ToString()!,
                                    Label = z.Choice.Label!,
                                    HasText = z.Choice.HasText
                                }).ToList()
                            };
                        }).ToList()
                    };
                }).ToList(),
                SkipSettings = (await SkipFormQuestionQueryService.GetListAsync(
                    x => new TIndexSkipViewModel {
                        FormQuestionId = x.Skip.FormQuestionId.ToString(),
                        QuestionChoiceId = x.Skip.QuestionChoiceId.ToString(),
                        SkipQuestionId = x.Skip.SkipQuestionId.ToString()
                    }
                )).ToList()
            };
        }

        /// <inheritdoc/>
        public virtual async Task<TIndexViewModel> GetViewByFormIdAsync(string? formId) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => formId);
            TKey? convertedId = IdConverter.ConvertIdFromString(formId);

            return await GetViewModelInternalAsync(x => x.Form.Id.Equals(convertedId));
        }

        /// <inheritdoc/>
        public virtual async Task<TIndexInputModel> GetInputAsync(string? formId, string? securityCode) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => formId);
            DateTimeOffset now = DateTimeOffset.UtcNow;
            TKey? convertedFormId = IdConverter.ConvertIdFromString(formId);

            IReadOnlyList<TFormPageDetailQueryEntity> list = await FormPageDetailQueryService.GetListAsync(
                x => x.Form.Id.Equals(convertedFormId) && x.Page.SecurityCode == securityCode
            );

            if (!list.Any()) {
                return new TIndexInputModel {
                    FormId = formId,
                };
            }

            TFormPage formPage = list[0].Page;

            return new TIndexInputModel {
                FormId = IdConverter.ConvertIdToString(formPage.FormId),
                FormPageId = IdConverter.ConvertIdToString(formPage.Id),
                Questions = list.GroupBy(x => x.PageDetail.FormQuestionId).Select(y => new TIndexQuestionInputModel {
                    FormQuestionId = IdConverter.ConvertIdToString(y.Key)!,
                    Response = y.SingleOrDefault(z => z.PageDetail.QuestionChoiceId is null)?.PageDetail.Response,
                    Choices = y.Where(z => z.PageDetail.QuestionChoiceId is not null).Select(z => {
                        string convertedChoiceId = IdConverter.ConvertIdToString(z.PageDetail.QuestionChoiceId)!;

                        return new TIndexChoiceInputModel {
                            QuestionChoiceId = convertedChoiceId,
                            IsChecked = !string.IsNullOrWhiteSpace(convertedChoiceId),
                            Response = z.PageDetail.Response
                        };
                    }).ToList()
                }).ToList()
            };
        }

        /// <inheritdoc/>
        public virtual Task<bool> VerifyInputAsync(TIndexInputModel? inputModel, TIndexViewModel? viewModel, ModelStateDictionary? modelState) {
            ExceptionUtils.ThrowIfNull(() => inputModel);
            ExceptionUtils.ThrowIfNull(() => viewModel);
            ExceptionUtils.ThrowIfNull(() => modelState);

            IEnumerable<string> skipQuestionIds = GetSkipQuestionIds(inputModel, viewModel.SkipSettings);
            int questionIndex = 0;

            viewModel.Sections.ForEach(sectionView => {
                sectionView.Questions.ForEach(questionView => {
                    if (skipQuestionIds.Contains(questionView.Id)) {
                        questionIndex++;
                        return;
                    }

                    TIndexQuestionInputModel? questionInput = inputModel.Questions.SingleOrDefault(x => x.FormQuestionId == questionView.Id);

                    if (questionView.IsRequired) {
                        if (questionInput is null) {
                            modelState.AddModelError("Input.Questions", ServiceMessageProvider.QuestionRequiredMessageAccessor());
                            questionIndex++;
                            return;
                        }

                        if (questionView.QuestionType == QuestionType.MultiChoice
                            || questionView.QuestionType == QuestionType.MultiSelection
                            || questionView.QuestionType == QuestionType.DropDownList
                        ) {
                            // DropDownList Id 不一定有值，IsChecked 目前固定為 true
                            // 其他 Id 有值，但 IsChecked 有勾選才會是 true
                            if (!questionInput.Choices.Any(x => !string.IsNullOrWhiteSpace(x.QuestionChoiceId) && x.IsChecked)) {
                                modelState.AddModelError($"Input.Questions[{questionIndex}]", ServiceMessageProvider.QuestionRequiredMessageAccessor());
                            }
                        } else if (questionView.QuestionType == QuestionType.ShortAnswer
                            || questionView.QuestionType == QuestionType.LongAnswer
                        ) {
                            if (string.IsNullOrWhiteSpace(questionInput.Response)) {
                                modelState.AddModelError(
                                    $"Input.Questions[{questionIndex}]",
                                    ServiceMessageProvider.QuestionRequiredMessageAccessor()
                                );
                            }
                        }
                    }

                    int choiceIndex = 0;
                    questionView.Choices.ForEach(choiceView => {
                        if (choiceView.HasText) {
                            TIndexChoiceInputModel? choiceInput = questionInput?.Choices.SingleOrDefault(x => x.QuestionChoiceId == choiceView.Id);

                            if (!string.IsNullOrWhiteSpace(choiceInput?.QuestionChoiceId)
                                && choiceInput.IsChecked
                                && string.IsNullOrWhiteSpace(choiceInput.Response)
                            ) {
                                modelState.AddModelError(
                                    $"Input.Questions[{questionIndex}].Choices[{choiceIndex}].Response",
                                    ServiceMessageProvider.TextRequiredIfCheckedMessageAccessor()
                                );
                            }
                        }

                        if (questionView.QuestionType == QuestionType.MultiSelection) {
                            choiceIndex++;
                        }
                    });

                    questionIndex++;
                });
            });

            return Task.FromResult(modelState.IsValid);
        }

        private static IEnumerable<string> GetSkipQuestionIds(TIndexInputModel inputModel, IEnumerable<TIndexSkipViewModel> skipSettings) {
            foreach (TIndexQuestionInputModel question in inputModel.Questions) {
                foreach (IndexSkipViewModel viewModel in skipSettings) {
                    if (viewModel.FormQuestionId == question.FormQuestionId && viewModel.QuestionChoiceId == null) {
                        yield return viewModel.SkipQuestionId!;
                    }
                }

                foreach (TIndexChoiceInputModel choice in question.Choices) {
                    if (!string.IsNullOrWhiteSpace(choice.QuestionChoiceId) && choice.IsChecked) {
                        foreach (TIndexSkipViewModel viewModel in skipSettings) {
                            if (viewModel.QuestionChoiceId == choice.QuestionChoiceId) {
                                yield return viewModel.SkipQuestionId!;
                            }
                        }
                    }
                }
            }
        }

        /// <inheritdoc/>
        public virtual async Task<ApplicationResult<string>> UpsertAsync(TIndexInputModel? input, IEnumerable<TIndexSkipViewModel> skipSettings) {
            ExceptionUtils.ThrowIfNull(() => input);

            TFormPageWithDetailsEditor editor = new() {
                FormId = input.FormId,
                SecurityCode = string.IsNullOrWhiteSpace(input.SecurityCode)
                    ? Guid.NewGuid().ToString()
                    : input.SecurityCode,
                IP = IPAddressContext.UserRealAddress ?? "",
                ExecutedBy = User?.UserId ?? ""
            };

            if (!string.IsNullOrWhiteSpace(input.FormPageId)) {
                editor.SetId(input.FormPageId);
            }

            IEnumerable<string> skipQuestionIds = GetSkipQuestionIds(input, skipSettings);

            input.Questions.ForEach((question) => {
                if (skipQuestionIds.Contains(question.FormQuestionId)) {
                    return;
                }

                if (question.Choices.Any()) {
                    IEnumerable<TIndexChoiceInputModel> choices = question
                        .Choices.Where(x => x.QuestionChoiceId is not null && x.IsChecked);

                    foreach (TIndexChoiceInputModel choice in choices) {
                        editor.Details.Add(new TFormPageDetailEditor {
                            FormQuestionId = question.FormQuestionId,
                            QuestionChoiceId = choice.QuestionChoiceId,
                            Response = choice.Response
                        });
                    }
                } else {
                    editor.Details.Add(new TFormPageDetailEditor {
                        FormQuestionId = question.FormQuestionId,
                        Response = question.Response
                    });
                }
            });

            bool isOk = await FormPageService.UpsertDetailsAsync(editor);

            return new ApplicationResult<string> {
                IsOk = isOk,
                Message = isOk ? "儲存成功！" : "儲存失敗！",
                Data = isOk ? editor.Id : null
            };
        }
    }
}
