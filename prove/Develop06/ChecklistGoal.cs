using System.ComponentModel;
using System.Numerics;

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
            _isComplete = IsComplete();
        }

    }

    public override bool IsComplete()
    {
        _isComplete = false;

        if (_amountCompleted == _target)
        {
            _isComplete = true;
            return _isComplete;
        }
        else
        {
            _isComplete = false;
            return _isComplete;
        }

    }

    public override string GetDetailsString()
    {
        if (_isComplete == true)
        {
            return $"[X] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        // what will be stored in the file
        return $"ChecklistGoal;{_shortName};{_description};{_points};{_bonus};{_target};{_amountCompleted}";
        // ChecklistGoal;goalName;goalDescription;goalPointsToAward;bonusPointsToAward;goalTarget;amountCompleted
    }

    public int GetBonusPointsValue()
    {
        return _bonus;
    }
}