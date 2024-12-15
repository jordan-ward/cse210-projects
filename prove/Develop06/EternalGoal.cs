public class EternalGoal : Goal
{

    public EternalGoal()
    {
        _name = "Name of Eternal Goal";
        _description = "Description of Eternal Goal";
        _points = 50;
    }

    public EternalGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

// Create an Eternal Goal.
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
        return $"Simple Goal: Completed? [ETERNAL]| Name: {_name}| Description: {_description}| Points: {_points}"; 
    }
}