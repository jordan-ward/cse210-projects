public class BicycleActivity : Activity
{
    // Variable = Speed

    public BicycleActivity(int length, string type, double variable) : base(length, type, variable)
    {

    }

    public string GetSpeed()
    {
        double speed = _variable;
        return $"{speed} MPH";
    }

    public string GetDistance()
    {
        double distance = _variable * (_length / 60);
        return $"{distance} Miles";
    }

    public string GetPace()
    {
        double pace = _length / (_variable * (_length / 60));
        return $"{pace} Min per Mile";
    }
        public override string GetSummaryInfo()
    {
        return $"{_date} {_type} ({_length} Min): Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}.";
    }
}