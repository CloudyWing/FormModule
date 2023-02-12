using CloudyWing.FormModule.Domain.FormModel;
using CloudyWing.FormModule.Domain.FormPageModel;
using CloudyWing.FormModule.Domain.SkipFormQuestionModel;
using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.DependencyInjection;
using CloudyWing.FormModule.Infrastructure.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CloudyWing.FormModule.Domain.DependencyInjection {
    /// <summary>
    /// Extension methods for FormModuleBuilder to add domain-related functionality.
    /// </summary>
    public static class FormModuleBuilderDomainExtensions {
        private const string FormQuestionQueryEntityConst = "TFormQuestionQueryEntity";
        private const string FormDetailQueryEntityConst = "TFormDetailQueryEntity";
        private const string SkipFormQuestionQueryEntityConst = "TSkipFormQuestionQueryEntity";
        private const string FormPageQueryEntityConst = "TFormPageQueryEntity";
        private const string FormPageDetailQueryEntityConst = "TFormPageDetailQueryEntity";

        /// <summary>
        /// Adds domain-related services to the FormModuleBuilder.
        /// </summary>
        /// <typeparam name="TDbContext">The type of the DbContext.</typeparam>
        /// <param name="builder">The FormModuleBuilder instance.</param>
        /// <returns>A FormModuleBuilder instance.</returns>
        public static FormModuleBuilder AddDomain<TDbContext>(this FormModuleBuilder builder)
            where TDbContext : DbContext {
            return AddDomain<TDbContext>(builder, options => { });
        }

        /// <summary>
        /// Adds domain-related services to the FormModuleBuilder.
        /// </summary>
        /// <typeparam name="TDbContext">The type of the DbContext.</typeparam>
        /// <param name="builder">The FormModuleBuilder instance.</param>
        /// <param name="domainOptionsAction">An action to configure the domain options.</param>
        /// <param name="contextLifetime">The lifetime of the DbContext service.</param>
        /// <param name="optionsLifetime">The lifetime of the options services.</param>
        /// <returns>A FormModuleBuilder instance.</returns>
        public static FormModuleBuilder AddDomain<TDbContext>(
            this FormModuleBuilder builder,
            Action<FormModuleDomainOptionsBuilder> domainOptionsAction,
            ServiceLifetime contextLifetime = ServiceLifetime.Scoped,
            ServiceLifetime optionsLifetime = ServiceLifetime.Scoped
        ) where TDbContext : DbContext  {
            FormModuleDomainOptionsBuilder options = new();

            domainOptionsAction(options);

            GenericTypeMapper genericTypeMapper = builder.GenericTypeMapper;
            genericTypeMapper.AddTypeMap(nameof(TDbContext), typeof(TDbContext));
            genericTypeMapper.AddTypeMap(typeof(FormModuleDbContext<,,,,,,,,>), typeof(TDbContext));

            foreach (var editorTypePair in options.EditorTypeMaps) {
                genericTypeMapper.AddTypeMap(editorTypePair.Key, editorTypePair.Value);
            }

            if (options.FormQuestionQueryServiceType is not null) {
                genericTypeMapper.AddTypeMap(typeof(FormQuestionQueryService<,,,,,>), options.FormQuestionQueryServiceType);
            } else {
                genericTypeMapper.AddTypeMap(FormQuestionQueryEntityConst, genericTypeMapper.MakeGenericType(typeof(FormQuestionQueryEntity<,,,>)));
            }

            if (options.FormDetailQueryServiceType is not null) {
                genericTypeMapper.AddTypeMap(typeof(FormDetailQueryService<,,,,,,>), options.FormDetailQueryServiceType);
            } else {
                genericTypeMapper.AddTypeMap(FormDetailQueryEntityConst, genericTypeMapper.MakeGenericType(typeof(FormDetailQueryEntity<,,,,>)));
            }

            if (options.SkipFormQuestionQueryServiceType is not null) {
                genericTypeMapper.AddTypeMap(typeof(SkipFormQuestionQueryService<,,,,,,,>), options.SkipFormQuestionQueryServiceType);
            } else {
                genericTypeMapper.AddTypeMap(SkipFormQuestionQueryEntityConst, genericTypeMapper.MakeGenericType(typeof(SkipFormQuestionQueryEntity<,,,,,>)));
            }

            if (options.FormPageQueryServiceType is not null) {
                genericTypeMapper.AddTypeMap(typeof(FormPageQueryService<,,,,>), options.FormPageQueryServiceType);
            } else {
                genericTypeMapper.AddTypeMap(FormPageQueryEntityConst, genericTypeMapper.MakeGenericType(typeof(FormPageQueryEntity<,,>)));
            }

            if (options.FormPageDetailQueryServiceType is not null) {
                genericTypeMapper.AddTypeMap(typeof(FormPageDetailQueryService<,,,,,>), options.FormPageDetailQueryServiceType);
            } else {
                genericTypeMapper.AddTypeMap(FormPageDetailQueryEntityConst, genericTypeMapper.MakeGenericType(typeof(FormPageDetailQueryEntity<,,,>)));
            }

            Type mapperType = options.MapperType ?? genericTypeMapper.MakeGenericType(typeof(FormModuleMapper<,>));
            builder.Services.AddSingleton(typeof(IFormModuleMapper), mapperType);

            Type idConverterType = options.IdConverterType ?? genericTypeMapper.MakeGenericType(typeof(IdConverter<,>));
            builder.Services.AddSingleton(genericTypeMapper.MakeGenericType(typeof(IIdConverter<>)), idConverterType);

            Type userIdConverterType = options.UserIdConverterType ?? genericTypeMapper.MakeGenericType(typeof(IdConverter<,>));
            builder.Services.AddSingleton(genericTypeMapper.MakeGenericType(typeof(IUserIdConverter<>)), userIdConverterType);

            Type formServiceType = options.FormServiceType ?? genericTypeMapper.MakeGenericType(typeof(FormService<,,,,,,,,,,,,,>));
            builder.Services.AddScoped(genericTypeMapper.MakeGenericType(typeof(IFormService<,,,,,,>)), formServiceType);
            builder.Services.AddScoped(formServiceType, formServiceType);
            builder.Services.AddScoped(genericTypeMapper.MakeGenericType(typeof(IQueryableService<>), "TForm"), formServiceType);

            Type defaultFormQuestionQueryServiceType = genericTypeMapper.MakeGenericType(typeof(FormQuestionQueryService<,,,,,>));
            Type formQuestionQueryServiceType = options.FormQuestionQueryServiceType ?? defaultFormQuestionQueryServiceType;
            builder.Services.AddScoped(defaultFormQuestionQueryServiceType, formQuestionQueryServiceType);
            builder.Services.AddScoped(genericTypeMapper.MakeGenericType(typeof(IQueryableService<>), FormQuestionQueryEntityConst), formQuestionQueryServiceType);

            Type defaultFormDetailQueryServiceType = genericTypeMapper.MakeGenericType(typeof(FormDetailQueryService<,,,,,,>));
            Type formDetailQueryServiceType = options.FormDetailQueryServiceType ?? defaultFormDetailQueryServiceType;
            builder.Services.AddScoped(defaultFormDetailQueryServiceType, formDetailQueryServiceType);
            builder.Services.AddScoped(genericTypeMapper.MakeGenericType(typeof(IQueryableService<>), FormDetailQueryEntityConst), formDetailQueryServiceType);

            Type skipFormQuestionServiceType = options.SkipFormQuestionServiceType ?? genericTypeMapper.MakeGenericType(typeof(SkipFormQuestionService<,,,,>));
            builder.Services.AddScoped(genericTypeMapper.MakeGenericType(typeof(ISkipFormQuestionService<,,>)), skipFormQuestionServiceType);
            builder.Services.AddScoped(skipFormQuestionServiceType, skipFormQuestionServiceType);
            builder.Services.AddScoped(genericTypeMapper.MakeGenericType(typeof(IQueryableService<>), "TSkipFormQuestion"), skipFormQuestionServiceType);

            Type defaultSkipFormQuestionQueryServiceType = genericTypeMapper.MakeGenericType(typeof(SkipFormQuestionQueryService<,,,,,,,>));
            Type skipFormQuestionQueryServiceType = options.SkipFormQuestionQueryServiceType ?? defaultSkipFormQuestionQueryServiceType;
            builder.Services.AddScoped(defaultSkipFormQuestionQueryServiceType, skipFormQuestionQueryServiceType);
            builder.Services.AddScoped(genericTypeMapper.MakeGenericType(typeof(IQueryableService<>), SkipFormQuestionQueryEntityConst), skipFormQuestionQueryServiceType);

            Type formPageServiceType = options.FormPageServiceType ?? genericTypeMapper.MakeGenericType(typeof(FormPageService<,,,,,,,>));
            builder.Services.AddScoped(genericTypeMapper.MakeGenericType(typeof(IFormPageService<,,,,>)), formPageServiceType);
            builder.Services.AddScoped(formPageServiceType, formPageServiceType);
            builder.Services.AddScoped(genericTypeMapper.MakeGenericType(typeof(IQueryableService<>), "TFormPage"), formPageServiceType);

            Type defaultFormPageQueryServiceType = genericTypeMapper.MakeGenericType(typeof(FormPageQueryService<,,,,>));
            Type formPageQueryServiceType = options.FormPageQueryServiceType ?? defaultFormPageQueryServiceType;
            builder.Services.AddScoped(defaultFormPageQueryServiceType, formPageQueryServiceType);
            builder.Services.AddScoped(genericTypeMapper.MakeGenericType(typeof(IQueryableService<>), FormPageQueryEntityConst), formPageQueryServiceType);

            Type defaultFormPageDetailQueryServiceType = genericTypeMapper.MakeGenericType(typeof(FormPageDetailQueryService<,,,,,>));
            Type formPageDetailQueryServiceType = options.FormPageDetailQueryServiceType ?? defaultFormPageDetailQueryServiceType;
            builder.Services.AddScoped(defaultFormPageDetailQueryServiceType, formPageDetailQueryServiceType);
            builder.Services.AddScoped(genericTypeMapper.MakeGenericType(typeof(IQueryableService<>), FormPageDetailQueryEntityConst), formPageDetailQueryServiceType);

            return builder;
        }
    }
}
