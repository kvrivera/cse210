public class GoalManager
{
    // Member Variable(s)
    private List<Goal> _goals;
    private int _score;

    private List<string> _animationStrings;

    // Constructor(s)
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _animationStrings = new List<string> { "|", "/", "-", "\\" };

    }

    protected void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            foreach (string s in _animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(250); // pause
                Console.Write("\b \b"); // erase previous char, space to clear, erase space
                currentTime = DateTime.Now; // update currentTime for loop break
            }
        }
    }

    // Method(s)
    public void Start() // show score, then menu
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine($"Your score is: {_score}");
        Console.WriteLine();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");

    }

    private void DisplayPlayerInfo()
    {
        // syntax
    }

    public void ShowGoalList()
    {
        foreach (Goal goal in _goals)
        {
            int listNumber = _goals.IndexOf(goal) + 1;
            string goalNameString = goal.GetGoalName();
            string detailsString = goal.GetDetailsString();
            Console.WriteLine($"{listNumber}.)  {goalNameString} ({detailsString})");
        }
    }

    private void ListGoalDetails(List<Goal> listOfGoals)
    {
        // syntax
        int orderedNumber = 1;
        foreach (Goal goal in listOfGoals)
        {
            string goalDetailsString = goal.GetDetailsString();
            Console.WriteLine($"{orderedNumber}.) {goalDetailsString}");
            orderedNumber++; // increase by 1 after each iteration of this foreach loop
        }
    }
    public void CreateGoal()
    {
        // syntax
        // List the goal types
        Console.WriteLine("The types of goals are:\n  1. Simple Goal\n  2. Checklist Goal\n  3. Eternal Goal");
        Console.Write("Which type of goal would you like to create?: ");
        int userGoalChoice = int.Parse(Console.ReadLine()); // What goal does the user want to create?

        if (userGoalChoice == 1) // Create a simple goal
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("Give a short description of your goal: ");
            string goalDescription = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints); // create an instance of the goal
            _goals.Add(simpleGoal); // add the simpleGoal to the list of goals

            Console.WriteLine("Goal created!");
            Console.WriteLine("Returning to main menu...");
            ShowSpinner(3); // 3 second delay
        }
        else if (userGoalChoice == 2) // Create a checklist goal
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("Give a short description of your goal: ");
            string goalDescription = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            Console.Write("How many times does this goal need to be achieved in order to receive a bonus? ");
            int goalTarget = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing the goal that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
            _goals.Add(checklistGoal); // add new instance of ChecklistGoal to _goals list

            Console.WriteLine("Goal created!");
            Console.WriteLine("Returning to main menu...");
            ShowSpinner(3); // 3 second delay
        }
        else if (userGoalChoice == 3) // create an eternal goal
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("Give a short description of your goal: ");
            string goalDescription = Console.ReadLine();

            Console.Write("How many points are awarded each time this goal is achieved? ");
            int goalPoints = int.Parse(Console.ReadLine());

            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(eternalGoal); // add new instance of EternalGoal to _goals list

            Console.WriteLine("Goal created!");
            Console.WriteLine("Returning to main menu...");
            ShowSpinner(3); // 3 second delay
        }
    }
    public void RecordEvent()
    {
        // syntax
        Console.WriteLine(); // blank space
        Console.WriteLine("Which goal have you worked on?");
        ShowGoalList(); // show the goal list
        Console.WriteLine(); // blank space
        Console.Write("Type the number of the goal as it corresponds to the goal list: ");
        int goalToBeRecordedInt = int.Parse(Console.ReadLine());

        Goal goalToBeRecorded = _goals[goalToBeRecordedInt - 1];

        // award points
        int goalPoints = goalToBeRecorded.ShowGoalPoints();
        Console.WriteLine($"Congratulations! You have been awarded {goalPoints} points!"); // how many points the user won for this accomplishment
        _score += goalPoints;
        Console.WriteLine($"You now have {_score} points. Keep up the amazing work! :)");
        Console.WriteLine(); // blank space

        // check the box
        if (goalToBeRecorded.IsComplete() == true)
        {
            string checkedBox = "[X]";
            string goalDetails = goalToBeRecorded.GetDetailsString();
            string goalDetailsString = $"{checkedBox} + {goalDetails}";
            Console.WriteLine(goalDetailsString);
        }

    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileNameSave = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileNameSave))
        {
            // Add text to the file with the WriteLine method
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                string fileString = goal.GetStringRepresentation();
                outputFile.WriteLine($"{fileString}");
                // SimpleGoal;goalName;goalDescription;goalPoints;boolean value for complete;
                // ChecklistGoal;goalName;goalDescription;goalPointsToAward;bonusPointsToAward;goalTarget;amountCompleted
                // EternalGoal;goalName;goalDescription;goalPointsToAward
            }
        }
    }
    public void LoadGoals()
    {
        // syntax
        List<Goal> loadedGoals = new List<Goal>(); // new list to store these goals in

        Console.Write("What is the name of the file you want to load? ");
        string fileNameLoad = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileNameLoad);
        foreach (string line in lines)
        {
            string[] parts = line.Split(";");
            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                string goalName = parts[1];
                string goalDescription = parts[2];
                int goalPoints = int.Parse(parts[3]);
                string goalCompleted = parts[4];

                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                if (goalCompleted == "true")
                {
                    simpleGoal.IsComplete();
                }
                loadedGoals.Add(simpleGoal); // append to the loadedGoals List
            }
            else if (goalType == "ChecklistGoal")
            {
                string goalName = parts[1];
                string goalDescription = parts[2];
                int goalPoints = int.Parse(parts[3]);
                int bonusPoints = int.Parse(parts[4]);
                int goalTarget = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);

                ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, bonusPoints);
                for (int i = amountCompleted; i > 0; i--)
                {
                    checklistGoal.RecordEvent();
                }
                loadedGoals.Add(checklistGoal); // Append to the loadedGoals List

            }
            else if (goalType == "EternalGoal")
            {
                string goalName = parts[1];
                string goalDescription = parts[2];
                int goalPoints = int.Parse(parts[3]);

                EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                loadedGoals.Add(eternalGoal); // Append to the loadedGoals List
            }

            Console.WriteLine("Loading your saved goals...");
            ShowSpinner(3);

            Console.WriteLine(); // blank space
            ListGoalDetails(loadedGoals);
            Console.WriteLine();


        }
    }
}