using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Messenger
    {
        public string UserName { get; }
        public string Password { get; }
        public bool Connected { get; }

        public Messenger(string name, string password)
        {
            if (!(string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(password)))
            {
                UserName = name;
                Password = password;
                Connected = ConnectToTwitter();
            }
            else
            {
                Connected = false;
            }
        }

        private bool ConnectToTwitter()
        {
            // TODO: Request to Twitter API 
            Console.WriteLine("Twitter authentication passed");
            return true;
        }
    }
}
