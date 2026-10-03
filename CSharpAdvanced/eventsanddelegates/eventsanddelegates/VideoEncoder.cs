using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace eventsanddelegates
{
    class VideoEncoder
    {
        // 1 - define a delegate
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        // 2 - define an event based upon that delegate
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(); // now when the video is done encoding we just notify all the subscribers here
        }

        // 3 - raise the event
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null) // check if there are subscribers to the event
            {
                VideoEncoded(this, EventArgs.Empty); // the source is this class.
            }                                             // we do not want to send any additional data
        }                                                // (for this example)
    }
}

/*
  / all this is done so that if we ever wanted to make another service that runs when the video encodes, say, 
 /  send an sms text message when it is done, send a notification when it is done, etc., we can do this without
  / actually having to change anything in this file or recompiling, because if we make a change to a service
 /  that is connected to the event VideoEncoded, it will just subscribe to that event, and we can make all the
  / changes we want and nothing will have to be changed in this file.
 /  that is why this is cool and you should use it
*/