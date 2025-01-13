using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNum = SquareNumber(userNumber);

        DisplayResult(userName, squareNum);


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;

    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNum = int.Parse(Console.ReadLine());
        return userNum;
    }

    static int SquareNumber( int number)
    {
        int squareNum = number * number;
        return squareNum;

    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }







    // Exercise part

    static void DisplayMessage()
    {
        Console.WriteLine("Hello World");
    }

    static void DisplayPersonalMessage(string userName)
    {
        Console.WriteLine($"Hello {userName}");
    }

    static int AddNumbers(int first, int second)
    {
        int sum = first + second;
        return sum;
    }
    
}