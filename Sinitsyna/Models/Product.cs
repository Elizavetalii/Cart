namespace Sinitsyna.Models
{
    public class Product
    {
        public int Id_product { get; set; }
        public string Product_name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Product_description { get; set; }
        public int? Id_type { get; set; }
        public int? Id_material { get; set; }
        public int? Id_boutique { get; set; }

        public ProductType ProductType { get; set; }
        public ProductMaterial ProductMaterial { get; set; }
        public Boutique Boutique { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
