using RandomizerAPI.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace RandomizerAPI.Models.DataManager
{
    public class RandomizerManager : IDataRepository<RandomizerSession>
    {
        readonly RandomizerSessionContext _randomizerContext;

        public RandomizerManager(RandomizerSessionContext context)
        {
            _randomizerContext = context;
        }

        public IEnumerable<RandomizerSession> GetAll()
        {
            return _randomizerContext.RandomizerSessions.ToList();
        }

        public RandomizerSession Get(long id)
        {
            return _randomizerContext.RandomizerSessions
                  .FirstOrDefault(e => e.ID == id);
        }

        public RandomizerSession Get(string id)
        {
            return _randomizerContext.RandomizerSessions
                  .FirstOrDefault(e => e.SessionID == id);
        }

        public void Add(RandomizerSession entity)
        {
            _randomizerContext.RandomizerSessions.Add(entity);
            _randomizerContext.SaveChanges();
        }

        public void Update(RandomizerSession session, RandomizerSession entity)
        {
            session.Password = entity.Password;
            session.SessionID = entity.SessionID;
            session.SpoilerLog = entity.SpoilerLog;
            session.Game = entity.Game;

            _randomizerContext.SaveChanges();
        }

        public void Delete(RandomizerSession session)
        {
            _randomizerContext.RandomizerSessions.Remove(session);
            _randomizerContext.SaveChanges();
        }
    }
}