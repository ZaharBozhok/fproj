using FProj.Repository.Base;
using System.Collections.Generic;
using System.Linq;
using FProj.Data;
using FProj.Api;
using System.Web;
using System.IO;

namespace FProj.Repository
{
    public class ImageRepository : BaseRepository
    {
        public ImageRepository(FProjContext context) : base(context)
        {
        }

        public string AddPoster(ImageApi poster, int FilmId)
        {
            var posterData = ApiToData.ImageApiToData(poster, FilmId, true);
            var prevPoster = _dbContext.Image.FirstOrDefault(x => !x.IsDeleted && x.IsPoster && x.FilmId == FilmId);

            if (prevPoster != null)
                prevPoster.IsDeleted = true;

            _dbContext.Image.Add(posterData);
            _dbContext.SaveChanges();
            return posterData.Name;
        }

        public void AddPictures(List<ImageApi> images, int FilmId)
        {
            var pictures = images.Select(x => ApiToData.ImageApiToData(x, FilmId)).ToList();
            _dbContext.Image.AddRange(pictures);

            _dbContext.SaveChanges();
        }
    }
}
