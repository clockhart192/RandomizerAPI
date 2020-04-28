using System.Collections.Generic;

namespace RandomizerAPI.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        TEntity GetOrCreate(long id);
        TEntity Get(string id);
        void Add(TEntity entity);
        void AddUnique(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }
}
