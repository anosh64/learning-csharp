using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflowEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myWorkflow = new Workflow();
            myWorkflow.AddActivityToWorkflow(new UploadVideoToCloud());
            myWorkflow.AddActivityToWorkflow(new EncodeVideo());
            myWorkflow.AddActivityToWorkflow(new NotifyAuthor());
            myWorkflow.AddActivityToWorkflow(new UpdateVideoStatusInDb());

            var workflowEngine = new WorkflowEngine(myWorkflow.ActivityList);
            workflowEngine.Run();
        }
    }
}
