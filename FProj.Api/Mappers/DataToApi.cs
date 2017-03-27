using FProj.Data;
using System.Linq;

namespace FProj.Api
{
    public static class DataToApi
    {
        public static FilmApi FilmToApi(Film film, User userCreator = null)
        {
            return new FilmApi() {
                Description = film.Description,
                Director = film.Director,
                Duration = film.Duration ?? 0,
                Id = film.Id,
                PremiereDate = film.PremiereDate,
                DateCreated = film.DateCreated,
                Title = film.Title,
                Rate = film.Rate,
                User = userCreator == null ? null : UserToApi(userCreator),
                Poster = ImageToApi(film.Images.FirstOrDefault(x => !x.IsDeleted && x.IsPoster)),
                Pictures = film.Images?.Where(x => !x.IsPoster && !x.IsDeleted)?.Select(x => ImageToApi(x)).ToList()
            };
        }

        public static UserApi UserToApi(User user)
        {            
            return new UserApi() {
                Email = user.UserAccount.Email,
                FirstName = user.FirtsName,
                Id = user.Id,
                LastName = user.LastName,
                Login = user.Login
            };
        }
        
        public static ImageApi ImageToApi(Image image)
        {
            if (image == null) return null;

            return new ImageApi() {
                Id = image.Id,
                Path = image.Name
            };
        }
    }
}
