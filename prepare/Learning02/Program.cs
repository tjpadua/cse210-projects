using System;

class Program
{
    static void Main(string[] args)
    {
        // 2. Create a new job instance named job1
        Job  job1 = new Job();

        // 3. Set the member variables using the dot notation 
        //    (for example, job1._jobTitle = "Software Engineer";
        job1._jobTitle = "Math Teacher";
        job1._company = "St. Alexius";
        job1._startYear = 2019;
        job1._endYear = 2020;

        // 5. Create a second job, set its variables, 
        //    display this company on the screen as well.
        Job job2 = new Job();
        job2._jobTitle = "Amazon Manager";
        job2._company = "Seller Interactive";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // STEP 5: Add a Display method to the Job class
        // 3. Return to your Program.cs file. Remove the lines of code 
        //    where you displayed the company earlier, and replace them 
        //    with calls to your new method. Remember that you call the 
        //    method using the same dot notation such as job1.Display(); .
        // Console.WriteLine($"{job1._jobTitle} ({job1._company}) {job1._startYear}-{job1._endYear}");
        // Console.WriteLine($"{job2._jobTitle} ({job2._company}) {job2._startYear}-{job2._endYear}");


        Resume myResume = new Resume();
        myResume._name = "Trizsa Padua";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}