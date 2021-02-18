using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Messenger messenger = new Messenger("Usernmame", "Password");
            messenger.SendMessage("Lorem Impus", "From", "To");
        }
    }
}
