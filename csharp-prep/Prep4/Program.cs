using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -99999;
        Console.WriteLine("Enter a series of positive numbers (type 0 to finish)");
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string response = Console.ReadLine();
            number = int.Parse(response);
            
            
            if (number != 0)
            {
                numbers.Add(number);                
            }

        }
        // sum
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;    
        }
        Console.WriteLine($"The sum is: {total}");

        // Average
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // max number
        int max_number = -1;
        
        foreach (int num in numbers)
        {
            if (num > max_number)
            {
                max_number = num;
            }
        }
        Console.WriteLine($"The largest number is: {max_number}");



        
    }
}