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

        }
    }
}
