using RandomizerAPI.Models.BaseModels;
using RandomizerAPI.Models.Context;
using RandomizerAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizerAPI.Models.DataManager
{
    public class ZoneManager : IDataRepository<Zone>
    {

        private readonly List<Zone> _initialSeedData = new List<Zone>()
        {
            new Zone(){ Name = "Unspecified", OrderID = 0, Locations = null }
        }; 
        readonly RandomizerSessionContext _randomizerContext;

        public ZoneManager(RandomizerSessionContext context)
        {
            _randomizerContext = context;
        }

        public void Add(Zone entity)
        {
            _randomizerContext.Zones.Add(entity);
            _randomizerContext.SaveChanges();
        }

        public void AddMany(List<Zone> entities)
        {
            throw new NotImplementedException();
        }

        public void AddUnique(Zone entity)
        {
            var ret = Get(entity.Name);

            if (ret == null)
                Add(entity);
            else
                throw new Exception("Entity Exists");
        }

        public void Delete(Zone entity)
        {
            _randomizerContext.Zones.Remove(entity);
            _randomizerContext.SaveChanges();
        }

        public Zone Get(long id)
        {
            return _randomizerContext.Zones
                  .FirstOrDefault(e => e.ID == id);
        }

        public Zone Get(string id)
        {
            return _randomizerContext.Zones
                  .FirstOrDefault(e => e.Name == id);
        }

        public IEnumerable<Zone> GetAll()
        {
            var ret = _randomizerContext.Zones.ToList();
            if (ret != null)
                return ret;
            else
            {
                foreach(var val in _initialSeedData)
                {
                    Add(val);
                }
                return _randomizerContext.Zones.ToList();
            }
        }

        public Zone GetOrCreate(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Zone> GetSome(IEnumerable<int> ids)
        {
            throw new NotImplementedException();
        }

        public void Update(Zone dbEntity, Zone entity)
        {
            dbEntity.Name = entity.Name;
            dbEntity.OrderID = entity.OrderID;
            _randomizerContext.SaveChanges();
        }

        public void UpdateMany(List<Zone> entities)
        {
            throw new NotImplementedException();
        }
    }
}
