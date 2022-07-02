namespace PizzaPlanet.Models
{
    public class PizzasModel
    {
        public string Image_Title { get; set; }
        public string Pizza_Name { get; set; }
        public float Base_Price { get; set; } = 12;
        public bool Tomato_Sauce { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }
        public float Final_Price { get; set; }
    }
}
