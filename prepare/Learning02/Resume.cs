// STEP 6: Create the Resume class
//   1. Create a new file for your Resume class. Each class should be in
//      its own file and the file name should match the name of the class.
using System;

//   2. Create the Resume class.
public class Resume
{
    // 3. Create the member variable for the person's name.
    public string _name;
    
    // 4. Create the member variable for the list of Jobs. 
    //    (Hint: the data type for this should be List<Job> , 
    //    and it is probably easiest to initialize this to 
    //     a new list right when you declare it..)
    public List<Job> _jobs = new List<Job>();

    // STEP 8: Add a Display method to the Resume class
    //   1. Return to your Resume class and add a method to display its details.
    //   2. This method should not have any parameters and should not return anything.
    //   3. In the method body, you should display the person's name and then 
    //      iterate through each Job instance in the list of jobs and display them.
    //   4. Hint: remember that you can call each job's Display method that you created earlier.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        // Loop for Jobs
        foreach (Job job in _jobs)
        {
            // 5. ... add a call at the end to the Display method from your Resume class
            //    to display the name and all the jobs in one line.
            job.Display();
        }

    }
}