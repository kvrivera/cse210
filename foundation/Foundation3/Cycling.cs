public class Cycling : Activity
{
    // Variables
    private double _speed;

    // Constructor(s)
    public Cycling(double speed, int activeMinutes)
    {
        _speed = speed;
        _activeMinutes = activeMinutes;
    }


    // Method(s)
    protected override double CalculateDistance()
    {
        double distance = (_speed / 60) * _activeMinutes; // calculate active minute to active hours
        return distance;
    }

    public override string GetSummary()
    {
        string dateString = _date.ToString("dd MMM yyyy");
        double distance = CalculateDistance();
        double pace = CalculatePace();

        return $"{dateString} Cycling ({_activeMinutes} min)- Distance {distance:F1} km, Speed: {_speed:F1} kph, Pace: {pace:F1} min per km";
    }
}