using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>() {
            new PizzasModel() { ImageTitle = "Pizza Manhattan", PizzaName = "Pizza Manhattan", BasePrice = 232, TomatoSauce = true, Cheese = true, FinalPrice = 232, Description = "Mozarella, Peperoni, Mushrooms", Weight = 546 },
            new PizzasModel() { ImageTitle = "Pizza with veal", PizzaName = "Pizza with veal", BasePrice = 291, TomatoSauce=true, Cheese = true, Beef = true, FinalPrice = 291, Description = "BBQ sauce, Mozarella, Tomatoes, Veal", Weight = 555 },
            new PizzasModel() { ImageTitle = "Pizza Diablo", PizzaName = "Pizza Diablo", BasePrice = 310, TomatoSauce = true, Cheese = true, Ham = true, Pineapple = true, FinalPrice = 310, Description = "Mozarella, Peperoni, Jalapeno, Chorizo", Weight = 570 },
            new PizzasModel() { ImageTitle = "Pizza Chorizo", PizzaName = "Pizza Chorizo", BasePrice = 296, TomatoSauce = true, Cheese = true, Ham = true, Mushroom = true, FinalPrice = 296, Description = "Sweet pepper, Mozarella, Chorizo", Weight = 560 },
            new PizzasModel() { ImageTitle = "Pizza Pepperoni", PizzaName = "Pizza Pepperoni", BasePrice = 232, TomatoSauce = true, Cheese = true, Ham = true, Beef = true, FinalPrice = 232, Description = "BBQ sauce, Mozarella, Tomatoes, Peperoni", Weight = 589 },
            new PizzasModel() { ImageTitle = "Pizza Beef & Chips", PizzaName = "Pizza Beef & Chips", BasePrice = 301, TomatoSauce = true, Cheese = true, Mushroom = true, FinalPrice = 301, Description = "BBQ sauce, Mozarella, French fries, Beef", Weight = 531 },
            new PizzasModel() { ImageTitle = "Pizza with Turkey", PizzaName = "Pizza with Turkey", BasePrice = 301, TomatoSauce = true, Cheese = true, Peperoni = true, FinalPrice = 301, Description = "Mozarella, Turkey, Bacon", Weight = 522 },
            new PizzasModel() { ImageTitle = "Pizza Texas", PizzaName = "Pizza Texas", BasePrice = 232, TomatoSauce = true, Cheese = true, Tuna = true, FinalPrice = 232, Description = "Mozarella, Onion, Bavarian sausages, Corn", Weight = 553 },
            new PizzasModel() { ImageTitle = "Pizza Ham & rooms", PizzaName = "Pizza Ham & rooms", BasePrice = 235, TomatoSauce = true, Cheese = true, Mushroom = true, Pineapple = true, FinalPrice = 235, Description = "BBQ sauce, Bavarian sausages, Corn", Weight = 547 },
        };

        public void OnGet()
        {
        }
    }
}
