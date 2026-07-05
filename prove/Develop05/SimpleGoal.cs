using System;

class SimpleGoal : Goal
{
    private bool _cmIsComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _cmIsComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _cmIsComplete = isComplete;
    }

    public void MarkComplete()
    {
        _cmIsComplete = true;
    }


    public override int RecordEvent()
    {
        if (_cmIsComplete == true)
        {
            return 0;   
        }
        else
        { 
            _cmIsComplete = true;
            return GetPoints();
        }
    }

    public override bool IsComplete()
    {
        return _cmIsComplete;
    }

    public override string GetDisplayString()
    {
        string status =  "[ ]";

        if (_cmIsComplete == true)
        {
            status = "[X]";
        }
        return $"{status} {GetName()} : {GetDecription()}";
    }

    public override string GetSavedString()
    {
        return $"SimpleGoal:{GetName()},{GetDecription()},{GetPoints()},{_cmIsComplete}";
    }
}