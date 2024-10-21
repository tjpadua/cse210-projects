using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Friends!");
        List<Video> videos = new List<Video>();

        Video video1 = new Video("\nI solved the Algebra problem in just 1 minute.", "Kyle Montero", 700);
        video1.AddComment("Remy", "That's wonderful!");
        video1.AddComment("Donny", "Excellent!");
        video1.AddComment("Clarisse", "How true is that?");

        Video video2 = new Video("I passed the B1-Deutsch Prüfung!", "Joy Padua", 50);
        video2.AddComment("Saim", "Sana all!");
        video2.AddComment("Gretchen", "You deserve it.");
        video2.AddComment("Lyn", "Galing!");

        Video video3 = new Video("My Journey as an Au Pair", "Irene Padua", 4805);
        video3.AddComment("Jazzie", "Enjoy your journey.");
        video3.AddComment("JL", "I want to be an Au Pair, too.");
        video3.AddComment("Pearl", "That's beautiful places.");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"{video.GetDisplayText()}\n");
        }
    }

}