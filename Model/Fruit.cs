using System.Text.Json.Serialization;
using System.Text.Json;

namespace FruitShop.Model
{
    public class Fruit
    {
        [JsonPropertyName("id")]
        public int Fruit_id { get; set; }
        public string name { get; set; }
        public string image { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Fruit>(this);
        }
    }
}
