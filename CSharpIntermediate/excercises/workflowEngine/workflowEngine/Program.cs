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
            var workflow = new Workflow();
            workflow.AddActivityToWorkflow(new UploadVideoToCloud());
            workflow.AddActivityToWorkflow(new EncodeVideo());
            workflow.AddActivityToWorkflow(new NotifyAuthor());
            workflow.AddActivityToWorkflow(new VideoStatusNowProcessing());

            var workflowEngine = new WorkflowEngine(workflow.WorkflowList);
            workflowEngine.Run();
        }
    }
}
