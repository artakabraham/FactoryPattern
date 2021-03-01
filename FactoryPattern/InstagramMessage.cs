using System;
using System.IO;

namespace FactoryPattern
{
    public class InstagramMessage : MessageBase
    {
        public InstagramMessage(string text, string source, string target) : base(text, source, target)
        {
            if (File.Exists(text))
            {
                var imageBytes = File.ReadAllBytes(text);
                var base64string = Convert.ToBase64String(imageBytes);
                Text = base64string;
            }
        }

        public override void Send()
        {
            // TODO:
            Console.WriteLine($"Instagram photo: from {Source} To {Target}: {Text}");
        }
    }
}
