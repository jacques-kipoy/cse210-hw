using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 11);

        int myGuess = -1;
        int turn = 0;
        while (myGuess != randomNumber)
        {
            Console.Write("What is your guess?: ");
            myGuess = int.Parse(Console.ReadLine());

            if (randomNumber > myGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (randomNumber < myGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                
            }
            turn += 1;
            
            
        }
        Console.WriteLine($"Number of turns {turn}");
        Console.WriteLine($"The guess number was {randomNumber}");





        



        /* Remove this one 

        // While loop 
        string response = "yes";
        while (response=="yes")
        {
            Console.Write("Do you want to continue (yes/no): ");
            response = Console.ReadLine();
        }   


        //do while loop
        do
        {
            Console.Write("Do you want to play (yes/no):");
            response = Console.ReadLine();
        } while (response =="yes");

        // Foreach 
        // The standard for loop in C# is more like a "for x in range" loop in Python
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 2; i <= 20; i = i +2 )
        {
            Console.WriteLine(i);
        }

        // Foreach Loops
        //C# contains a foreach loop that is similar to a standard for loop in Python.
        /*
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }
        */
        
        /* Remove this one
        
        //Console.WriteLine(number);
        string guess;
        string user;
        
        int turn2 = 0;

        Console.Write("What is the magic number: ");
        guess = Console.ReadLine();
        int guess1 = int.Parse(guess);
        do 
        {
            

            Console.Write("What is your guess: ");
            user = Console.ReadLine();
            int user1 = int.Parse(user);

            if (guess1 > user1)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("Lower");
            }
            turn2 += 1;


        } while (guess != user );
        Console.WriteLine("You guessed it !");
        Console.WriteLine($"Number of turns {turn}");
        

        
        
        /*

        Console.Write("What is the magic number: ");
        string guessn = Console.ReadLine();
        int guess2 = int.Parse(guessn);

        Console.Write("What is your guess: ");
        string usern = Console.ReadLine();
        int user2 = int.Parse(usern);
        

        while (guess2 != user2)
        {
            

             if (guess2 > user2)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess: ");
            string userc = Console.ReadLine();
            int user3 = int.Parse(userc);
            

        }
        */



    }
}

