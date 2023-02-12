using CloudyWing.FormModule.Domain.FormModel;
using CloudyWing.FormModule.Domain.FormPageModel;
using CloudyWing.FormModule.Domain.SkipFormQuestionModel;
using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.Domain.DependencyInjection {
    /// <summary>
    /// Builder class for constructing FormModule domain options.
    /// </summary>
    public class FormModuleDomainOptionsBuilder {
        private readonly Dictionary<string, Type> editorTypeMaps = new(StringComparer.OrdinalIgnoreCase);
        private Type? mapperType;
        private Type? idConverterType;
        private Type? userIdConverterType;
        private Type? formServiceType;
        private Type? formQuestionQueryServiceType;
        private Type? formDetailQueryServiceType;
        private Type? skipFormQuestionServiceType;
        private Type? skipFormQuestionQueryServiceType;
        private Type? formPageServiceType;
        private Type? formPageQueryServiceType;
        private Type? formPageDetailQueryServiceType;
        private const string FormEditorConst = "TFormEditor";
        private const string FormDetailEditorConst = "TFormDetailEditor";
        private const string FormSectionEditorConst = "TFormSectionEditor";
        private const string FormQuestionEditorConst = "TFormQuestionEditor";
        private const string QuestionChoiceEditorConst = "TQuestionChoiceEditor";
        private const string SkipFormQuestionEditorConst = "TSkipFormQuestionEditor";
        private const string FormPageEditorConst = "TFormPageEditor";
        private const string FormPageWithDetailsEditorConst = "TFormPageWithDetailsEditor";
        private const string FormPageDetailEditorConst = "TFormPageDetailEditor";

        /// <summary>
        /// Initializes a new instance of the <see cref="FormModuleDomainOptionsBuilder"/> class.
        /// </summary>
        public FormModuleDomainOptionsBuilder() {
            FormEditorType = typeof(FormEditor);
            FormDetailEditorType = typeof(FormDetailEditor<FormSectionEditor<FormQuestionEditor<QuestionChoiceEditor>, QuestionChoiceEditor>, FormQuestionEditor<QuestionChoiceEditor>, QuestionChoiceEditor>);
            FormSectionEditorType = typeof(FormSectionEditor<FormQuestionEditor<QuestionChoiceEditor>, QuestionChoiceEditor>);
            FormQuestionEditorType = typeof(FormQuestionEditor<QuestionChoiceEditor>);
            QuestionChoiceEditorType = typeof(QuestionChoiceEditor);
            SkipFormQuestionEditorType = typeof(SkipFormQuestionEditor);
            FormPageEditorType = typeof(FormPageEditor);
            FormPageWithDetailsEditorType = typeof(FormPageWithDetailsEditor<FormPageDetailEditor>);
            FormPageDetailEditorType = typeof(FormPageDetailEditor);
        }

        /// <summary>
        /// Gets or sets the mapper type.
        /// </summary>
        public Type? MapperType {
            get => mapperType;
            set {
                ExceptionUtils.ThrowIfInvalidAssignableType(typeof(IFormModuleMapper), value);
                mapperType = value;
            }
        }

        /// <summary>
        /// Gets or sets the ID converter type.
        /// </summary>
        public Type? IdConverterType {
            get => idConverterType;
            set {
                ExceptionUtils.ThrowIfInvalidAssignableType(typeof(IIdConverter<>), value);
                idConverterType = value;
            }
        }

        /// <summary>
        /// Gets or sets the user ID converter type.
        /// </summary>
        public Type? UserIdConverterType {
            get => userIdConverterType;
            set {
                ExceptionUtils.ThrowIfInvalidAssignableType(typeof(IUserIdConverter<>), value);
                userIdConverterType = value;
            }
        }

        /// <summary>
        /// Gets or sets the form service type.
        /// </summary>
        public Type? FormServiceType {
            get => formServiceType;
            set {
                ExceptionUtils.ThrowIfInvalidAssignableType(typeof(IFormService<,,,,,,>), value);
                formServiceType = value;
            }
        }

        /// <summary>
        /// Gets or sets the form question query service type.
        /// </summary>
        public Type? FormQuestionQueryServiceType {
            get => formQuestionQueryServiceType;
            set {
                ExceptionUtils.ThrowIfInvalidAssignableType(typeof(FormQuestionQueryService<,,,,,>), value);
                formQuestionQueryServiceType = value;
            }
        }

        /// <summary>
        /// Gets or sets the form detail query service type.
        /// </summary>
        public Type? FormDetailQueryServiceType {
            get => formDetailQueryServiceType;
            set {
                ExceptionUtils.ThrowIfInvalidAssignableType(typeof(FormDetailQueryService<,,,,,,>), value);
                formDetailQueryServiceType = value;
            }
        }

        /// <summary>
        /// Gets or sets the skip form question service type.
        /// </summary>
        public Type? SkipFormQuestionServiceType {
            get => skipFormQuestionServiceType;
            set {
                ExceptionUtils.ThrowIfInvalidAssignableType(typeof(ISkipFormQuestionService<,,>), value);
                skipFormQuestionServiceType = value;
            }
        }

        /// <summary>
        /// Gets or sets the skip form question query service type.
        /// </summary>
        public Type? SkipFormQuestionQueryServiceType {
            get => skipFormQuestionQueryServiceType;
            set {
                ExceptionUtils.ThrowIfInvalidAssignableType(typeof(SkipFormQuestionQueryService<,,,,,,,>), value);
                skipFormQuestionQueryServiceType = value;
            }
        }

        /// <summary>
        /// Gets or sets the form page service type.
        /// </summary>
        public Type? FormPageServiceType {
            get => formPageServiceType;
            set {
                ExceptionUtils.ThrowIfInvalidAssignableType(typeof(IFormPageService<,,,,>), value);
                formPageServiceType = value;
            }
        }

        /// <summary>
        /// Gets or sets the form page query service type.
        /// </summary>
        public Type? FormPageQueryServiceType {
            get => formPageQueryServiceType;
            set {
                ExceptionUtils.ThrowIfInvalidAssignableType(typeof(FormPageQueryService<,,,,>), value);
                formPageQueryServiceType = value;
            }
        }

        /// <summary>
        /// Gets or sets the form page detail query service type.
        /// </summary>
        public Type? FormPageDetailQueryServiceType {
            get => formPageDetailQueryServiceType;
            set {
                ExceptionUtils.ThrowIfInvalidAssignableType(typeof(FormPageDetailQueryService<,,,,,>), value);
                formPageDetailQueryServiceType = value;
            }
        }

        /// <summary>
        /// Gets the editor type maps.
        /// </summary>
        internal IDictionary<string, Type> EditorTypeMaps => editorTypeMaps;

        /// <summary>
        /// Gets or sets the form editor type.
        /// </summary>
        public Type FormEditorType {
            get => editorTypeMaps.ContainsKey(FormEditorConst)
                ? editorTypeMaps[FormEditorConst]
                : typeof(FormEditor);
            set {
                editorTypeMaps[FormEditorConst] = value;
            }
        }

        /// <summary>
        /// Gets or sets the form detail editor type.
        /// </summary>
        public Type FormDetailEditorType {
            get => editorTypeMaps.ContainsKey(FormDetailEditorConst)
                ? editorTypeMaps[FormDetailEditorConst]
                : typeof(FormDetailEditor<FormSectionEditor<FormQuestionEditor<QuestionChoiceEditor>, QuestionChoiceEditor>, FormQuestionEditor<QuestionChoiceEditor>, QuestionChoiceEditor>);
            set {
                editorTypeMaps[FormDetailEditorConst] = value;
            }
        }

        /// <summary>
        /// Gets or sets the form section editor type.
        /// </summary>
        public Type FormSectionEditorType {
            get => editorTypeMaps.ContainsKey(FormSectionEditorConst)
                ? editorTypeMaps[FormSectionEditorConst]
                : typeof(FormSectionEditor<FormQuestionEditor<QuestionChoiceEditor>, QuestionChoiceEditor>);
            set {
                editorTypeMaps[FormSectionEditorConst] = value;
            }
        }

        /// <summary>
        /// Gets or sets the form question editor type.
        /// </summary>
        public Type FormQuestionEditorType {
            get => editorTypeMaps.ContainsKey(FormQuestionEditorConst)
                ? editorTypeMaps[FormQuestionEditorConst]
                : typeof(FormQuestionEditor<QuestionChoiceEditor>);
            set {
                editorTypeMaps[FormQuestionEditorConst] = value;
            }
        }

        /// <summary>
        /// Gets or sets the question choice editor type.
        /// </summary>
        public Type QuestionChoiceEditorType {
            get => editorTypeMaps.ContainsKey(QuestionChoiceEditorConst)
                ? editorTypeMaps[QuestionChoiceEditorConst]
                : typeof(QuestionChoiceEditor);
            set {
                editorTypeMaps[QuestionChoiceEditorConst] = value;
            }
        }

        /// <summary>
        /// Gets or sets the skip form question editor type.
        /// </summary>
        public Type SkipFormQuestionEditorType {
            get => editorTypeMaps.ContainsKey(SkipFormQuestionEditorConst)
                ? editorTypeMaps[SkipFormQuestionEditorConst]
                : typeof(SkipFormQuestionEditor);
            set {
                editorTypeMaps[SkipFormQuestionEditorConst] = value;
            }
        }

        /// <summary>
        /// Gets or sets the form page editor type.
        /// </summary>
        public Type FormPageEditorType {
            get => editorTypeMaps.ContainsKey(FormPageEditorConst)
                ? editorTypeMaps[FormPageEditorConst]
                : typeof(FormPageEditor);
            set {
                editorTypeMaps[FormPageEditorConst] = value;
            }
        }

        /// <summary>
        /// Gets or sets the form page with details editor type.
        /// </summary>
        public Type FormPageWithDetailsEditorType {
            get => editorTypeMaps.ContainsKey(FormPageWithDetailsEditorConst)
                ? editorTypeMaps[FormPageWithDetailsEditorConst]
                : typeof(FormPageWithDetailsEditor<FormPageDetailEditor>);
            set {
                editorTypeMaps[FormPageWithDetailsEditorConst] = value;
            }
        }

        /// <summary>
        /// Gets or sets the form page details editor type.
        /// </summary>
        public Type FormPageDetailEditorType {
            get => editorTypeMaps.ContainsKey(FormPageDetailEditorConst)
                ? editorTypeMaps[FormPageDetailEditorConst]
                : typeof(FormPageDetailEditor);
            set {
                editorTypeMaps[FormPageDetailEditorConst] = value;
            }
        }
    }
}
