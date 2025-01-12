using System;
using System.Data;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter your grade: ");
        string user = Console.ReadLine();
        int grade = int.Parse(user);

       
        string letterGrade;
        if (grade >= 93 && grade <= 100)
        {
            letterGrade = "A";
        } 
        else if (grade >= 90 && grade <= 92  )
        {
            letterGrade = "-A";
        }
        else if (grade >= 87 && grade <= 89)
        {
            letterGrade = "B+";
        }
        else if (grade >= 83 && grade <= 86 )
        { 
            letterGrade = "B";
        }
        else if (grade >= 80 && grade <= 82)
        {
            letterGrade = "B-";
        }
        else if (grade >= 77 && grade <= 79 )
        {
            letterGrade = "C+";
        }
        else if (grade >= 73 && grade <= 76)
        {
            letterGrade = "C";
        }
        else if (grade >= 72 && grade <= 76 )
        {
            letterGrade = "C-";
        }
        else if (grade >= 67 && grade <=69 )
        {
            letterGrade = "D+";
        }
        else if (grade >= 63 && grade <= 66)
        {
            letterGrade = "D";
        }
        else if (grade >= 60 && grade <= 62)
        {
            letterGrade = "D-";
        }
        else if (grade <= 59)
        {
            letterGrade = "F";
        }
        else
        {
            letterGrade = "Out of range";
        }

        Console.WriteLine($"Your grade is {letterGrade}");

        if (grade >= 70 && !(grade > 100))
        {
            Console.WriteLine("You Passed");
        }
        else 
        {
            Console.WriteLine("Good luck! do your very best next time!!");
        }




        /*
        if (grade >= 90)
        {
            Console.WriteLine($"Congratulations!! you passed, you have an {letterGrade}");
        }
        else if (grade >= 80)
        {
            Console.WriteLine($"Congratulations, you have a {letterGrade}");
        }
        else if (grade >= 70)
        {
            Console.WriteLine($"Congratulations you have a {letterGrade} ");
        }
        else if (grade >= 60)
        {
            Console.WriteLine($"You should improve, you have a {letterGrade}");
        }
        else
        {
            Console.WriteLine($"You have a {letterGrade}, you should improve");
        }

        */

        /*
        // Conditions
        int x = 10;
        int y = 6;
        int z = 7;

        // if statement 
        if (x > y )
        {
            Console.WriteLine("Greater than");
            if (x > z)
            {
                Console.WriteLine("Greater than both");
            }


        }

        // if and else
        if (x > y)
        {
            Console.WriteLine("Greater than");
        }
        else
        {
            Console.WriteLine("Less than");
        }

        int a = 4;
        int b = 5;
        int c = 7;
        if (a > b)
        {
            Console.WriteLine($"{a} is greater than {b}");
        }
        else if (b > c)
        {
            Console.WriteLine($"{b} is greater than {c}");
        }
        else
        {
            Console.WriteLine("less than both");
        }

        Console.Write("Enter your name:");
        string name = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {name} {lastName}");

        if (name == "Peter"  || name == "James" || name == "John")
        {
            Console.WriteLine("This is a biblical name.");
        }
        else if (name == "Brigham" && lastName == "Young")
        {
            Console.WriteLine("Welcome to Brigham Young");
        }
        else if (!(name == "Peter" || name == "Peter" || name == "John"))    
        {
            Console.WriteLine("This is not one of those three.");
        }

        // Converting types string to int int.Parse()
        Console.Write("Enter a number: ");
        string num = Console.ReadLine();
        int num1 = int.Parse(num);
        Console.WriteLine($"The number is {num1}");

        // Number to string  variable.ToString();
        // two apperands && = and
        // || two vertical bar is or 
        int number = 55;
        string textVersion = number.ToString();
        Console.WriteLine($"The value is {textVersion}");

        Console.Write("Enter the first number: ");
        string myNum = Console.ReadLine();

        Console.Write("Enter the first number: ");
        string myNum2 = Console.ReadLine();

        int num2 = int.Parse(myNum);
        int num3 = int.Parse(myNum2);

        if (num2 > num3)
        {
            Console.WriteLine($"{num2} is greater than {num3} ");
        }
        else if (num3 > num2)
        {
            Console.WriteLine($"{num3} is greater than {num2}");
        }
        else
        {
            Console.WriteLine($"{num2} and {num3} are equal");
        }
        */

        

    }
}