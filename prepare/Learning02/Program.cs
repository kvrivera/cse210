/*
CSE 210
Week 2 Learning Activity
Activity Instructions
Practice the principle of abstraction by creating classes 
to represent a resume or an job history for a person like 
you might see on LinkedIn.

Design the Classes
You program should contain two classes one for a Job and 
one for the Resume itself, as follows:

Class: Job
Responsibilities:
Keeps track of the company, job title, start year, and 
end year.
Behaviors:
Displays the job information in the format "Job Title 
(Company) StartYear-EndYear", for example: "Software 
Engineer (Microsoft) 2019-2022".
Class: Resume
Responsibilities:
Keeps track of the person's name and a list of their 
jobs.
Behaviors:
Displays the resume, which shows the name first, followed 
by displaying each one of the jobs.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // create a new instance of the Job class
        // ie: create a new job using the Job class
        Job job1 = new Job();

        // set member variables for job1 using dot notation
        job1._companyName = "Neopets";
        job1._jobTitle = "Chief Coding Consultant";
        job1._startYear = 1999;
        job1._endYear = 2022;

        // set member variables for job2 using dot notation
        Job job2 = new Job();
        job2._companyName = "Ikea";
        job2._jobTitle = "Breakfast Server";
        job2._startYear = 2023;
        job2._endYear = 2026;

        // TEST: to just display the company name or any member variable, use the dot method:
        // Console.WriteLine(job1._companyName);

        // TEST: Display the job details to user
        // job1.DisplayJobDetails();

        // create a new instance of the resume class
        Resume resume1 = new Resume();
        resume1._name = "Billy Joel";

        // add the jobs we created above, job1 first
        resume1._jobs.Add(job1);
        // add job2 as well
        resume1._jobs.Add(job2);

        // TEST: verify that you can access and display the first job
        // title using dot notation
        // Console.WriteLine(resume1._jobs[0]._jobTitle);

        // Display the resume on the screen
        resume1.Display();

    }
}