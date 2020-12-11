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

        public void SendMessage(string text, string source, string target)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text), "The message text cannot be empty!");
            }
            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(nameof(source), "Sender's name cannot be empty!");
            }
            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentNullException(nameof(source), "Receiver's name cannot be empty!");
            }
            if (text.Length > 140)
            {
                throw new ArgumentException("Message text cannot be more than 140 symbols!", nameof(text));
            }
            Message message = new Message(text, source, target);
            SendMessageToTwitter(message);
        }

        private void SendMessageToTwitter(Message message)
        {
            // TODO: Request to twitter API to send a message;
            Console.WriteLine($"Twitter {message.Text}");
        }

        private bool ConnectToTwitter()
        {
            // TODO: Request to Twitter API 
            Console.WriteLine("Twitter authentication passed");
            return true;
        }
    }
}
