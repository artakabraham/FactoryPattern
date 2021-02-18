using System;

namespace FactoryPattern
{
    public abstract class MessageBase : IMessage
    {
        public string Text { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }

        public MessageBase(string text, string source, string target)
        {
            #region Checking input parameters
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
            #endregion
            Text = text;
            Source = source;
            Target = target;
        }

        public abstract void Send();
    }
}
