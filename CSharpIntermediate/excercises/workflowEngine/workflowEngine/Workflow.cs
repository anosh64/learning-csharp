using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace workflowEngine
{
    public class Workflow
    {
        private readonly IList<IActivity> _workflow = new List<IActivity>();

        public IList<IActivity> WorkflowList => _workflow;

        public void AddActivityToWorkflow(IActivity activity)
        {
            _workflow.Add(activity);
        }
    }
}