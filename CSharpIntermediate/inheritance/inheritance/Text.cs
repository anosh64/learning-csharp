using System;

namespace inheritance
{
    public class Text : PresentationObject // inherits stuff from its parent, PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("added a link to " + url);
        }
    }
}