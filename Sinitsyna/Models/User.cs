namespace Sinitsyna.Models
{
    public class User
    {
        public int Id_user { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Middle_name { get; set; }
        public int? Id_role { get; set; }

        public Role Role { get; set; }
    }
}
