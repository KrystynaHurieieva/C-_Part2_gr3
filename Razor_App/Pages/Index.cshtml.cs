using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;

namespace Razor_App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public List<Color> MyColors{ get; set; } = new List<Color>();
        public void OnGet()
        {
            MyColors.Add(Color.SteelBlue);
            MyColors.Add(Color.Olive);
            MyColors.Add(Color.Orange);
            MyColors.Add(Color.MediumSeaGreen);
            MyColors.Add(Color.Beige);
        }
    }
}