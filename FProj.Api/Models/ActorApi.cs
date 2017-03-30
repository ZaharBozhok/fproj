using System.Collections.Generic;

namespace FProj.Api
{
    public class ActorApi
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<FilmApi> Films { get; set; }
    }
}
