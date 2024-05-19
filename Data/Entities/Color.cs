using System.Text.Json.Serialization;

namespace bilgiSis.Data.Entities
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public List<Product> Products { get; set; } //Sadece ilişkili olduğunu ifade etmek için 
    }
}
