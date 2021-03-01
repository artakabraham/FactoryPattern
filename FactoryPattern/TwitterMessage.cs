using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class TwitterMessage : MessageBase
    {
        public TwitterMessage(string text, string source, string target) : base(text, source, target)
        {
        }

        public override void Send()
        {
            throw new NotImplementedException();
        }
    }
}
