using System.Collections;
using System.Collections.Generic;

namespace interfacesandpolymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // video encoding logic
            //.a.a.
            //.a.a.
            foreach (var channel in _notificationChannels)
                channel.Send(new Message());
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
                                                        /*                                                            *\
                                                         * we don't want mail or sms sending logic in a video encoder *
                                                         * instead what we do is use abstractions that are defined as *
                                                         * concrete elsewhere. it all works and this is a combination *
                                                         * of polymorphism and interfaces working in harmony, forming *
                                                         * beautiful code that is easily extensible, manifesting code *
                                                         * that is easy and satisfying to maintain so always use this *
                                                        \*                                                            */
