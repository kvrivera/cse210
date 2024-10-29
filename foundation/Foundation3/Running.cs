using System.Runtime.CompilerServices;

public class Running : Activity
{
    // Variables
    private double _distance; // include 1 decimal place

    // Constructor(s)
    public Running(double distance, int activeMinutes)
    {
        _distance = distance;
        _activeMinutes = activeMinutes;
        _date = DateTime.Now; // get today's date
    }

    // Methods
    protected override double CalculateSpeed()
    {
        double speed = _distance / _activeMinutes * 60;
        return speed;
    }
    public override string GetSummary()
    {
        string dateString = _date.ToString("dd MMM yyyy");

        // calculate speed, save in a variable
        double speed = CalculateSpeed();
        // calculate pace, save in a variable
        double pace = CalculatePace();

        return $"{dateString} Running ({_activeMinutes} min)- Distance {_distance:F1} km, Speed: {speed:F1} kph, Pace: {pace:F1} min per km";
    }
}
