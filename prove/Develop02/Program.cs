using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        int response = 0;
        while (response != 5)
        {
            Console.WriteLine("Please select from the following Choices:");
            Console.WriteLine("1. Write \r\n2. Display \r\n3. Load \r\n4. Save \r\n5. Quit");
            Console.WriteLine("What would you like to do? ");
            string answer = Console.ReadLine();
            response = int.Parse(answer);

            if (response == 1)
            {

            }

            else if (response == 2)
            {

            }

            else if (response == 3)
            {

            }

            else if (response == 4)
            {

            }

            else if (response == 5)
            {
                Console.WriteLine("Thank You.");
            }
        }

    }
}