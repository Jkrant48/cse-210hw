using System;

public class Job
{
    public string _company;
    public string _Jobtitle;
    public int _startyear;
    public int _endyear;

    public void Display()
    {
       Console.WriteLine($"{_Jobtitle} ({_company}) {_startyear} - {_endyear}");
    }
}