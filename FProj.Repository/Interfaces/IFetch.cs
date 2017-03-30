using System.Collections.Generic;

namespace FProj.Repository
{
    public interface IFetch<TModel>
    {
        List<TModel> GetAll(bool IsDeleted = false);
    }
}