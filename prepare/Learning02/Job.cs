using System;

public class Job
{
    public string _cmjobTitle = "";
    public string _cmcompany = "";
    public string _cmstartYear = "";
    public string _cmendYear = "";

    public void Display()
    {
        Console.WriteLine($"{_cmjobTitle} ({_cmcompany}) {_cmstartYear}-{_cmendYear}");
    }
}