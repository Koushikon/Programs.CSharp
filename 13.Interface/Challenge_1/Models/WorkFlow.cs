
using Challenge_1.Interfaces;

namespace Challenge_1.Models;

public class WorkFlow
{
    public List<IActivity> Activities { get; }

    public WorkFlow(List<IActivity> activities)
    {
        Activities = activities;
    }
}