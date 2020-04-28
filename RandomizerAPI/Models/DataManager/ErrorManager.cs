using RandomizerAPI.Models.Context;
using RandomizerAPI.Models.InfrastructureModels;
using RandomizerAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizerAPI.Models.DataManager
{
    public class ErrorManager : IDataRepository<Error>
    {
        readonly RandomizerSessionContext _randomizerContext;

        public ErrorManager(RandomizerSessionContext context)
        {
            _randomizerContext = context;
        }
        #region Error
        public IEnumerable<Error> GetAll()
        {
            return _randomizerContext.Errors.ToList();
        }

        public Error Get(long id)
        {
            return _randomizerContext.Errors
                  .FirstOrDefault(e => e.ID == id);
        }

        public void Add(Error entity)
        {
            _randomizerContext.Errors.Add(entity);
            _randomizerContext.SaveChanges();
        }

        public void Update(Error oldEntity, Error newEntity)
        {
            oldEntity.Message = newEntity.Message;
            oldEntity.StackTrace = newEntity.StackTrace;

            _randomizerContext.SaveChanges();
        }

        public void Delete(Error entity)
        {
            _randomizerContext.Errors.Remove(entity);
            _randomizerContext.SaveChanges();
        }

        public Error Get(string id)
        {
            throw new NotImplementedException();
        }

        public void AddUnique(Error entity)
        {
            throw new NotImplementedException();
        }

        public Error GetOrCreate(long id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
