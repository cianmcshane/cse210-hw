using System;

class ChecklistGoal : Goal
{
    private int _cmTimesCompleted;
    private int _cmGoalAmount;
    private int _cmBonus;


    public ChecklistGoal(string name, string description, int points, int amount, int bonus) : base(name, description, points)
    {
        _cmTimesCompleted = 0;
        _cmGoalAmount = amount;
        _cmBonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int amount, int bonus) : base(name, description, points)
    {
        _cmTimesCompleted = target;
        _cmGoalAmount = amount;
        _cmBonus = bonus;
    }

    public void AddCompletion()
    {
        _cmTimesCompleted++;
    }


    public override int RecordEvent()
    {
        if (_cmTimesCompleted < _cmGoalAmount)
        {
            _cmTimesCompleted++;

            if (_cmTimesCompleted == _cmGoalAmount)
            {
                return GetPoints() + _cmBonus;
            }
            else
            {
                return GetPoints();
            }

        }
        return 0;
    }

    public override bool IsComplete()
    {
        if (_cmTimesCompleted == _cmGoalAmount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDisplayString()
    {
        string status =  "[ ]";

        if (_cmTimesCompleted == _cmGoalAmount)
        {
            status = "[X]";
        }
        return $"{status} {GetName()} : {GetDecription()} : Completed {_cmTimesCompleted} / {_cmGoalAmount}";
    }

    public override string GetSavedString()
    {
        return $"ChecklistGoal:{GetName()},{GetDecription()},{GetPoints()},{_cmGoalAmount},{_cmTimesCompleted},{_cmBonus}";
    }
}