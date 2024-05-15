using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignment = new Assignment("John Doe", "Mathematics");


        string summary = assignment.GetSummary();


        Console.WriteLine(summary);

    }


}