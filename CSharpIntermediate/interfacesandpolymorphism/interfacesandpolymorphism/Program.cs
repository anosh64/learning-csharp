using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesandpolymorphism
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotifChannel());
            encoder.RegisterNotificationChannel(new SmsNotifChannel());
            encoder.Encode(new Video());
        }
    }
}
