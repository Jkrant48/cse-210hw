using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade_percentage = Console.ReadLine();
        int percentage = int.Parse(grade_percentage);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A" ;
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else if (percentage < 60)
        {
            letter = "F";
        }
        Console.WriteLine(letter);
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else 
        {
            Console.WriteLine("Don't give up, Keep studying hard.");
        }
        //Console.WriteLine(percentage);
    }
}