using System;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public string DisplayPoints()
    {
        int totalPoints = _score;
        foreach(Goal goal in goals)
        {
            totalPoints += goal.CalculatePoints();
        }
        _score = totalPoints;

        return $"Your current score is: {_score} points.";
    }

    public int GetAccumulatedPoints()
    {
        int totalPoints = _score;
        foreach(Goal goal in goals)
        {
            totalPoints += goal.CalculatePoints();
        }
        _score = totalPoints;

        return totalPoints;
    }

// Called by Program.cs to run the menu function.
    public void Start()
    {
        string userSelection = "";

        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create a new goal");
        Console.WriteLine("  2. List goals");
        Console.WriteLine("  3. Save goals");
        Console.WriteLine("  4. Load goals");
        Console.WriteLine("  5. Record event");
        Console.WriteLine("  6. Quit");
        Console.WriteLine();
        Console.Write("Please select a number from the menu: ");
        userSelection = Console.ReadLine();

        while(userSelection != "6")
        {
            if(userSelection == "1")
            {
                Console.WriteLine();
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine("What type of goal would you like to create?");
                Console.Write("Please enter the number you would like to select: ");
                string goalType = Console.ReadLine();

                if(goalType == "1")
                {
                    SimpleGoal newSimpleGoal = new SimpleGoal();
                    newSimpleGoal.CreateChildGoal();
                    goals.Add(newSimpleGoal);
                    break;
                }

                if(goalType == "2")
                {
                    EternalGoal newEternalGoal = new EternalGoal();
                    newEternalGoal.CreateChildGoal();
                    goals.Add(newEternalGoal);
                    break;
                }

                if(goalType == "3")
                {
                    ChecklistGoal newChecklistGoal = new ChecklistGoal();
                    newChecklistGoal.CreateChildGoal();
                    goals.Add(newChecklistGoal);
                    break;
                }

                else
                {
                    Console.WriteLine("That was not a valid choice. Please try again.");
                    break;
                }
                

            }

            if(userSelection == "2")
            {
                for (int i = 0; i < goals.Count(); i++)
                {
                    Console.Write($"{i + 1}.");
                    goals[i].GetDetailsString();
                    Console.Write("\n");
                }
                Console.WriteLine();

                break;
            }

            if(userSelection == "3")
            {
                string fileName = "";
                Console.Write("What would you like the file name to be?: ");
                fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    int totalScore = GetAccumulatedPoints();
                    outputFile.WriteLine(totalScore.ToString());

                    foreach(Goal goal in goals)
                    {
                        outputFile.WriteLine(goal.GetStringRepresentation());
                    }
                }
                break;
            }

            if(userSelection == "4")
            {
                string fileName = "";
                Console.Write("What is the file name?");
                fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);

                _score = Convert.ToInt32(lines[0]);

                for(int i =1; i< lines.Count(); i++)
                {
                    string[] parts = lines[i].Split("|");

                    if (parts[0] == "SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                        goals.Add(simpleGoal);
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                        goals.Add(eternalGoal);
                    }
                    else if (parts[0] == "ChecklistGoal")
                    {
                        ChecklistGoal ChecklistGoal = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]));
                        goals.Add(ChecklistGoal);
                    }
                }
                break;
            }

            if(userSelection == "5")
            {
                string goalIndex = "";
                Console.Write("Which goal did you accomplish?: ");
                goalIndex = Console.ReadLine();
                int goalNumber = Convert.ToInt32(goalIndex) -1;

                if(goals[goalNumber].IsComplete() == false)
                {
                    goals[goalNumber].RecordEvent();
                    int pointsEarned = goals[goalNumber].CalculatePoints();
                    _score += pointsEarned;

                    Console.WriteLine($"Congratulations! You earned {pointsEarned.ToString()} points!");
                    Console.WriteLine($"You now have {_score} points.");
                }
                else
                {
                    Console.WriteLine("You have already completed this goal.");
                }

                break;
            }

            else
            {
                Console.WriteLine("Thank you for playing!");
                break;
            }
        }
    }



// Displays the players current score.
    public void DisplayPlayerInfo()
    {

    }

// Lists the names of each of the goals.
    public void ListGoalNames()
    {

    }

// Lists the details of the goals including checkbox of if it is complete.
    public void ListGoalDetails()
    {
        
    }

// Asks the user information about a new goal, creates it and adds it to the list of goals.
    public virtual void CreateGoal()
    {

    }

// Asks the user which goal they have done and records the event by calling the RecordEvent method on that goal.
    public virtual void RecordEvent()
    {
        
    }

// Saves the list of goals to a file.
    public void SaveGoals()
    {
        
    }

// Loads the list of goals from a file.
    public void LoadGoals()
    {
        
    }
}