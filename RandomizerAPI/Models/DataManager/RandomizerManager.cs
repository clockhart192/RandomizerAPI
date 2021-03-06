﻿using RandomizerAPI.Models.Context;
using RandomizerAPI.Models.InfrastructureModels;
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

        #region RandomizerSession
        public IEnumerable<RandomizerSession> GetAll()
        {
            return _randomizerContext.RandomizerSessions.ToList();
        }

        public RandomizerSession Get(long id)
        {
            return _randomizerContext.RandomizerSessions
                  .FirstOrDefault(e => e.ID == id);
        }

        public RandomizerSession GetOrCreate(long id)
        {
            throw new System.NotImplementedException();
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

        public void AddUnique(RandomizerSession entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<RandomizerSession> GetSome(IEnumerable<int> ids)
        {
            throw new System.NotImplementedException();
        }

        public void AddMany(List<RandomizerSession> entities)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateMany(List<RandomizerSession> entities)
        {
            throw new System.NotImplementedException();
        }
        #endregion


    }
}