using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Trizsa Padua", "Calculus");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("\nIrene Padua", "Integrals", "3.1", "41, 42, 43-50\n");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("\nKyle Montero", "Travel", "The Bon Voyage");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}