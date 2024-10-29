using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear(); // neat and tidy

        List<Activity> activities = new List<Activity>(); // create a list to store the activities in

        Running runLog = new Running(12.0, 62); // create instance of Running
        activities.Add(runLog); // add activity to activities list

        Swimming swimLog = new Swimming(15); // create instance of Swimming
        activities.Add(swimLog); // add activity to activities list

        Cycling cycleLog = new Cycling(12.0, 89); // create instance of Cycling
        activities.Add(cycleLog); // add activity to activities list

        Console.WriteLine("Summary of Activities:");
        foreach (Activity activity in activities)
        {
            string activitySummary = activity.GetSummary();
            Console.WriteLine($"  {activitySummary}");
        }

        Console.WriteLine("Great work on your physical activity!");
    }
}