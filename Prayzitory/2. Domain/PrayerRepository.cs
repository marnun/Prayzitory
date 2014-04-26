using System.Collections.Generic;

namespace Domain
{
    public interface IPrayerRepository
    {
        IEnumerable<Pray> GetTopPrayes();
        void InsertNewPray(Pray pray);
        User GetUser(int userId);
    }

    public class PrayerRepository : IPrayerRepository
    {
        public IEnumerable<Pray> GetTopPrayes()
        {
            throw new System.NotImplementedException();
        }

        public void InsertNewPray(Pray pray)
        {
            throw new System.NotImplementedException();
        }

        public User GetUser(int userId)
        {
            throw new System.NotImplementedException();
        }
    }
}