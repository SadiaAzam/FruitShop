using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace FruitShop.Services
{
    public class StyleSheet
    {
        public IWebHostEnvironment WebHostEnvironment { get; set; }
        public StyleSheet(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public string fileAddress
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "css", "site.css");
            }
        }
        public string getCSS()
        {
            using (var filestream = File.OpenText(fileAddress))
            {
                return filestream.ReadToEnd();
            }
        }
    }
}
