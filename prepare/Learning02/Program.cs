using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2018;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Computer Scientist";
        job2._companyName = "MIT Technichal Institute";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Resume resume1 = new Resume();
        resume1._name = "Trenton Ringger";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}