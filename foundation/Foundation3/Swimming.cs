public class Swimming : Activity
{
    // Variables
    private int _numberOfLaps;

    //Constructor(s)
    public Swimming(int activeMinutes, int numberOfLaps)
    {
        _activeMinutes = activeMinutes;
        _numberOfLaps = numberOfLaps;
    }

    // Method(s)
    protected override double CalculateDistance()
    {
        double distance = _numberOfLaps * 50 / 1000;
        return distance;
    }
    public override string GetSummary()
    {
        string dateString = _date.ToString("dd MMM yyyy");
        double distance = CalculateDistance();
        double speed = CalculateSpeed();
        double pace = CalculatePace();
        return $"{dateString} Swimming ({_activeMinutes} min)- Distance {distance:F1} km, Speed: {speed:F1} kph, Pace: {pace:F1} min per km";
    }

}