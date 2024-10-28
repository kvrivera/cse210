public class GoalManager
{
    // Member Variable(s)
    private List<Goal> _goals;
    private int _score;

    // Constructor(s)
    public GoalManager()
    {
        List<Goal> _goals = new List<Goal>();
        _score = 0;
    }

    // Method(s)
    private void Start()
    {
        // syntax
    }

    private void DisplayPlayerInfo()
    {
        // syntax
    }

    private void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            int listNumber = _goals.IndexOf(goal) + 1;
            string goalName = goal.GetGoalName();
            Console.WriteLine($"{listNumber}.) {goalName}");
        }
    }

    private void ListGoalDetails()
    {
        // syntax
    }
    private void CreateGoal()
    {
        // syntax
    }
    private void RecordEvent()
    {
        // syntax
        Console.Write("Which goal have you worked on? ");
        string goalToBeRecorded = Console.ReadLine();
        // do i need to parse the string to a Goal object?
        goalToBeRecorded.RecordEvent();
    }
    private void SaveGoals()
    {
        // syntax
    }
    private void LoadGoals()
    {
        // syntax
    }
}