using System.Text.Json.Serialization;

namespace bilgiSis.Data.Entities
{
    public class Size
    {

        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore] //kullanıcının bunu görmesine gerek. yok.burayı göstermez.aralarındaki ilişkiyi ifade etmek için kullanılır
        public Product Product { get; set; }  
        public int ProductId { get; set; }
    }
}
