using System.IO;

class GoalManager
{
    private List<Goal> _cmGoals;
    private int _cmScore;

    public GoalManager()
    {
        _cmGoals = new List<Goal>();
        _cmScore = 0;
    }

    public int GetScore()
    {
        return _cmScore;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"You have {_cmScore} points!");
    }

    public void ListGoals()
    {
        Console.WriteLine("Goals:");
        Console.WriteLine("");

        for (int i = 0; i < _cmGoals.Count; i++)
        {
            Console.WriteLine($"{i+1}: {_cmGoals[i].GetDisplayString()}");
        }

        Console.WriteLine("Press enter when ready: ");
        Console.ReadLine();
    }

    public void CreateGoal()
    {
        string _cmGoalType;

        Console.WriteLine("Which type?");
        Console.WriteLine("");
        Console.WriteLine("1 Simple");
        Console.WriteLine("2 Eternal");
        Console.WriteLine("3 List");
        Console.WriteLine("");

        _cmGoalType = Console.ReadLine();

        Console.WriteLine("Name: ");
        string cmName = Console.ReadLine();

        Console.WriteLine("Description: ");
        string cmDescription = Console.ReadLine();

        Console.WriteLine("Points: ");
        int cmPoints = int.Parse(Console.ReadLine());

        if (_cmGoalType == "1")
        {
            _cmGoals.Add(new SimpleGoal(cmName, cmDescription, cmPoints));
        }
        else if (_cmGoalType == "2")
        {
            _cmGoals.Add(new EternalGoal(cmName, cmDescription, cmPoints));            
        }
        else if (_cmGoalType == "3")
        {
            Console.WriteLine("How many times would you like to complete this goal: ");
            int cmAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("How many bonus points for completing this goal: ");
            int cmBonus = int.Parse(Console.ReadLine());

            _cmGoals.Add(new ChecklistGoal(cmName, cmDescription, cmPoints, cmAmount, cmBonus));            
        }
    }

    public void RecordGoalCompletion()
    {
        Console.WriteLine("Which goal did you accomplish? ");

        for (int i = 0; i < _cmGoals.Count; i++)
        {
            Console.WriteLine($"{i+1}: {_cmGoals[i].GetDisplayString()}");
        }

        Console.WriteLine("Enter the number of the goal completed: ");
        int cmGoalNumber = int .Parse(Console.ReadLine());

        if (_cmGoals[cmGoalNumber - 1].IsComplete() && !( _cmGoals[cmGoalNumber - 1] is EternalGoal ))
        {
            Console.WriteLine("This goal is already completed!");

            Console.WriteLine("Press enter when ready: ");
            Console.ReadLine();
            
            return;
        }
        
        int cmEarnedPoints = _cmGoals[cmGoalNumber - 1].RecordEvent();

        _cmScore += cmEarnedPoints;

        Console.WriteLine($"Congratualtions you earner {cmEarnedPoints} points!");
        Console.WriteLine($"Your score is now {_cmScore}");
    }

    public void SaveGoals()
    {
        Console.WriteLine("Enter filename: ");
        string cmFilename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(cmFilename))
        {
        outputFile.WriteLine($"{_cmScore}");
        
        foreach (Goal goal in _cmGoals)
            {
            outputFile.WriteLine(goal.GetSavedString());
            }          
        }

        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals()
    {
        Console.WriteLine("Enter filename: ");
        string cmFilename = Console.ReadLine();

        string[] cmLines = System.IO.File.ReadAllLines(cmFilename);

        _cmScore = int.Parse(cmLines[0]);

        _cmGoals.Clear();

        for (int i = 1; i < cmLines.Length; i++)
        {
        string cmLine = cmLines[i];

        string[] cmFirstSplit = cmLine.Split(":");

        string cmType = cmFirstSplit[0];
        string cmRest = cmFirstSplit[1];

        string[] cmParts = cmRest.Split(",");

        if (cmType == "SimpleGoal")
            {
                string cmName = cmParts[0];
                string cmDescription = cmParts[1];
                int cmPoints = int.Parse(cmParts[2]);
                bool cmIsComplete = bool.Parse(cmParts[3]);

                SimpleGoal cmGoal = new SimpleGoal(cmName, cmDescription, cmPoints, cmIsComplete);

                if (cmIsComplete == true)
                {
                    cmGoal.MarkComplete();
                }

                _cmGoals.Add(cmGoal);
            }

        else if (cmType == "EternalGoal")
            {
                string cmName = cmParts[0];
                string cmDescription = cmParts[1];
                int cmPoints = int.Parse(cmParts[2]);

            EternalGoal cmGoal = new EternalGoal(cmName, cmDescription, cmPoints);
            _cmGoals.Add(cmGoal);
            }
        
        else if (cmType == "ChecklistGoal")
            {
                string cmName = cmParts[0];
                string cmDescription = cmParts[1];
                int cmPoints = int.Parse(cmParts[2]);
                int cmTarget = int.Parse(cmParts[3]);
                int cmTimesCompleted = int.Parse(cmParts[4]);
                int cmBonus = int.Parse(cmParts[5]);     

            ChecklistGoal cmGoal = new ChecklistGoal(cmName, cmDescription, cmPoints, cmTarget, cmBonus);

            for (int times = 0; times < cmTimesCompleted; times++)
                {
                    cmGoal.AddCompletion();
                }
            _cmGoals.Add(cmGoal);                                          
            }
        }
    }
}