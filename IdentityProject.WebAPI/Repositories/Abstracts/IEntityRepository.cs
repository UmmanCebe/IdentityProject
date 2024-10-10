using IdentityProject.WebAPI.Models;

namespace IdentityProject.WebAPI.Repositories.Abstracts
{
    public interface IEntityRepository<TEntity> where TEntity : Entity, new()
    {
        TEntity GetById(int id);
        List<TEntity> GetAll();
        TEntity Add(TEntity user);
        TEntity Update(TEntity user);
        TEntity Delete(int id);
    }
}