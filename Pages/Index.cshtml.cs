using FruitShop.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using FruitShop.Services;

namespace FruitShop.Pages
{
    public class IndexModel : PageModel
    {
        // Need variablr for service
        jsonFileFruitService FruitService;
        // Need variable for Fruit Record
        public IEnumerable<Fruit> Fruits;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, jsonFileFruitService Services)

        {
            _logger = logger;
            FruitService = Services;
        }

        public void OnGet()
        {
            Fruits = FruitService.getFruitRecord();
        }
    }
}
