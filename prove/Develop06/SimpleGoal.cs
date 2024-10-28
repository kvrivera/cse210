using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    // Member Variable(s)
    // private bool _isComplete;

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
        IsComplete();
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        _isComplete = true;
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        // what will be stored in the file
        return $"SimpleGoal;{_shortName};{_description};{_points};{_isComplete};";
        // simpleGoal;goalName;goalDescription;goalPoints;boolean value for complete
    }

    public override string GetDetailsString()
    {
        if (_isComplete == true)
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }
}