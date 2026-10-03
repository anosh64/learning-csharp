using System;

namespace workflowEngine
{
    public class UpdateVideoStatusInDb : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("updating video status in database...");
        }
    }
}