namespace Sinitsyna.Models
{
    public class Favorite
    {
        public int Id_favorite { get; set; }
        public int Id_user { get; set; }
        public int Id_product { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
