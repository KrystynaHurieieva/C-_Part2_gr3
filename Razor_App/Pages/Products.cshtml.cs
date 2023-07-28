using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_App.Models;

namespace Razor_App.Pages
{
    public class ProductsModel : PageModel
    {
        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = new List<Product>();
            Products.Add(new Product
            {
                Id = 1,
                Name = "Flower",
                Price = 150,
                Description = "beautiful flower",
                Image = "/GettyImages-598083938-1-22dab883ff2a43d8b2751d9f363f2d5d.jpg"
            }); Products.Add(new Product
            {
                Id = 2,
                Name = "Car",
                Price = 100000,
                Description = "car",
                Image = "/download.jpg"
            });
        }

        public string GetName()
        {
            return "Me ^_^";
        }
    }
}
