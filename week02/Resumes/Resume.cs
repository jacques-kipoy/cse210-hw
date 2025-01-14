using System;

public class Resume
{

    // Creating attributes or member variables
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Creating Functions or Methods
    public void DisplayResume()
    {
        Console.WriteLine($"Name:{_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}