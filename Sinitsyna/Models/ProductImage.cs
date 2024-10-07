namespace Sinitsyna.Models
{
    public class ProductImage
    {
        public int Id_image { get; set; }
        public string Url_image { get; set; }
        public int Id_product { get; set; }
        public Product Product { get; set; }
    }
}
