using System;
using System.Dynamic;

class Goal
{
    private string _cmName;
    private string _cmdescription;
    private int _cmPoints;

    public virtual int RecordEvent()
    {
     return 0;   
    }

    public Goal(string name, string description, int points)
    {
        _cmName = name;
        _cmdescription = description;
        _cmPoints =points;
    }
    
    public string GetName()
    {
        return _cmName;
    }

    public string GetDecription()
    {
        return _cmdescription;
    }
    public int GetPoints()
    {
        return _cmPoints;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDisplayString()
    {
        return "";
    }

    public virtual string GetSavedString()
    {
        return "";
    }
}