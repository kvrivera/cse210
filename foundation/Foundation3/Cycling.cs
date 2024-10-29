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
        double distance = _speed * _activeMinutes;
        return distance;
    }

    public override string GetSummary()
    {
        string dateString = _date.ToString("dd MMM yyyy");
        double distance = CalculateDistance();
        double pace = CalculatePace();

        return $"{dateString} Cycling ({_activeMinutes} min)- Distance {distance} km, Speed: {_speed} kph, Pace: {pace} min per km";
    }
}