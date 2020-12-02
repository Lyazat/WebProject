using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using Yummyset.Database;

namespace Yummyset.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly IFoodRepository _db;

        public PrivacyModel(IFoodRepository db)
        {
            _db = db;
        }
        public string name { get; set; }
        public string nameType { get; set; }
        
        public void OnGet()
        {
            _db.FindFoodByName(name, nameType);
        }
    }
}
