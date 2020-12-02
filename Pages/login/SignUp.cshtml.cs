using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Yummyset.Pages.Delivery.Database;

namespace Yummyset.Pages.login
{
    public class SignUpModel : PageModel
    {
        private readonly IUserRepository _db;

        public SignUpModel(IUserRepository db)
        {
            _db = db;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Msg { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (Username!=null && Password != null)
            {
                User newUser = new User();
                newUser.Name = Username;
                newUser.Password = Password;
                _db.AddUser(newUser);
                return RedirectToPage("/Pages/Sales");
            }
                Msg = "Invalid";
                return Page();
        }
    }
}
