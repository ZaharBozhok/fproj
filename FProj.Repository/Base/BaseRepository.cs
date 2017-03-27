using FProj.Data;

namespace FProj.Repository.Base
{
    public class BaseRepository
    {
        protected readonly FProjContext _dbContext;
        public BaseRepository(FProjContext context)
        {
            _dbContext = context;
        }
    }
}
