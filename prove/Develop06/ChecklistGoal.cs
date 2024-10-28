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
        // syntax
    }

    public override bool IsComplete()
    {
        // syntax
        throw new NotImplementedException();
    }

    public override string GetDetailsString()
    {
        // syntax
        return "";
    }

    public override string GetStringRepresentation()
    {
        // syntax
        return "";
    }
}