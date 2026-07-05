using System;

class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {}

    public override int RecordEvent()
    {
     return GetPoints();   
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDisplayString()
    {
        return $"[] {GetName()} : {GetDecription()}";
    }

    public override string GetSavedString()
    {
        return $"EternalGoal:{GetName()},{GetDecription()},{GetPoints()}";
    }
}