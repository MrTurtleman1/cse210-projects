using System;
using System.Collections.Generic;


namespace Learning02
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job();
            job1._company = "Microsoft";
            job1._jobTitle = "Software Engineer";
            job1._startYear = 7;
            job1._endYear = 2023;
            job1.Display();

            Job job2 = new Job();
            job2._company = "Macrohard";
            job2._jobTitle = "Software Engineer";
            job2._startYear = 32;
            job2._endYear = 11;
            job1.Display();

            Resume resume1 = new Resume();
            resume1._name = "Max Tippetts";

            resume1._jobs.Add(job1);
            resume1._jobs.Add(job2);
            
            resume1.Display();
        }
}
}

