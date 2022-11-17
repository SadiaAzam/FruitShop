using FruitShop.Model;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace FruitShop.Services
{
    public class jsonFileFruitService
    {
        // Json -> Program
        // Need a vraiable for home/root address & then generate file address & then do file handling

        public IWebHostEnvironment WebHostEnvironment { get; set; }

        // Set Actual Hosting Environment  E.g: [Here We don't know the environment](?) / Our file name
        public jsonFileFruitService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        // Generate File Address
        public string fileAddress
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Fruits.json");
            }
        }

        // File Handling
        public IEnumerable<Fruit> getFruitRecord()
        {
            using (var filestream = File.OpenText(fileAddress))
            {
                return JsonSerializer.Deserialize<Fruit[]>(filestream.ReadToEnd());
            }
        }
    }
}
