using FruitShop.Model;
using FruitShop.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace FruitShop.Controllers
{
    [Route("[controller]")]
    public class FormHandlerController : Controller
    {
        jsonFileFruitService FruitService;
        public FormHandlerController(jsonFileFruitService fruitService)
        {
            this.FruitService = fruitService;
        }
        [HttpGet]
        public string Get(int id, string name, string image)
        {
            Fruit obj = new Fruit();
            obj.Fruit_id = id;
            obj.name = name;
            obj.image = image;


            IEnumerable<Fruit> fruitdata = FruitService.getFruitRecord();
            List<Fruit> listoffruits = fruitdata.ToList();
            return JsonSerializer.Serialize<List<Fruit>>(listoffruits);
        }
    }
}
