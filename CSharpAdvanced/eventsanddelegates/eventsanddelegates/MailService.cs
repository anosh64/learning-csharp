using System;

namespace eventsanddelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("sending email...");
        }
    }
}