using System;

class Program
{
    static void Main(string[] args)
    {
        Display_welcome_message();

        string Username = Request_User_name();
        int user_number = Request_user_number();

        int suarednumber = Squarenum(user_number);

        Display_result(Username,suarednumber);
    }

    static void Display_welcome_message()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string Request_User_name()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int Request_user_number()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int Squarenum(int number)
    {
        int squarenumber = number * number;
        return squarenumber;
    }

    static void Display_result(String name, int squarenumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squarenumber}");
    }
}