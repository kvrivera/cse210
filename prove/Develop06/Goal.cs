public abstract class Goal
{
    // Member Variables
    protected string _shortName;
    protected string _description;
    protected int _points;

    protected bool _isComplete;

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
        return $"{_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

    public virtual string GetGoalName()
    {
        return _shortName;
    }

    public virtual int ShowGoalPoints()
    {
        return _points;
    }
}