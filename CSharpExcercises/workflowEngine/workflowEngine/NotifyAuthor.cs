using System;

namespace workflowEngine
{
    public class NotifyAuthor : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("sending an email to author that the video is processing...");
        }
    }
}