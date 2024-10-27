using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinitsyna.Models
{
    public class ProductImage
    {
        [Key]
        public int Id_image { get; set; }
        public string Url_image { get; set; }
        public int Id_product { get; set; }
        [ForeignKey("Id_product")]
        public Product Product { get; set; }
    }
}
