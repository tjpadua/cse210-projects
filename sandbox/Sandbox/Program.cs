using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1._firstName = "Trizsa";
        p1._lastName = "Padua";
        p1._age = 25;

        Person p2 = new Person();
        p2._firstName = "Kyle";
        p2._lastName = "Montero";
        p2._age = 27;

        List<Person> people = new List<Person>();
        people.Add(p1);
        people.Add(p2);

        foreach (Person p in people)
        {
            Console.WriteLine(p._firstName);
        }

        SaveToFile(people);
    }

    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine("Saving to file...");

        string filename = "people.txt";

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputfile.WriteLine(p._firstName);
            }
        }
    }
}