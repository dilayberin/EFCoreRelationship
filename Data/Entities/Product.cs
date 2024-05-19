using System.Drawing;

namespace bilgiSis.Data.Entities
{
    public class Product
    {

        public int Id { get; set; }
        public string? Name { get; set; } 
        public double Price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public Size Size { get; set; }

        public List<Color> Colors { get; set; } // Bir ürünün birden fazla rengi olabilir 
    }
}
