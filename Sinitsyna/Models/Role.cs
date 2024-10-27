using System.ComponentModel.DataAnnotations;

namespace Sinitsyna.Models
{
    public class Role
    {
        [Key]
        public int Id_role { get; set; }

        [Required(ErrorMessage = "Название роли обязательно для заполнения.")]
        [RegularExpression(@"^[a-zA-Zа-яА-ЯёЁ\s]+$", ErrorMessage = "Название роли должно содержать только буквы.")]
        public string Role_name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
