using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CloudyWing.FormModule.Web.Pages {
    public class IndexModel : PageModel {
        [BindProperty]
        public IndexInputModel Input { get; set; } = default!;

        public void OnGet() {
            Input = new IndexInputModel();
        }

        public IActionResult OnPost() {
            HttpContext.Session.SetString("UserId", Input.UserId);
            HttpContext.Session.SetString("Role", Input.UserId);

            return RedirectToPage("/Manages/Forms/Index", new { Area = "FormModule" });
        }
    }

    public class IndexInputModel {
        [DisplayName("使用者帳號"), Required]
        public string? UserId { get; set; }
    }
}
