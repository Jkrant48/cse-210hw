using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        //Console.Write("What is the magic number? ");
        //string response1 = Console.ReadLine();
        //int answer = int.Parse(response1);
        
        int guesses = 0;
        int answer1 = -5;
        while (answer1 != number)
        {
            Console.Write("What is your guess? ");
            guesses += 1; 
            string response2 = Console.ReadLine();
            answer1 = int.Parse(response2);

            if (answer1 < number)
            {
                Console.WriteLine("Higher");
            }
            else if (answer1 > number)
            {
                Console.WriteLine("Lower");
            }
            else if (answer1 == number)
            {
                Console.WriteLine("You guessed it!");
            }
        }
        Console.WriteLine($"You guessed {guesses} times.");

    }
}