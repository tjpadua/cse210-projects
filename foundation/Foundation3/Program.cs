using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();

        Swimming swimming = new Swimming("30 October 2024", 10, 35);
        Swimming swimming2 = new Swimming("08 September 2019", 15, 50);
        Swimming swimming3 = new Swimming("21 May 2015", 5, 10);

        activities.Add(swimming);
        activities.Add(swimming2);
        activities.Add(swimming3);


        Cycling cycling = new Cycling("02 November 2023", 45, 12);
        Cycling cycling2 = new Cycling("21 June 2020", 30, 9);
        Cycling cycling3 = new Cycling("15 March 2019", 25, 6);

        activities.Add(cycling);
        activities.Add(cycling2);
        activities.Add(cycling3);


        Running running = new Running("21 June 2022", 55, 9);
        Running running2 = new Running("12 April 2018", 17, 3);
        Running running3 = new Running("17 January 2013", 39, 6);
        activities.Add(running);
        activities.Add(running2);
        activities.Add(running3);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
            Console.WriteLine();
        }
    }
}