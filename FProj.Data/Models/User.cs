using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FProj.Data
{
    public class User
    {
        [Key]
        [ForeignKey(nameof(UserAccount))]
        public int Id { get; set; }
        [Required]
        public string FirtsName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Login { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Film> Films { get; set; }
        public virtual UserAccount UserAccount { get; set; }

        public User()
        {
            Films = new HashSet<Film>();
        }
    }
}
