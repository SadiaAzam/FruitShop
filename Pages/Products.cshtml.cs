using FruitShop.Model;
using FruitShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace FruitShop.Pages
{
    public class ProductsModel : PageModel
    {
        jsonFileFruitService FruitService;
        public IEnumerable<Fruit> Fruits;

        public ProductsModel(jsonFileFruitService fruitService)
        {
            this.FruitService = fruitService;
        }
        public void OnGet()
        {
            Fruits = FruitService.getFruitRecord();
        }
    }
}
