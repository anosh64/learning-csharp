using System;

namespace interfacesandpolymorphism
{
    public class MailNotifChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("sending mail...");
        }
    }
}