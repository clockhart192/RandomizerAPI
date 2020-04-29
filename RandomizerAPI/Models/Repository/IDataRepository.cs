using System.Collections.Generic;

namespace RandomizerAPI.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetSome(IEnumerable<int> ids);
        TEntity Get(long id);
        TEntity GetOrCreate(long id);
        TEntity Get(string id);
        void Add(TEntity entity);
        void AddMany(List<TEntity> entities);
        void AddUnique(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void UpdateMany(List<TEntity> entities);
        void Delete(TEntity entity);
    }
}
