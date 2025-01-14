using System;

class Book // The class name is Book : The Blueprint
{

    // Members variables or Attributes
    public string _title;
    public string _author;
    public int _publicationYear;
    
    // Providing the default case
    // A constructor, a special member function whose names maches exactly the name of the class
    // C# will call this function directly when it times to create a new book
    public Book()
    {
        _title = "Unknown Title";
        _author = "Anonymous";
        _publicationYear = -1;
    }


    // Member Functions or Methods
    public void DisplayInfo()
    {
        Console.WriteLine($"{_title} by {_author}");
    }

    // It has to be called in a context of an object
    public void DisplayInfoWithPublicationYear(int numberOfBooks)
    {
        Console.WriteLine($"{_title} by {_author}  published in {_publicationYear} number of books {numberOfBooks}");
    }
    

}