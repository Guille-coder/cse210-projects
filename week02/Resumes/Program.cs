using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1= new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Manager";
        job1._startYear = 2003;
        job1._endYear = 2012;


        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2015;
        job2._endYear = 2020;

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();


        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    
       
    }

}