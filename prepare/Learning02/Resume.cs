using System.Runtime.CompilerServices;

public class Resume
{
    // create a variable for the person's name
    public string _name;

    // create a list of jobs
    // data type for this list is Job because only data 
    // of the same type as the class we created called Job 
    // can be entered into this list
    public List<Job> _jobs = new List<Job>();
    // to add a new job to this list you would type
    // nameOfThisInstance._jobs.Add(whateverYouAreAdding)

    public void Display() // needs no parameters, no returns
    {
        //display the person's name
        Console.WriteLine(_name);

        // now iterate through each job listed in the Job list
        foreach (Job job in _jobs)
        {
            // use the method that each of the Job data has access to! So cool
            job.DisplayJobDetails();
        }

    }
}
