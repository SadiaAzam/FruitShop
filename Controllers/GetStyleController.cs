using FruitShop.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FruitShop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GetStyleController : ControllerBase
    {
        StyleSheet StyleService;
        public GetStyleController(StyleSheet styleService)
        {
            this.StyleService = styleService;
        }
        [HttpGet]
        public ContentResult Get()
        {
            return Content(StyleService.getCSS(), "text/css");
        }
    }
}
