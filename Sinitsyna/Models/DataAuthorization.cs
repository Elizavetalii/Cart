namespace Sinitsyna.Models
{
    public class DataAuthorization
    {
        public int Id_auth { get; set; }
        public string User_password { get; set; }
        public string User_login { get; set; }
        public int Id_user { get; set; }
        public User User { get; set; }
    }
}
