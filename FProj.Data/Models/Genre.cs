using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FProj.Data
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Film> Films { get; set; }

        public Genre()
        {
            Films = new HashSet<Film>();
        }
    }
}
