public class GoalManager
{
    // Member Variable(s)
    private List<Goal> _goals;
    private int _score;

    private int _level;

    private List<string> _animationStrings;

    // Constructor(s)
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
        _animationStrings = new List<string> { "|", "/", "-", "\\" };

    }
    private int SetPlayerLevel()
    {
        if (_score <= 25)
        {
            _level = 1;
            return _level;
        }
        else if (_score > 25 && _score <= 50)
        {
            _level = 2;
            return _level;
        }
        else if (_score > 50 && _score <= 75)
        {
            _level = 3;
            return _level;
        }
        else if (_score > 75 && _score <= 100)
        {
            _level = 4;
            return _level;
        }
        else if (_score > 100 && _score <= 150)
        {
            _level = 5;
            return _level;
        }
        else if (_score > 150 && _score <= 250)
        {
            _level = 6;
            return _level;
        }
        else if (_score > 250 && _score <= 500)
        {
            _level = 7;
            return _level;
        }
        else if (_score > 500 && _score <= 700)
        {
            _level = 8;
            return _level;
        }
        else if (_score > 700 && _score <= 800)
        {
            _level = 9;
            return _level;
        }
        else if (_score > 800 && _score < 1000)
        {
            _level = 10;
            return _level;
        }
        else if (_score >= 1000)
        {
            _level = 11;
            return _level;
        }
        return _level;
    }

    public void ShowSpinner(int seconds)
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
        Console.WriteLine();
        DisplayPlayerInfo(); // shows score and level
        Console.WriteLine();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
        _level = SetPlayerLevel();
        Console.WriteLine($"Level: {_level}/11");
    }
    public int GrabPlayerScore()
    {
        return _score;
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

    public void ListGoalDetails(List<Goal> listOfGoals)
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
        ListGoalDetails(_goals); // show the goal list
        Console.WriteLine(); // blank space
        Console.Write("Type the number of the goal as it corresponds to the goal list: ");
        int goalToBeRecordedInt = int.Parse(Console.ReadLine());
        int goalAtIndex = goalToBeRecordedInt - 1;

        Goal goalToBeRecorded = _goals[goalAtIndex]; // pinpoint the goal we are recording progress for

        goalToBeRecorded.RecordEvent();
        // award points
        int goalPoints = goalToBeRecorded.ShowGoalPoints();

        Console.WriteLine($"Congratulations! You have been awarded {goalPoints} points!"); // how many points the user won for this accomplishment
        _score += goalPoints; // add current points to total score
        Console.WriteLine($"You now have {_score} points. Keep up the amazing work! :)");
        Console.WriteLine(); // blank space

        if (goalToBeRecorded is ChecklistGoal checklistGoal) // if this goal is a CheckistGoal (called "casting")
        {
            if (checklistGoal.IsComplete() == true)
            {
                int bonusPoints = checklistGoal.GetBonusPointsValue();
                _score += bonusPoints;
            }
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

        Console.WriteLine($"Saving your goals to {fileNameSave}...");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine("Returning to main menu...");
        ShowSpinner(3);
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
        }

        _goals = loadedGoals;

        Console.WriteLine("Loading your saved goals...");
        ShowSpinner(2);

        Console.WriteLine(); // blank space
        ListGoalDetails(loadedGoals); // shows list of goals on the screen
        Console.WriteLine();
    }
}