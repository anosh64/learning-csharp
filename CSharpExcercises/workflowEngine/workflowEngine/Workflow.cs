using System.Collections;
using System.Collections.Generic;

namespace workflowEngine
{
    public class Workflow
    {
        private readonly IList<IActivity> _workflow = new List<IActivity>();
        public IList<IActivity> ActivityList => _workflow;

        public void AddActivityToWorkflow(IActivity activity)
        {
            _workflow.Add(activity);
        }
    }
}