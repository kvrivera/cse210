public abstract class Goal
{
    // Member Variables
    protected string _shortName;
    protected string _description;
    protected int _points;

    // Constructor(s)
    public Goal()
    {
        _shortName = "Name of Goal";
        _description = "Description of Goal";
        _points = 0;
    }

    // Methods
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"Goal Name: {_shortName}\nDescription: {_description}\nCompleted: [ ]";
        // how can i include the checkbox if i can't access _isComplete here?
    }

    public abstract string GetStringRepresentation();

    public virtual string GetGoalName()
    {
        return _shortName;
    }
}