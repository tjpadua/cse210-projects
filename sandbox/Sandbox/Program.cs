using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        // Person p1 = new Person();
        // p1._firstName = "Trizsa";
        // p1._lastName = "Padua";
        // p1._age = 25;

        // Person p2 = new Person();
        // p2._firstName = "Kyle";
        // p2._lastName = "Montero";
        // p2._age = 27;

        // List<Person> people = new List<Person>();
        // people.Add(p1);
        // people.Add(p2);

        // foreach (Person p in people)
        // {
        //     Console.WriteLine(p._firstName);
        // }

        // SaveToFile(people);

        List<Person> newPeople = ReadFromFile();
        foreach (Person p in newPeople)
        {
            Console.WriteLine(p._lastName);
        }
    }

    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine("Saving to file...");

        string filename = "people.txt";

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputfile.WriteLine($"{p._firstName}~~{p._lastName}~~{p._age}");
            }
        }
    }

    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading List from file...");
        List<Person> people = new List<Person>();
        string filename = "people.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
           // Console.WriteLine(line);
           // line will be: "Trizsa~~Padua~~25"
           string[] parts = line.Split("~~");

           // parts[0] ~ Trizsa
           // parts[1] ~ Padua
           // parts[2] ~ 25

           Person newPerson = new Person();
           newPerson._firstName = parts[0];
           newPerson._lastName = parts[1];
           newPerson._age = int.Parse(parts[2]);

            people.Add(newPerson);
        }

        return people;
    }
}