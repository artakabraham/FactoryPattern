﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class TwitterMessenger : MessengerBase
    {
        public TwitterMessenger(string name, string password) : base(name, password)
        {

        }


        public override bool Authorize()
        {
            Console.WriteLine("Authorize on Twitter");
            return true;
        }

        public override IMessage CreateMessage(string text, string target, string source)
        {
            var message = new TwitterMessage(source, target, text);
            return message;
        }
    }
}
