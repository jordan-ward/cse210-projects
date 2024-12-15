public class SimpleGoal : Goal
{
    private bool _IsComplete;

    public SimpleGoal()
    {
        _name = "Name of Simple Goal";
        _description = "Description of Simple Goal";
        _points = 50;
    }

    public SimpleGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;

    }

// Create a Simple Goal.
    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

// User records if this goal is completed.
    public override void RecordEvent()
    {
        if (_completed == false)
        {
            _completed = true;
        }
        else
        {
            Console.WriteLine("This has already been completed.");
        }
    }

// Records if the goal being completed is true or false.
    public override bool IsComplete()
    {
        if (_completed == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

// Provides an "X" in a checkbox if goal is completed.
    public string CheckIndicator()
    {
        string symbol = " ";

        bool completed = IsComplete();

        if (completed == true)
        {
            symbol = "X";
        }
        else
        {
            symbol = " ";
        }

        return symbol;
    }

// Returns points for the goal if completed.
    public override int CalculatePoints()
    {
        bool completed = IsComplete();
        int accumulatedPoints = 0;
        if (completed == true)
        {
            accumulatedPoints = _points;
        }
        else
        {
            accumulatedPoints = 0;
        }

        return accumulatedPoints;
    }

// Displays the goal for a save file.
    public override string GetStringRepresentation()
    {
        return $"Simple Goal: Completed? [{CheckIndicator}]| Name: {_name}| Description: {_description}| Points: {_points}";
    }

}