using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "(Microsoft)";
        job1._startYear = 2014;
        job1._endYear = 2023;
        job1._name = "Kipoy";
        job1._languageSpoken = "English";
        job1._yearOfExperience = "2015 - 2024";

        Job job2 = new Job();
        job2._jobTitle = "Web Dev";
        job2._company = "(Apple)";
        job2._startYear = 2019;
        job2._endYear = 2025;
        job2._yearOfExperience = "2020 - 2025";

        Resume resume = new Resume();
        resume._name = "Jacques Kipoy";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);



        Console.WriteLine();

        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();
        resume.DisplayResume();
        

        Console.WriteLine();




        //Displayinfom(job2);
        //Displayinfom(job1);













        //Console.WriteLine("Hello World! This is the Resumes Project.");

        // The class name is Book
        // The object is the instance of the class BooK : which is book1 , book2 and book3

        // The Class or the Blue print is Book : that contains all the attributes

        // object 1 book1 or the instances or example
        Book book1 = new Book();
        book1._title = "Pride and Prejudice";
        book1._author = "Jane Austin";
        book1._publicationYear = 1813;

        // object 2 is book2 or instance
        Book book2 = new Book();
        book2._title = "The Fellowship of the Ring";
        book2._author = "J.R.R. Tolken";
        book2._publicationYear = 1954;

        // object 3 is book3 or instance
        Book book3 = new Book();
        book3._title = "Coding for fun";
        book3._author = "Jacques Kipoy";
        book3._publicationYear = 2025;

        
        //DisplayBookInfo(book1);
        book1.DisplayInfo();

        //DisplayBookInfo(book2);
        book2.DisplayInfo();

        //DisplayBookInfo(book3);
        book3.DisplayInfo();

        book1.DisplayInfoWithPublicationYear(10);

        Book book4 = new Book();

        book4.DisplayInfoWithPublicationYear(2);

    }

    static void Displayinfom(Job the_job)
    {
        Console.WriteLine($"Hello {the_job._name} job title is {the_job._jobTitle} language {the_job._languageSpoken} with {the_job._yearOfExperience} years of experience.");
    }
    /*
    static void DisplayBookInfo(Book the_book)
    {
        Console.WriteLine($"{the_book._title} by {the_book._author}");
    }
    */
}