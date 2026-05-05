using System;

class Program
{
    static void Main(string[] args)
    {
        Job cmjob1 = new Job();
        cmjob1._cmjobTitle = "Software Engineer";
        cmjob1._cmcompany = "Microsoft";
        cmjob1._cmstartYear = "2019";
        cmjob1._cmendYear = "2022";

        Job cmjob2 = new Job();
        cmjob2._cmjobTitle = "Manager";
        cmjob2._cmcompany = "Apple";
        cmjob2._cmstartYear = "2022";
        cmjob2._cmendYear = "2023";

        Resume cmmyResume = new Resume();
        cmmyResume._cmname = "Allison Rose";

        cmmyResume._cmjobs.Add(job1);
        cmmyResume._cmjobs.Add(job2);

        cmmyResume.Display();
    }
}