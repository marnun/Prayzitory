using System;
using System.Collections.Generic;
using Domain;

namespace Interactors
{

    public interface IPraysService
    {
        IEnumerable<Pray> GetTopPrays();
        void CreateNewPray(string pray, DateTime timestamp, User user);
        User GetUser(int userId);
    }

    public class PraysService : IPraysService
    {
        protected IPrayerRepository _prayerRepository;

        public PraysService(IPrayerRepository prayerRepository)
        {
            _prayerRepository = prayerRepository;
        }

        public IEnumerable<Pray> GetTopPrays()
        {
            var result =  _prayerRepository.GetTopPrayes();

            return result;
        }

        public void CreateNewPray(string text, DateTime timestamp, User user)
        {
            var pray = GetPrayEntity(text, timestamp, user);
            _prayerRepository.InsertNewPray(pray);
        }

        public User GetUser(int userId)
        {
            var user = _prayerRepository.GetUser(userId);
            return user;
        }

        private Pray GetPrayEntity(string pray, DateTime timestamp, User user)
        {            
            return new Pray(pray, user , timestamp);
        }
    }
}