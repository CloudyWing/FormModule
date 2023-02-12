using CloudyWing.FormModule.Domain.DependencyInjection;
using CloudyWing.FormModule.Infrastructure.DependencyInjection;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models;
using CloudyWing.FormModule.Web.Areas.FormModule.Models.FormModel;
using CloudyWing.FormModule.Web.Areas.FormModule.Models.FormPageModel;
using CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.FormPages.Models;
using CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.Forms.Models;
using CloudyWing.FormModule.Web.Models;
using CloudyWing.FormModule.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;
using EditInputModel = CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel;
using IndexRecordModel = CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.Forms.Models.IndexRecordModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSession();

builder.Services.AddDbContext<ApplicationDbContext>(opt => {
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddFormModule()
    .AddDomain<ApplicationDbContext>(opt => {
        opt.FormEditorType = typeof(ApplicationFormEditor);
        opt.FormPageQueryServiceType = typeof(FormPageQueryService);
        opt.FormPageServiceType = typeof(FormPageService);
    })
    .AddApplication(opt => {
        opt.UserFactory = provider => {
            IHttpContextAccessor httpContextAccessor = provider.GetService<IHttpContextAccessor>();
            ISession session = httpContextAccessor.HttpContext.Session;

            return new ApplicationUserContext {
                UserId = session.GetString("UserId"),
                Role = session.GetString("Role")
            };
        };
        opt.PagingOptionsAction = pagingOptions => {
            pagingOptions.PageSize = 20;
        };
        opt.ApplicationOptionsAction = applicationOptions => {
            applicationOptions.ApplicationName = "表單模組Test";
        };
        opt.RegisterServiceType(typeof(IFormIndexAppService<IndexRecordModel>), typeof(FormIndexAppService));
        opt.RegisterServiceType(typeof(IFormEditAppService<EditInputModel>), typeof(FormEditAppService<,,,>));
        opt.RegisterServiceType(typeof(IFormPageIndexAppService<IndexInputModel, CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.FormPages.Models.IndexRecordModel>), typeof(FormPageIndexAppService));

        ServiceMessageProvider provider = new() {
            CreateSuccessMessageAccessor = () => "新增成功。",
            CreateFailureMessageAccessor = () => "新增失敗。",
            UpdateSuccessMessageAccessor = () => "更新成功。",
            UpdateFailureMessageAccessor = () => "更新失敗。",
            DeleteSuccessMessageAccessor = () => "刪除成功。",
            DeleteFailureMessageAccessor = () => "刪除失敗。",
            DuplicateFormCodeCreateMessageAccessor = () => "無法新增資料，已存在相同代碼的問卷且開放時間有重疊。",
            DuplicateFormCodeUpdateMessageAccessor = () => "無法更新資料，已存在相同代碼的問卷且開放時間有重疊。",
            UnableToDeleteDetailDataAccessor = () => "無法刪除明細資料，因為已存在跳題設定或表單填寫紀錄。",
            UnableToDeleteFormAccessor = () => "無法刪除表單設定資料，此表單已有設定題型。",
            DataExistsMessageAccessor = () => "資料已存在。",
            QuestionRequiredMessageAccessor = () => "請填寫此問題。",
            TextRequiredIfCheckedMessageAccessor = () => "如果勾選項目，請填寫文字。"
        };
        opt.ServiceMessageProvider = provider;
    })
    .AddDefaultUI();

builder.Services.AddScoped<FormMenuAppService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

CreateDbIfNotExists(app);

app.Run();

static void CreateDbIfNotExists(IHost host) {
    using var scope = host.Services.CreateScope();
    IServiceProvider services = scope.ServiceProvider;
    try {
        var context = services.GetRequiredService<ApplicationDbContext>();
        DatabaseInitializer.Initialize(context);
    } catch (Exception ex) {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred creating the DB.");
    }
}
