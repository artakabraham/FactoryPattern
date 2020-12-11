using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    ///  Message package, containign all components for sending message.
    /// </summary>
    class Message
    {
        /// <summary>
        /// Message Text
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// receiver
        /// </summary>
        public string Target { get; set; }
        /// <summary>
        /// Sender
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Creating a new instance of a message.
        /// </summary>
        /// <param name="text">Message text</param>
        /// <param name="source">Sender Name</param>
        /// <param name="target">Reciever Name</param>
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
