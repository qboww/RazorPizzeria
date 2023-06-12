using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            int DoughPrice = 200;

            if (Pizza.TomatoSauce) PizzaPrice = DoughPrice += 10;
            if (Pizza.Cheese) PizzaPrice = DoughPrice += 15;
            if (Pizza.Peperoni) PizzaPrice = DoughPrice += 20;
            if (Pizza.Mushroom) PizzaPrice = DoughPrice += 15;
            if (Pizza.Tuna) PizzaPrice = DoughPrice += 25;
            if (Pizza.Pineapple) PizzaPrice = DoughPrice += 30;
            if (Pizza.Ham) PizzaPrice = DoughPrice += 20;
            if (Pizza.Beef) PizzaPrice = DoughPrice += 25;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
        }
    }
}