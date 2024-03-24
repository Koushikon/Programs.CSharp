using Challenge_1.Models;

namespace Challenge_1.Models;

public class WorkFlowEngine
{
    public void Run(WorkFlow workFlow)
    {
        for (int x = 0; x < workFlow.Activities.Count; x++)
        {
            if (workFlow.Activities[x] == null)
            {
                throw new ArgumentException("Activities cannot be null.");
            }

            workFlow.Activities[x].Execute();
        }
    }
}