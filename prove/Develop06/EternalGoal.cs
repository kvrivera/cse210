public class EternalGoal : Goal
{
    // Member Variables
    // none

    // Constructor(s)
    public EternalGoal(string name, string description, int points)
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
        return false;
    }

    public override string GetStringRepresentation()
    {
        // syntax
        return "";
    }
}