using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class InstagramMessenger : MessengerBase
    {
        public InstagramMessenger(string name, string password) : base(name, password)
        {

        }

        public override bool Authorize()
        {
            Console.WriteLine("Authorize on Instagram");
            return true;
        }

        public override IMessage CreateMessage(string text, string target, string source)
        {
            var message = new InstagramMessage(source, target, text);
            return message;
        }
    }
}
