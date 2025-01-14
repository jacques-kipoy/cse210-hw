using System;
using System.Data;
using System.Net.Http.Headers;

public class Job
{
    //Creating some member variables 
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;
    public string _name;
    public string _yearOfExperience;
    public string _languageSpoken;


    // Member function / Method
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} {_company} {_startYear} - {_endYear}");
    }
    
     



}