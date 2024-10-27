using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinitsyna.Models
{
    public class Favorite
    {
        [Key]
        public int Id_favorite { get; set; }
        public int Id_user { get; set; }
        [ForeignKey("Id_user")]
        public User User { get; set; }
        public int Id_product { get; set; }
        [ForeignKey("Id_product")]     
        public Product Product { get; set; }
    }
}
