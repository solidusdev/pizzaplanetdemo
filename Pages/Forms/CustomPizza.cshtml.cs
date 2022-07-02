using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlanet.Models;

namespace PizzaPlanet.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float Pizza_Price { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Pizza_Price = Pizza.Base_Price;

            // If toppings are added, increment the base price
            if (Pizza.Tomato_Sauce) Pizza_Price += 1;
            if (Pizza.Cheese) Pizza_Price += 1;
            if (Pizza.Pepperoni) Pizza_Price += 1;
            if (Pizza.Mushroom) Pizza_Price += 1;
            if (Pizza.Tuna) Pizza_Price += 1;
            if (Pizza.Pineapple) Pizza_Price += 1;
            if (Pizza.Ham) Pizza_Price += 1;
            if (Pizza.Beef) Pizza_Price += 1;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.Pizza_Name, Pizza_Price });
        }
    }
}
