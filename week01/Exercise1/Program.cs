using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");




        /*
        int y;
        y = 6;
        int x = 5;
        Console.WriteLine(x+6);

        Console.Write("What is your fav color: ");
        String color = Console.ReadLine();
        Console.WriteLine($"Your fav color is {color}");

        if (x < y )
        {
            Console.WriteLine($"{x} is less than {y}");
        }

        string school = "BYU Idaho";
        Console.WriteLine($"I am studying at {school}.");

        */
    }
}