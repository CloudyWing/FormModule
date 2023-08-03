using System.ComponentModel;
using CloudyWing.FormModule.Infrastructure.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CloudyWing.FormModule.EntityFrameworkCore {
    /// <summary>
    /// Basic class for the Entity Framework database context used for form module.
    /// </summary>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TFormSection">The type of the form section.</typeparam>
    /// <typeparam name="TFormQuestion">The type of the form question.</typeparam>
    /// <typeparam name="TQuestionChoice">The type of the question choice.</typeparam>
    /// <typeparam name="TSkipFormQuestion">The type of the skip form question.</typeparam>
    /// <typeparam name="TFormPage">The type of the form page.</typeparam>
    /// <typeparam name="TFormPageDetail">The type of the form page detail.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TUserKey">The type of the user key.</typeparam>
    /// <seealso cref="DbContext" />
    public abstract class FormModuleDbContext<TForm, TFormSection, TFormQuestion, TQuestionChoice, TSkipFormQuestion, TFormPage, TFormPageDetail, TKey, TUserKey>
        : DbContext
        where TForm : Form<TKey>, new()
        where TFormSection : FormSection<TKey>, new()
        where TFormQuestion : FormQuestion<TKey>, new()
        where TQuestionChoice : QuestionChoice<TKey>, new()
        where TSkipFormQuestion : SkipFormQuestion<TKey>, new()
        where TFormPage : FormPage<TKey>, new()
        where TFormPageDetail : FormPageDetail<TKey>, new()
        where TKey : struct, IEquatable<TKey> // HACK: 為了讓 TKey 可以為 null，所以改用 struct
        where TUserKey : IEquatable<TUserKey> {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="options">The options to be used by a <see cref="DbContext" />.</param>
        protected FormModuleDbContext(DbContextOptions options) : base(options) { }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        protected FormModuleDbContext() { }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}" /> of Forms.
        /// </summary>
        public virtual DbSet<TForm> Forms { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}" /> of FormSections.
        /// </summary>
        public virtual DbSet<TFormSection> FormSections { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}" /> of FormQuestions.
        /// </summary>
        public virtual DbSet<TFormQuestion> FormQuestions { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}" /> of QuestionChoices.
        /// </summary>
        public virtual DbSet<TQuestionChoice> QuestionChoices { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}" /> of SkipFormQuestions.
        /// </summary>
        public virtual DbSet<TSkipFormQuestion> SkipFormQuestions { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}" /> of FormPages.
        /// </summary>
        public virtual DbSet<TFormPage> FormPages { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}" /> of FormPageDetails.
        /// </summary>
        public virtual DbSet<TFormPageDetail> FormPageDetails { get; set; } = default!;

        /// <summary>
        /// Gets the converter that converts the UserId from string and <c>TKey</c>.
        /// </summary>
        protected virtual ValueConverter<string, TUserKey?> UserUserIdConverter => new(
            x => ConvertUserIdFromString(x), x => ConvertUserIdToString(x)
        );

        private static TUserKey? ConvertUserIdFromString(string? id) {
            if (id is null) {
                return default;
            }

            return (TUserKey?)TypeDescriptor.GetConverter(typeof(TUserKey)).ConvertFromInvariantString(id);
        }

        private static string ConvertUserIdToString(TUserKey? id) {
            return id?.ToString() ?? "";
        }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<TForm>(b => {
                string tableName = "Forms";
                b.ToTable(tableName);

                b.HasKey(e => e.Id)
                    .HasName($"PK_{tableName}");

                SetIdColumn(b.Property(u => u.Id), true, true);

                b.Property(u => u.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode()
                    .IsFixedLength(false);

                b.Property(u => u.Code).IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(false);

                b.Property(u => u.StartTime)
                    .IsRequired()
                    .HasConversion(new DateTimeOffsetConverter());

                b.Property(u => u.EndTime)
                    .IsRequired()
                    .HasConversion(new DateTimeOffsetConverter());

                b.Property(u => u.IsInternal)
                    .IsRequired();

                b.Property(u => u.Role)
                    .HasMaxLength(255)
                    .IsRequired();

                b.Property(u => u.Header)
                    .IsRequired()
                    .HasMaxLength(int.MaxValue)
                    .IsUnicode()
                    .IsFixedLength(false);

                b.Property(u => u.Footer)
                    .IsRequired()
                    .HasMaxLength(int.MaxValue)
                    .IsUnicode()
                    .IsFixedLength(false);

                b.Property(u => u.CanUpdate)
                    .IsRequired();

                b.Property(u => u.CompletionMessage)
                    .HasMaxLength(int.MaxValue)
                    .IsRequired();

                SetUserIdColumn(b.Property(u => u.CreatedBy), true);

                b.Property(u => u.CreatedAt)
                    .IsRequired()
                    .HasConversion(new DateTimeOffsetConverter());

                SetUserIdColumn(b.Property(u => u.UpdatedBy), true);

                b.Property(u => u.UpdatedAt)
                    .IsRequired()
                    .HasConversion(new DateTimeOffsetConverter());

                SetUserIdColumn(b.Property(u => u.DetailCreatedBy), true);

                b.Property(u => u.DetailCreatedAt)
                    .HasConversion(new DateTimeOffsetConverter());

                SetUserIdColumn(b.Property(u => u.DetailUpdatedBy), true);

                b.Property(u => u.DetailUpdatedAt)
                    .HasConversion(new DateTimeOffsetConverter());
            });

            modelBuilder.Entity<TFormSection>(b => {
                string tableName = "FormSections";
                b.ToTable(tableName);

                b.HasKey(u => u.Id)
                    .HasName($"PK_{tableName}");

                SetIdColumn(b.Property(u => u.Id), true, true);

                b.Property(u => u.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode()
                    .IsFixedLength(false);

                SetIdColumn(b.Property(u => u.FormId), true, false);

                b.Property(u => u.DisplayOrder)
                    .IsRequired();
            });

            modelBuilder.Entity<TFormQuestion>(b => {
                string tableName = "FormQuestions";
                b.ToTable(tableName);

                b.HasKey(u => u.Id)
                    .HasName($"PK_{tableName}");

                SetIdColumn(b.Property(u => u.Id), true, true);
                SetIdColumn(b.Property(u => u.FormSectionId), true, false);

                b.Property(u => u.QuestionText)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode()
                    .IsFixedLength(false);

                b.Property(u => u.QuestionType)
                    .HasConversion(
                        x => x!.Value,
                        x => QuestionType.Parse(x)
                    )
                    .IsRequired();

                b.Property(u => u.IsRequired)
                    .IsRequired();

                b.Property(u => u.DisplayOrder)
                    .IsRequired();
            });

            modelBuilder.Entity<TQuestionChoice>(b => {
                string tableName = "QuestionChoices";
                b.ToTable(tableName);

                b.HasKey(u => u.Id).HasName($"PK_{tableName}");

                SetIdColumn(b.Property(u => u.Id), true, true);

                SetIdColumn(b.Property(u => u.FormQuestionId), true, false);

                b.Property(u => u.Label)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode()
                    .IsFixedLength(false);
                b.Property(u => u.HasText)
                    .IsRequired();

                b.Property(u => u.DisplayOrder)
                    .IsRequired();
            });

            modelBuilder.Entity<TSkipFormQuestion>(b => {
                string tableName = "SkipFormQuestions";
                b.ToTable(tableName);

                b.HasKey(u => u.Id)
                    .HasName($"PK_{tableName}");

                SetIdColumn(b.Property(u => u.Id), true, true);

                SetIdColumn(b.Property(u => u.FormQuestionId), true, false);

                SetIdColumn(b.Property(u => u.QuestionChoiceId), isRequired: false, false);

                SetIdColumn(b.Property(u => u.SkipQuestionId), true, false);
            });

            modelBuilder.Entity<TFormPage>(b => {
                string tableName = "FormPages";
                b.ToTable(tableName);

                b.HasKey(u => u.Id)
                    .HasName($"PK_{tableName}");

                SetIdColumn(b.Property(u => u.Id), isRequired: true, true);

                SetIdColumn(b.Property(u => u.FormId), true, false);

                b.Property(u => u.SecurityCode)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .IsFixedLength(false);

                b.Property(u => u.CompletionTime)
                    .HasConversion(new DateTimeOffsetConverter());

                b.Property(u => u.IP)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .IsFixedLength(false);

                SetUserIdColumn(b.Property(u => u.CreatedBy), true);

                b.Property(u => u.CreatedAt)
                    .HasConversion(new DateTimeOffsetConverter())
                    .IsRequired();

                SetUserIdColumn(b.Property(u => u.UpdatedBy), true);

                b.Property(u => u.UpdatedAt)
                    .HasConversion(new DateTimeOffsetConverter())
                    .IsRequired();
            });

            modelBuilder.Entity<TFormPageDetail>(b => {
                string tableName = "FormPageDetails";
                b.ToTable(tableName);

                b.HasKey(u => u.Id)
                    .HasName($"PK_{tableName}");

                SetIdColumn(b.Property(u => u.Id), true, true);

                SetIdColumn(b.Property(u => u.FormPageId), true, false);

                SetIdColumn(b.Property(u => u.FormQuestionId), true, false);

                SetIdColumn(b.Property(u => u.QuestionChoiceId), false, false);

                b.Property(u => u.Response)
                    .IsRequired()
                    .HasMaxLength(int.MaxValue)
                    .IsUnicode()
                    .IsFixedLength(false);
            });
        }

        /// <summary>
        /// Sets the identifier column.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="isRequired">if set to <c>true</c> [is required].</param>
        /// <param name="isPk">if set to <c>true</c> [is pk].</param>
        protected virtual void SetIdColumn(PropertyBuilder builder, bool isRequired, bool isPk) {
            if (isRequired) {
                builder.IsRequired();
            }

            if (isPk) {
                builder.ValueGeneratedOnAdd();
            }
        }

        /// <summary>
        /// Sets the user identifier column.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="isRequired">if set to <c>true</c> [is required].</param>
        protected virtual void SetUserIdColumn(PropertyBuilder builder, bool isRequired) {
            if (isRequired) {
                builder.IsRequired();
            }

            builder.HasConversion(UserUserIdConverter);
        }

        private class DateTimeOffsetConverter : ValueConverter<DateTimeOffset, DateTimeOffset> {
            public DateTimeOffsetConverter() : base(
                v => v.ToUniversalTime(),
                v => v.ToOffset(DateTimeOffsetUtils.TaipeiTimeZone.BaseUtcOffset)
            ) {
            }
        }
    }

    /// <summary>
    /// Basic class for the Entity Framework database context used for form module.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TUserKey">The type of the user key.</typeparam>
    public abstract class FormModuleDbContext<TKey, TUserKey>
        : FormModuleDbContext<Form<TKey>, FormSection<TKey>, FormQuestion<TKey>, QuestionChoice<TKey>, SkipFormQuestion<TKey>,
            FormPage<TKey>, FormPageDetail<TKey>, TKey, string>
        where TKey : struct, IEquatable<TKey>
        where TUserKey : IEquatable<TUserKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormModuleDbContext{TKey, TUserKey}"/> class.
        /// </summary>
        /// <param name="options">The options to be used by a <see cref="T:Microsoft.EntityFrameworkCore.DbContext" />.</param>
        public FormModuleDbContext(DbContextOptions options) : base(options) { }
    }
}
