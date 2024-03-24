using Challenge_1.Interfaces;
using Challenge_1.Models;

namespace Challenge_1;

/***
 * * Design a workflow engine that takes a workflow object and runs it. A workflow is a series of steps
 * * or activities. The workflow engine class should have one method called Run() that takes a
 * * workflow, and then iterates over each activity in the workflow and runs it.
 * * We want our workflows to be extensible, so we can create new activities without impacting the
 * * existing activities.
 * * 
 * * Educational tip: we should represent the concept of an activity using an interface. Each activity
 * * should have a method called Execute(). The workflow engine does not care about the concrete
 * * implementation of activities. All it cares about is that these activities have a common interface:
 * * they provide a method called Execute(). The engine simply calls this method and this way it
 * * executes a series of activities in sequence.
 * * 
 * * Real-world use case: in a real-world application you may use a workflow in a scenario like the following:
 * * 1- Upload a video to a cloud storage.
 * * 2- Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding.
 * * 3- Send an email to the owner of the video notifying them that the video started processing.
 * * 4- Change the status of the video record in the database to “Processing”.
 */

public static class Program
{
    static void Main()
    {
        WorkFlowEngine workFlowEngine = new();
        workFlowEngine.Run(AddActivities());
        Console.WriteLine("Nice on...");
    }

    static WorkFlow AddActivities()
    {
        List<IActivity> activities = new();

        // first activity added
        activities.Add(new UploadVideoActivity());
        // second activity added
        activities.Add(new EncodeVideoActivity());
        // third activity added
        activities.Add(new NotificationActivity());
        // fourth activity added
        activities.Add(new UpdateVideoRecordActivity());

        WorkFlow workFlow = new(activities);

        return workFlow;
    }
}