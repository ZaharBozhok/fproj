using FProj.Api;

namespace FProj.Repository
{
    public interface ICrud<TModel> where TModel: IId
    {
        TModel Create(TModel model);
        TModel GetById(int Id);
        TModel Update(TModel model);
        void Delete(int Id);
    }
}
