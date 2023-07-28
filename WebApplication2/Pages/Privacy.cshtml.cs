using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public string Name { get; set; }

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
            Name = "Kris";
        }

        public void OnGet()
        {
        }
    }
}