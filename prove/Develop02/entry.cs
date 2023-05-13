using System;

public class new_entry
{   
    static void Main()
    {
        DateTime CurrentDateTime = DateTime.Now;
        string formattedDateTime = CurrentDateTime.ToShortDateString();
        Console.WriteLine(formattedDateTime);
    }
}    

