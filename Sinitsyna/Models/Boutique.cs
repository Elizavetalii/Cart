using System.ComponentModel.DataAnnotations;

namespace Sinitsyna.Models
{
    public class Boutique
    {
        [Key]
        public int Id_boutique { get; set; }
        public string Boutique_address { get; set; }
        public TimeSpan Opening_time { get; set; }
        public TimeSpan Closing_time { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
