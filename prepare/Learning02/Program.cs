using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        Job job2 = new Job();


        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job2._company = "Apple";
        job2._jobTitle = "IOS Developer";
        job2._startYear = 2016;
        job2._endYear = 2019;


        // job1.Display();
        Resume myResume = new Resume();
        myResume._name = "Ashish Jain";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}