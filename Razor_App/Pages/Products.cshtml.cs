using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_App.Models;

namespace Razor_App.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly MyAppContext myAppContext;
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Order> Orders{ get; set; } = new List<Order>();
        public ProductsModel(MyAppContext myAppContext)
        {
            this.myAppContext = myAppContext;
        }
        public async Task OnGetAsync()
        {
            Products = await myAppContext.Products.ToListAsync();
            Customers = await myAppContext.Customers.ToListAsync();
            Orders = await myAppContext.Orders.ToListAsync();
        }

        public string GetName()
        {
            return "Me ^_^";
        }
    }
}
