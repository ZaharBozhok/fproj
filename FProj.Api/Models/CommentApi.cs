using System;

namespace FProj.Api
{
    public class CommentApi
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public UserApi User { get; set; }
    }
}
