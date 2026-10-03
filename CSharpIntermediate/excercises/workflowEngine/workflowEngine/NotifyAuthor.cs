using System;

namespace workflowEngine
{
    public class NotifyAuthor : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("notified!");
        }
    }
}