using System;

class Program
{
    static void Main(string[] args)
    {
        Assignement assignement1 = new Assignement("David Gjennestad", "Cheese");
        Console.WriteLine(assignement1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Cami Stark", "Writing", "Hope", "7-12");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Zach White", "Writing", "The Art of Wyverns");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());

    }
}