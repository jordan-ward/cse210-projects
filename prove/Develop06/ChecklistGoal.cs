public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    public ChecklistGoal()
    {
        _name = "Name of Checklist Goal";
        _description = "Description of Checklist Goal";
        _points = 50;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    {
        _name = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }

// Create a Checklist Goal.
    public override void CreateChildGoal()
    {
        CreateBaseGoal();

        Console.Write("How many times do you need to complete this for a bonus? ");
        string targetAmount = Console.ReadLine();
        _target = Convert.ToInt32(targetAmount);

        Console.Write("How many bonus points do you receive for accomplishing this?");
        string bonusPoints = Console.ReadLine();
        _bonus = Convert.ToInt32(bonusPoints);

        _amountCompleted = 0;
    }

// User records if this goal is completed.
    public override void RecordEvent()
    {
        _amountCompleted ++;
    }

// Records if the goal being completed is true or false.
    public override bool IsComplete()
    {
        if(_amountCompleted >= _target)
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
        int accumulatedPoints = 0;

        accumulatedPoints = _amountCompleted * _points;

        bool _completed = IsComplete();
        if(_completed == true)
        {
            accumulatedPoints += _bonus;
        }
        return accumulatedPoints;
    }

// Links to base method and adds how many times it has been completed.
// And how many times it needs to be completed.
    public override string GetDetailsString()
    {
        return $" [] {_name}: {_description} ({_points} pts.) -- Currently completed: {_amountCompleted}/{_target} --";
    }



// Displays the goal for a save file.
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal: Completed? [{CheckIndicator}]| Name: {_name}| Description: {_description}| Points: {_points}| Currently completed: {_amountCompleted}/{_target}";
    }
}