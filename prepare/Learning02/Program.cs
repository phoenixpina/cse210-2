using System;

class Program
{
    static void Main(string[] args)
    {
        // first "Job" is data type named after the class. "job1" is newly declared variable, "new" means new instance
        Job job1 = new Job();
        job1._company = "Del Taco";
        job1._jobTitle = "Manager";
        job1._startYear = 1706;
        job1._endYear = 2020;
        //job1.Display();

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Manager";
        job2._startYear = 2020;
        job2._endYear = 2024;
        //job2.Display();

        Resume r = new Resume();
        r._name = "loser lameboy";
        r._jobs.Add(job1);
        r._jobs.Add(job2);
        r.Display();
    }
}