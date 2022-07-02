using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlanet.Models;

namespace PizzaPlanet.Pages
{
    public class MenuModel : PageModel
    {
        public List<PizzasModel> Mock_Pizza_DB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                Image_Title = "Margerita",
                Pizza_Name = "Margerita",
                Base_Price = 12,
                Tomato_Sauce = true,
                Cheese = true,
                Final_Price = 14
            },
            new PizzasModel()
            {
                Image_Title = "Bolognese",
                Pizza_Name = "Bolognese",
                Base_Price = 12,
                Tomato_Sauce = true,
                Cheese = true,
                Final_Price = 14
            },
            new PizzasModel()
            {
                Image_Title = "Carbonara",
                Pizza_Name = "Carbonara",
                Base_Price = 12,
                Tomato_Sauce = true,
                Cheese = true,
                Final_Price = 14
            },
            new PizzasModel()
            {
                Image_Title = "Hawaiian",
                Pizza_Name = "Hawaiian",
                Base_Price = 12,
                Tomato_Sauce = true,
                Cheese = true,
                Pineapple = true,
                Ham = true,
                Final_Price = 16
            },
            new PizzasModel()
            {
                Image_Title = "MeatFeast",
                Pizza_Name = "MeatFeast",
                Base_Price = 12,
                Tomato_Sauce = true,
                Cheese = true,
                Pepperoni = true,
                Ham = true,
                Beef = true,
                Final_Price = 17
            },
            new PizzasModel()
            {
                Image_Title = "Mushroom",
                Pizza_Name = "Mushroom",
                Base_Price = 12,
                Tomato_Sauce = true,
                Cheese = true,
                Mushroom = true,
                Final_Price = 15
            },
            new PizzasModel()
            {
                Image_Title = "Pepperoni",
                Pizza_Name = "Pepperoni",
                Base_Price = 12,
                Tomato_Sauce = true,
                Cheese = true,
                Pepperoni = true,
                Final_Price = 15
            },
            new PizzasModel()
            {
                Image_Title = "Seafood",
                Pizza_Name = "Seafood",
                Base_Price = 12,
                Tomato_Sauce = true,
                Cheese = true,
                Tuna = true,
                Final_Price = 15
            },
            new PizzasModel()
            {
                Image_Title = "Vegetarian",
                Pizza_Name = "Vegetarian",
                Base_Price = 12,
                Tomato_Sauce = true,
                Cheese = true,
                Mushroom = true,
                Final_Price = 15
            }
        };
        public void OnGet()
        {
        }
    }
}
