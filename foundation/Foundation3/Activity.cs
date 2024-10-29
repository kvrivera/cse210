public abstract class Activity
{
    // Variables
    protected int _activeMinutes;
    protected DateTime _date;
    protected double? _distance; // this is a nullable value, which is important for the methods below

    // Constructor(s)
    public Activity()
    {
        _activeMinutes = 0;
        _date = DateTime.Now; // get the date today
        _distance = null;
    }

    // Methods
    public abstract string GetSummary(); // override in each class

    protected virtual double GetDistance()
    {
        if (!_distance.HasValue) // if there is no value for _distance
        {
            _distance = CalculateDistance();
        }
        return _distance.Value;
    }
    protected virtual double CalculatePace()
    {
        double distance = GetDistance();
        double pace = _activeMinutes / distance;
        return pace;
    }

    protected virtual double CalculateDistance()
    {
        double speed = CalculateSpeed();
        double distance = speed * _activeMinutes;
        return distance;
    }

    protected virtual double CalculateSpeed()
    {
        double distance = GetDistance();
        double speed = distance / _activeMinutes * 60;
        return speed;
    }

}