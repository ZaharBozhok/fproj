using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FProj.Data
{
    public class Image
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsPoster { get; set; }
        [ForeignKey(nameof(Film))]
        public int FilmId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Film Film { get; set; }
    }
}
