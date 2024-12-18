public class RunningActivity : Activity
{
// Variable = Distance
    public RunningActivity(int length, string type, double variable) : base(length, type, variable)
    {

    }

    public string GetDistance()
    {
        double distance = _variable;
        return $"{distance} Miles";
    }

    public string GetSpeed()
    {
        double speed = (_variable / _length) * 60;
        return $"{speed} MPH";
    }

    public string GetPace()
    {
        double pace = _length / _variable;
        return $"{pace} Min per Mile";
    }
        public override string GetSummaryInfo()
    {
        return $"{_date} {_type} ({_length} Min): Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}.";
    }
}