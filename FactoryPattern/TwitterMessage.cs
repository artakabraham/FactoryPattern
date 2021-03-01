using System;

namespace FactoryPattern
{
    public class TwitterMessage : MessageBase
    {
        public TwitterMessage(string text, string source, string target) : base(text, source, target)
        {
            if (text.Length <= 140)
            {
                Text = text;
            }
            else
            {
                Text = text.Substring(0, 140);
            }
        }

        public override void Send()
        {
            // TODO:
            Console.WriteLine($"Twitter: Twitt from {Source} To {Target}: {Text}");
        }
    }
}
