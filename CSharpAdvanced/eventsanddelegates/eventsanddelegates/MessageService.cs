using System;

namespace eventsanddelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("sending message...");
        }
    }
}