using System.ComponentModel.DataAnnotations;

namespace Sinitsyna.Models
{
    public class ProductType
    {
        [Key]
        public int Id_type { get; set; }
        public string Product_type_name { get; set; }
    }
}
