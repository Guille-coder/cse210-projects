using System;

class Program
{
    static void Main(string[] args)
    {
        // I exceeded the requirements by creating one more option in the "History" menu.
        // Due to lack of time I don't create my own class but I will work on it during the week

        List<(string, int)> record = new List<(string,int)>();
        int opcion;

        do 
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. History");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choise from the menu: ");
            
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    record.Add((breathing.GetName(),breathing.GetDuration()));
                    break;

                    case 2:
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    record.Add((reflecting.GetName(),reflecting.GetDuration()));
                    break;

                    case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    record.Add((listing.GetName(),listing.GetDuration()));
                    break;

                    case 4:
                    Activity activity = new Activity();
                    activity.ShowSpinner(5);
                    Console.WriteLine("\n--- History ---");
                    foreach (var items in record)
                    {
                        Console.WriteLine($"{items.Item1} Activity with {items.Item2} seconds");
                    }
                    Console.WriteLine("-----------------\n");
                    activity.ShowSpinner(5);
                    Console.Clear();
                    break;

                    case 5:
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

        }while (opcion !=5);
        Console.WriteLine("Completed Program");


    }
}