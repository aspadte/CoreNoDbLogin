using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreNoDbLogin.Pages.Admin
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            ViewData["msg1"] = "entered OnGet";

            string userId = HttpContext.User.Identity == null ? "null-1" : HttpContext.User.Identity.Name??"NULL";
            ViewData["msg2"] = userId;

        }
    }
}
