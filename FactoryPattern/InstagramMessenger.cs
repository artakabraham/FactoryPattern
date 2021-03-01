using System;

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

        public override IMessage CreateMessage(string text, string source, string target)
        {
            var message = new InstagramMessage(text, source, target);
            return message;
        }
    }
}
