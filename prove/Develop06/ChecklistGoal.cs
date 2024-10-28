using System.ComponentModel;

public class ChecklistGoal : Goal
{
    // Member Variables
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor(s)
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }

    // Methods
    public override void RecordEvent()
    {

        _amountCompleted += 1; // add 1 to the amount completed
        if (_amountCompleted == _target)
        {

        }

    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailsString()
    {

        return $"[ ] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";

    }

    public override string GetStringRepresentation()
    {
        // what will be stored in the file
        return $"ChecklistGoal;{_shortName};{_description};{_points};{_bonus};{_target};{_amountCompleted}";
        // ChecklistGoal;goalName;goalDescription;goalPointsToAward;bonusPointsToAward;goalTarget;amountCompleted
    }
}