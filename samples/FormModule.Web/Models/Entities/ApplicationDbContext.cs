using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.Web.Models {
    public class ApplicationDbContext
        : FormModuleDbContext<ApplicationForm, FormSection<long>, FormQuestion<long>, QuestionChoice<long>, SkipFormQuestion<long>, ApplicationFormPage, FormPageDetail<long>, long, string> {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<User> Users { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationForm>(b => {
                b.Property(u => u.DemoColumn)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode()
                    .IsFixedLength(false);
            });

            modelBuilder.Entity<ApplicationFormPage>(b => {
                b.Property(u => u.IsDeleted)
                    .IsRequired()
                    .HasDefaultValue(false);
            });

            modelBuilder.Entity<User>(b => {
                string tableName = "Users";
                b.ToTable(tableName);

                b.HasKey(e => e.Id)
                    .HasName($"PK_{tableName}");

                b.Property(u => u.Id)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(false);

                b.Property(u => u.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode()
                    .IsFixedLength(false);
            });
        }
    }
}
