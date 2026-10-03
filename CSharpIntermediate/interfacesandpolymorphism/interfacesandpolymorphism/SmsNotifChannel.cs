using System;

namespace interfacesandpolymorphism
{
    public class SmsNotifChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("sending sms...");
        }
    }
}