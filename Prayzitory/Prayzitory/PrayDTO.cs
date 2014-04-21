using System;

namespace Prayzitory
{
    public class PrayDTO
    {
        private string _pray;
        private string _user;
        private DateTime _timestemp;

        public PrayDTO(string pray, string user, DateTime timestemp)
        {
            _pray = pray;
            _user = user;
            _timestemp = timestemp;
        }

        public string Pray
        {
            get { return _pray; }
        }

        public string User
        {
            get { return _user; }
        }

        public DateTime Timestemp
        {
            get { return _timestemp; }
        }
    }
}