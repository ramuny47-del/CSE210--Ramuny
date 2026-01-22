using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
    job1.company = "Microsoft";
    job1.jobtitle = "computer science";
    job1.startyear = 2019;
    job1.endyear = 2020;

    Job Job2 = new Job();
    Job2.company = "NASA";
    Job2.jobtitle = "Astrophysicist";
    Job2.startyear = 2000;
    Job2.endyear = 2010;

    Resume resume = new Resume();
    resume.name = "Ram";
    resume.Jobs.Add(job1);
    resume.Jobs.Add(Job2);
    resume.display();
    }

    

}