using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._cmjobTitle = "Software Engineer";
        job1._cmcompany = "Microsoft";
        job1._cmstartYear = "2019";
        job1._cmendYear = "2022";

        Job job2 = new Job();
        job2._cmjobTitle = "Manager";
        job2._cmcompany = "Apple";
        job2._cmstartYear = "2022";
        job2._cmendYear = "2023";

        Resume myResume = new Resume();
        myResume._cmname = "Allison Rose";

        myResume._cmjobs.Add(job1);
        myResume._cmjobs.Add(job2);

        myResume.Display();
    }
}