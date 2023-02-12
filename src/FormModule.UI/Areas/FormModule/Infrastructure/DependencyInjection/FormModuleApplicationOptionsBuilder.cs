using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection {
    /// <summary>
    /// Builds application options for the form module.
    /// </summary>
    public class FormModuleApplicationOptionsBuilder {
        private readonly Dictionary<Type, Type> serviceTypeMaps = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormModuleApplicationOptionsBuilder"/> class.
        /// </summary>
        public FormModuleApplicationOptionsBuilder() {
            serviceTypeMaps.Add(typeof(IFormIndexAppService<Pages.Manages.Forms.Models.IndexRecordModel>), typeof(FormIndexAppService<,,,,,,,>));
            serviceTypeMaps.Add(typeof(IFormEditAppService<Pages.Manages.Forms.Models.EditInputModel>), typeof(FormEditAppService<,,,,,,,>));
            serviceTypeMaps.Add(typeof(IFormEditDetailsAppService<EditDetailsViewModel, EditDetailsInputModel<EditDetailsSectionInputModel<EditDetailsQuestionInputModel<EditDetailsChoiceInputModel>, EditDetailsChoiceInputModel>, EditDetailsQuestionInputModel<EditDetailsChoiceInputModel>, EditDetailsChoiceInputModel>, EditDetailsSectionInputModel<EditDetailsQuestionInputModel<EditDetailsChoiceInputModel>, EditDetailsChoiceInputModel>, EditDetailsQuestionInputModel<EditDetailsChoiceInputModel>, EditDetailsChoiceInputModel>), typeof(FormEditDetailsAppService<,,,,,,,,,,,,,,,,>));

            serviceTypeMaps.Add(typeof(ISkipFormQuestionIndexAppService<IndexViewModel, Pages.Manages.SkipFormQuestions.Models.IndexRecordModel>), typeof(SkipFormQuestionIndexAppService<,,,,,,,,,,,>));
            serviceTypeMaps.Add(typeof(ISkipFormQuestionEditAppService<EditViewModel, Pages.Manages.SkipFormQuestions.Models.EditInputModel>), typeof(SkipFormQuestionEditAppService<,,,,,,,,,,,,>));

            serviceTypeMaps.Add(typeof(IFormPageIndexAppService<IndexInputModel, Pages.Manages.FormPages.Models.IndexRecordModel>), typeof(FormPageIndexAppService<,,,,,,,>));
            serviceTypeMaps.Add(typeof(IFormPageDisplayAppService<DisplaySettingsModel<DisplaySectionSettingsModel<DisplayQuestionSettingsModel<DisplayChoiceSettingsModel>, DisplayChoiceSettingsModel>, DisplayQuestionSettingsModel<DisplayChoiceSettingsModel>, DisplayChoiceSettingsModel>, DisplaySectionSettingsModel<DisplayQuestionSettingsModel<DisplayChoiceSettingsModel>, DisplayChoiceSettingsModel>, DisplayQuestionSettingsModel<DisplayChoiceSettingsModel>, DisplayChoiceSettingsModel, DisplayResponseModel<DisplayQuestionResponseModel<DisplayChoiceResponseModel>, DisplayChoiceResponseModel>, DisplayQuestionResponseModel<DisplayChoiceResponseModel>, DisplayChoiceResponseModel>), typeof(FormPageDisplayAppService<,,,,,,,,,,,,,,,,>));

            serviceTypeMaps.Add(typeof(IFormSubmissionIndexAppService<IndexViewModel<IndexSectionViewModel<IndexQuestionViewModel<IndexChoiceViewModel>, IndexChoiceViewModel>, IndexQuestionViewModel<IndexChoiceViewModel>, IndexChoiceViewModel, IndexSkipViewModel>, IndexSectionViewModel<IndexQuestionViewModel<IndexChoiceViewModel>, IndexChoiceViewModel>, IndexQuestionViewModel<IndexChoiceViewModel>, IndexChoiceViewModel, IndexSkipViewModel, IndexInputModel<IndexQuestionInputModel<IndexChoiceInputModel>, IndexChoiceInputModel>, IndexQuestionInputModel<IndexChoiceInputModel>, IndexChoiceInputModel>), typeof(FormSubmissionIndexAppService<,,,,,,,,,,,,,,,,,,,,,,>));
            serviceTypeMaps.Add(typeof(IFormSubmissionCompletionAppService<CompletionViewModel>), typeof(FormSubmissionCompletionAppService<,,,,,>));
        }

        /// <summary>
        /// Gets or sets the action for configuring application options.
        /// </summary>
        public Action<ApplicationOptions>? ApplicationOptionsAction { get; set; } =
            x => new ApplicationOptions();


        /// <summary>
        /// Gets or sets the factory function for creating the user context.
        /// </summary>
        public Func<IServiceProvider, IUserContext>? UserFactory { get; set; } =
            x => new UserContext();

        /// <summary>
        /// Gets or sets the action for configuring paging options.
        /// </summary>
        public Action<PagingOptions>? PagingOptionsAction { get; set; } =
            x => new PagingOptions();

        /// <summary>
        /// Gets or sets the service message provider.
        /// </summary>
        public IServiceMessageProvider ServiceMessageProvider { get; set; } = new ServiceMessageProvider();

        /// <summary>
        /// Gets the service type maps.
        /// </summary>
        internal IDictionary<Type, Type> ServiceTypeMaps => serviceTypeMaps;

        /// <summary>
        /// Registers a service type and its implementation type.
        /// </summary>
        /// <param name="serviceType">The service type.</param>
        /// <param name="implementationType">The implementation type.</param>
        public void RegisterServiceType(Type serviceType, Type implementationType) {
            serviceTypeMaps.Add(serviceType, implementationType);
        }
    }
}
