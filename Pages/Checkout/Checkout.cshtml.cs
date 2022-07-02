using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlanet.Models;

namespace PizzaPlanet.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string Pizza_Name { get; set; }
        public float Pizza_Price { get; set; }
        public string Image_Title { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(Pizza_Name))
            {
                Pizza_Name = "Custom";
            }

            if (string.IsNullOrEmpty(Image_Title))
            {
                Image_Title = "Create";
            }
        }
    }
}
