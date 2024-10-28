using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    // Member Variable(s)
    private bool _isComplete;

    // Constructor(s)
    public SimpleGoal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Method(s)
    public override void RecordEvent()
    {
        // syntax
    }

    public override bool IsComplete()
    {
        // syntax
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        // syntax
        return "";
    }
}