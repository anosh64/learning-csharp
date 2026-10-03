using System;

namespace workflowEngine
{
    public class VideoStatusNowProcessing : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("video status now set to \"processing\" in the database!");
        }
    }
}