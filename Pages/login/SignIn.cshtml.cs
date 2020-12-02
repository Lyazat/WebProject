using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Yummyset.Pages.Delivery.Database;

namespace Yummyset.Pages.login
{
    public class IndexModel : PageModel
    {
        private readonly IUserRepository _db;

        public IndexModel(IUserRepository db)
        {
            _db = db;
        }
        public IEnumerable<User> Users { get; set; }

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
            User findUser = _db.FindByName(Username);
            if (findUser==null) 
            {
                Msg = "Invalid";
                return Page();
            }
            if (Username.Equals(findUser.Name) && Password.Equals(findUser.Name))
            {
                HttpContext.Session.SetString("username", Username);
                Msg = "neInvalid";
                return RedirectToPage("Welcome");
            }
            else
            {
                Msg = "Invalid";
                return Page();
            }
        }
    }
}
