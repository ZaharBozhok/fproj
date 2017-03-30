using FProj.Repository.Base;
using System.Collections.Generic;
using System.Linq;
using FProj.Data;
using FProj.Api;

namespace FProj.Repository
{
    public class ImageRepository : BaseRepository
    {
        public ImageRepository(FProjContext context) : base(context)
        {
        }

        public void AddPoster(ImageApi poster, int FilmId)
        {
            var posterData = ApiToData.ImageApiToData(poster, FilmId, true);
            _dbContext.Image.Add(posterData);
            _dbContext.SaveChanges();
        }

        public void AddPictures(List<ImageApi> images, int FilmId)
        {
            var pictures = images.Select(x => ApiToData.ImageApiToData(x, FilmId)).ToList();
            _dbContext.Image.AddRange(pictures);

            _dbContext.SaveChanges();
        }
    }
}
