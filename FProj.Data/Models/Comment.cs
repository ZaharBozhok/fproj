using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FProj.Data
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        //[ForeignKey(nameof(Film))]
        public int FilmId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User User { get; set; }
        //public virtual Film Film { get; set; }
    }
}
