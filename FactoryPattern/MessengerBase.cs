using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class MessengerBase : IMessenger
    {
        public string UserName { get; protected set; }

        public string Password { get; }

        public bool Connected { get; }

        public MessengerBase(string name, string password)
        {
            if (!(string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(password)))
            {
                UserName = name;
                Password = password;
                Connected = Authorize();
            }
            else
            {
                Connected = false;
            }
        }

        public abstract bool Authorize();

        public abstract IMessage CreateMessage(string text, string target, string source);
    }
}
