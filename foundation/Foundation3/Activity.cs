using System.Reflection.Metadata.Ecma335;

public abstract class Activity
{
// Assigns the date
    protected string _date = DateTime.Now.ToString("dd MMM yyyy");

// Length of the activity in minutes
    protected int _length;

// Type of activity    
    protected string _type;

// Distance, Speed, Laps
    protected double _variable; 

// List to store the summary info into
    protected List<Activity> _activities;

// Constructor
    public Activity(int length, string type, double variable)
    {
        _length = length;
        _type = type;
        _variable = variable;
    }

// Shows info in a way to display and add to list
    public abstract string GetSummaryInfo();

    public string DisplayInfo()
    {
        return $"{GetSummaryInfo()}";
    }
}