public class Swimming : Activity
{
    // Variables
    private int _numberOfLaps;

    //Constructor(s)
    public Swimming(int numberOfLaps)
    {
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
        return $"{dateString} Swimming ({_activeMinutes} min)- Distance {distance} km, Speed: {speed} kph, Pace: {pace} min per km";
    }

}