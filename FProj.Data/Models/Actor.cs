using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FProj.Data
{
    public class Actor
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public virtual ICollection<Film> Films { get; set; }

        public Actor()
        {
            Films = new HashSet<Film>();
        }
    }
}
