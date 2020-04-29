using RandomizerAPI.Models.BaseModels;
using RandomizerAPI.Models.Context;
using RandomizerAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using Z.EntityFramework.Extensions;

namespace RandomizerAPI.Models.DataManager
{
    public class LocationManager : IDataRepository<Location>
    {
        readonly RandomizerSessionContext _randomizerContext;

        public LocationManager(RandomizerSessionContext context)
        {
            _randomizerContext = context;
        }
        public void Add(Location entity)
        {
            _randomizerContext.Locations.Add(entity);
            _randomizerContext.SaveChanges();
        }

        public void AddMany(List<Location> entities)
        {
            _randomizerContext.Locations.AddRange(entities);
            _randomizerContext.SaveChanges();
        }

        public void AddUnique(Location entity)
        {
            var ret = Get(entity.Name);

            if (ret == null)
                Add(entity);
            else
                throw new Exception("Entity Exists");
        }

        public void Delete(Location entity)
        {
            _randomizerContext.Locations.Remove(entity);
            _randomizerContext.SaveChanges();
        }

        public Location Get(long id)
        {
            throw new NotImplementedException();
        }

        public Location Get(string id)
        {
            return _randomizerContext.Locations
                  .FirstOrDefault(e => e.Name == id);
        }

        public IEnumerable<Location> GetAll()
        {
            return _randomizerContext.Locations.ToList();
        }

        public Location GetOrCreate(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Location> GetSome(IEnumerable<int> ids)
        {
            throw new NotImplementedException();
        }

        public void Update(Location dbEntity, Location entity)
        {
            _randomizerContext.Locations.Update(entity);
            _randomizerContext.SaveChanges();
        }

        public void UpdateMany( List<Location> entities)
        {
            _randomizerContext.Locations.BulkUpdate(entities);
            _randomizerContext.SaveChanges();
        }
    }
}
