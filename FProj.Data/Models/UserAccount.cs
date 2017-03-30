using System.ComponentModel.DataAnnotations;

namespace FProj.Data
{
    public class UserAccount
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Salt { get; set; }
    }
}
