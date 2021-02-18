using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    interface IMessenger
    {
        string UserName { get; }
        string Password { get; }
        bool Connected { get; }
        public IMessage CreateMessage(string text, string target, string source);
        bool Authorize();
    }
}
