using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Message
    {
        public string Text { get; set; }
        public string Target { get; set; }
        public string Source { get; set; }

        public Message(string text, string source, string target)
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

            if (text.Length < 140)
            {
                Text = text;
            }
            else
            {
                Text = text.Substring(0, 140);
            }
            Source = source;
            Target = target;
        }
    }
}
