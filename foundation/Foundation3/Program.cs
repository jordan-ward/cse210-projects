using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList1 = new List<Activity>();
        Activity activity1 = new RunningActivity(30, "Running", 3.0);
        Activity activity2 = new BicycleActivity(30, "Bicycle", 3.0);
        Activity activity3 = new SwimmingActivity(30, "Swimming", 3.0);

        activitiesList1.Add(activity1);
        activitiesList1.Add(activity2);
        activitiesList1.Add(activity3);

        foreach(Activity a in activitiesList1)
        {
            Console.WriteLine($"{a.DisplayInfo()}");
        }

        Console.WriteLine("");

        List<Activity> activitiesList2 = new List<Activity>();
        Activity activity4 = new RunningActivity(10, "Running", 18);
        Activity activity5 = new BicycleActivity(540, "Bicycle", 20.2);
        Activity activity6 = new SwimmingActivity(120, "Swimming", 80);

        activitiesList2.Add(activity4);
        activitiesList2.Add(activity5);
        activitiesList2.Add(activity6);

        foreach(Activity a in activitiesList2)
        {
            Console.WriteLine($"{a.DisplayInfo()}");
        }
    }
}