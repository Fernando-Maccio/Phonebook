using System;

namespace Library
{
    public class TwitterMessage : Message
    {
        public TwitterMessage(string from, string to, string text) : base (from, to, text)
        {
            this.From = "POO UCU";
        }
    }
}