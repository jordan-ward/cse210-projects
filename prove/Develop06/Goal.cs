public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed;

    public Goal()
    {
        _name = "Name of Goal";
        _description = "Description of Goal";
        _points = 50;
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

// Marks the simple goal complete. Number of times a checklist goal is completed. return point values.
    public abstract void RecordEvent();
    
// Should return true once goal is completed.
    public abstract bool IsComplete();

// Returns details in a way to be shown in a list. Includes the checkbox, name, and description. 
// And how many times the goal has been completed for the checklist goal.
    public virtual string GetDetailsString()
    {
        return $" [] {_name}: {_description} ({_points} pts.)";
    }

// Provide all details as an easy way to save to a file.
    public abstract string GetStringRepresentation();

    protected void CreateBaseGoal()
    {
        Console.Write("What is the name of the goal?: ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of this goal?: ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points you would like this goal to be?: ");
        string goalPoints = (Console.ReadLine());
        _points = Convert.ToInt32(goalPoints);

        _completed = false;
    }

    public virtual void CreateChildGoal()
    {

    }

    public abstract int CalculatePoints();
}