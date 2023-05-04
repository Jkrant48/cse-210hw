using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._Jobtitle = "Software engineer";
        Job1._company = "Microsoft";
        Job1._startyear = 2010;
        Job1._endyear = 2020;

        Job Job2 = new Job();
        Job2._Jobtitle = "Manager";
        Job2._company = "Apple";
        Job2._startyear = 2015;
        Job2._endyear = 2022;

        resume Resume1 = new resume();
        Resume1._name = "Allison Rose";

        Resume1._jobs.Add(Job1);
        Resume1._jobs.Add(Job2);

        //Job1.Display();
        //Job2.Display();
        Resume1.Display();
    }
     
    
}