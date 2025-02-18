
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Goal> Goals = new List<Goal>();
        GoalManager goalManager = new GoalManager(Goals, 0); 
        
        int option;
        do{

            goalManager.DisplayLevel();
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Remove a Goal");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choise from the menu: ");

            if (int.TryParse(Console.ReadLine(), out option))
            {
                int choice;

                switch(option)
                {
                    
                    case 1:
                    Console.Clear();
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine(" 1. Simple Goal");
                    Console.WriteLine(" 2. Eternal Goal");
                    Console.WriteLine(" 3. Checklist Goal");
                    Console.Write("What type of goal would you like to create? ");
                    // string str_goalChoice = Console.ReadLine();
                    if (int.TryParse(Console.ReadLine(), out choice)) 
                    {

                        Console.WriteLine("What is the name of this new goal?");
                        string goalName = Console.ReadLine();
                        Console.WriteLine("What is the desicription of this new goal? ");
                        string goalDescribtion = Console.ReadLine();
                        Console.WriteLine("How many points will this goal be worth? ");
                        int goalPoints = int.Parse(Console.ReadLine());
                        Goal newGoal = new Goal("name", "descirbtion", 0);
                        switch(choice)
                        {
                            case 1:
                            newGoal = new SimpleGoal(goalName, goalDescribtion, goalPoints);

                            break;

                            case 2:
                            newGoal = new EternalGoal(goalName, goalDescribtion, goalPoints);

                            break;
                            case 3:
                            Console.WriteLine("How many times will this goal be repeatead?");
                            int target = int.Parse(Console.ReadLine());
                            Console.WriteLine("What is the bonus for completed this goal? ");
                            int bonus = int.Parse(Console.ReadLine());
                            newGoal = new ChecklistGoal(goalName, goalDescribtion, goalPoints, target, bonus);

                            break;
                        }
                        goalManager.AddGoal(newGoal);     

                    }
                    break;

                    case 2:
                    goalManager.DisplayGoals();  

                    break;

                    case 3:
                    goalManager.Save();
                    break;

                    case 4:
                    goalManager.Load();
                    break;

                    case 5:
                    goalManager.RecordEvent();

                    break;

                    case 6:
                    goalManager.RemoveGoal();
                    break;

                    case 7:
                    Console.WriteLine("Exiting the program...");

                    break;

                    default:
                    Console.WriteLine("Invalid option, try again.");
                    break;


                }
            }
            else
            {
                Console.WriteLine("Invalid entry, please enter a number");
            }

        }
        while(option !=7);
        Console.WriteLine("Completed Program");
    }
}

