using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numList = new List<int>();

        int userNum1 = -1;
        int sumNum = 0;
        int largestNum = -99999;
        int smallestNum = 99999;

        while (userNum1 != 0)
        {
            Console.Write("Enter number (type 0 to quit): ");
            string userNum = Console.ReadLine();
            userNum1 = int.Parse(userNum);
            if (userNum1 != 0)
            {
                sumNum += userNum1;
                numList.Add(userNum1);

                
            if (userNum1 > 0)
            {
                if (userNum1 < smallestNum)
                {
                    smallestNum = userNum1;
                }
            }

            }
            if (userNum1 > largestNum)
            {
                largestNum = userNum1;
            } 
            
            
        }
        double avNum;
        double c = numList.Count;
        avNum = sumNum / c;
        Console.WriteLine($"The sum is: {sumNum}");
        Console.WriteLine($"The average is:  {avNum}");
        Console.WriteLine($"The largest number is: {largestNum}");
        Console.WriteLine($"The smallest positive number is: {smallestNum}");


        numList.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int a in numList)
        {
            Console.WriteLine(a);  
        }
    


        

        /*

        // List 
        List<int> numbers;
        List<String> words;

        numbers = new List<int>();
        words = new List<string>();

        // This is typically done on the same line:
        //List<int> numbers = new List<int>();
        //List<String> words = new List<string>();

        // Adding items to the list .Add("Value");

        words.Add("phone");
        words.Add("Keyboard");
        words.Add("mouse");
        Console.WriteLine(words);

        // Getting the list size
        Console.WriteLine(words.Count);

        foreach (string word in words)
        {
            Console.Write($"{word} ");
        }

        // You can also access the items by their index:
        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }
        */


        



        
    }
}
