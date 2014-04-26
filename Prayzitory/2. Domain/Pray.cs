using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Pray
    {
        private string _text;
        private User _user;
        private DateTime  _created;

        public Pray(string text, User user, DateTime created)
        {
            _text = text;
            _user = user;
            _created = created;
        }

        public string Text
        {
            get { return _text; }
        }

        public string UserName
        {
            get { return _user.Name; }
        }

        public DateTime Created
        {
            get { return _created; }
        }
    }
}
