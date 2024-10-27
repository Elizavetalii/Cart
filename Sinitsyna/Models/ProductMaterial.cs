using System.ComponentModel.DataAnnotations;

namespace Sinitsyna.Models
{
    public class ProductMaterial
    {
        [Key]
        public int Id_material { get; set; }
        public string Material_name { get; set; }
    }
}
