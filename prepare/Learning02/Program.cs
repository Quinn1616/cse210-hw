using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1.Company = "Microsoft";
        job1.JobTitle = "Software Engineer";
        job1.StartYear = 2022;
        job1.EndYear = 2023;
        job1.Display();

        Job job2 = new Job();
        job2.Company = "Apple";
        job2.JobTitle = "Software Engineer";
        job2.StartYear = 2020;
        job2.EndYear = 2022;
        job2.Display();

        Resume resume1 = new Resume();
        resume1.Name = "Quinn Bastian";
        resume1.Jobs.Add(job1);  //?
        resume1.Jobs.Add(job2);  //?

        //Console.WriteLine(resume1.Jobs[0].JobTitle);
        resume1.Display();

        


    }
}