using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FProj.Data
{
    public class Film
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime PremiereDate { get; set; }
        public DateTime DateCreated { get; set; }
        public double Rate { get; set; }
        public double? Duration { get; set; }
        public bool IsDeleted { get; set; }
        public int UserIdCreator { get; set; }
        public string Director { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }

        public Film()
        {
            Comments = new HashSet<Comment>();
            Images = new HashSet<Image>();
            Actors = new HashSet<Actor>();
            Genres = new HashSet<Genre>();
        }
    }
}
