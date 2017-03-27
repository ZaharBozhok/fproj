using FProj.Data;

namespace FProj.Api
{
    public static class ApiToData
    {
        public static Film FilmApiToData(FilmApi filmApi)
        {
            return new Film() {
                Description = filmApi.Description,
                Director = filmApi.Director,
                Duration = filmApi.Duration,
                Id = filmApi.Id,
                PremiereDate = filmApi.PremiereDate,
                Rate = filmApi.Rate,
                Title = filmApi.Title,
                DateCreated = filmApi.DateCreated,
                UserIdCreator = filmApi.User == null ? 0 : filmApi.User.Id                
            };
        }

        public static Image ImageApiToData(ImageApi imageApi, int filmId, bool IsPoster = false)
        {
            return new Image() {
                FilmId = filmId,
                IsPoster = IsPoster,
                Id = imageApi.Id,
                Name = imageApi.Path
            };
        }
    }
}
