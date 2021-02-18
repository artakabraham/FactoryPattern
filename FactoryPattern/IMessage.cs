using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    interface IMessage
    {
        public string Text { get; set; }
        public string Target { get; set; }
        public string Source { get; set; }

        void Send();
    }
}
