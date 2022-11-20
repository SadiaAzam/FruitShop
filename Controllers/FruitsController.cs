using FruitShop.Model;
using FruitShop.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FruitShop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        jsonFileFruitService FruitService;
        public FruitsController(jsonFileFruitService fruitService)
        {
            this.FruitService = fruitService;
        }

        [HttpGet]
        public IEnumerable<Fruit> Get()
        {
            return FruitService.getFruitRecord();
        }
    }
}
