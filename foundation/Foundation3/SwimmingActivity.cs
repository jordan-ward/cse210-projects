public class SwimmingActivity : Activity
{
    // Variable = Number of Laps

    public SwimmingActivity(int length, string type, double variable) : base(length, type, variable)
    {
        
    }

    public string GetDistance()
    {
        double distance = _variable * 50 / 1000 * 0.62;
        return $"{distance} Miles";
    }

    public string GetSpeed()
    {
        double speed = ((_variable * 50 / 1000 * 0.62) / _length) * 60;
        return $"{speed} MPH";
    }

    public string GetPace()
    {
        double pace = _length / (_variable * 50 / 1000 * 0.62);
        return $"{pace} Min per Mile";
    }

    public override string GetSummaryInfo()
    {
        return $"{_date} {_type} ({_length} Min): Laps: {_variable}, Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}.";
    }
}