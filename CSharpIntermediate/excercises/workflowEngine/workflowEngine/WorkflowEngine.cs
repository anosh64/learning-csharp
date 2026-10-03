using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace workflowEngine
{
    public class WorkflowEngine
    {
        private readonly IList<IActivity> _workflow;

        public WorkflowEngine(IList<IActivity> workflow)
        {
            _workflow = workflow;
        }


        public void Run()
        {
            foreach (var activity in _workflow)
            {
                activity.Execute();
            }
        }
    }
}