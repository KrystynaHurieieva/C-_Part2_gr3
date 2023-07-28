using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_App.Pages
{
    public class AboutModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; } = "Red Bull";

        public List<int> MyArray { get; set; } = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        public void OnGet()
        {
        }
    }
}
