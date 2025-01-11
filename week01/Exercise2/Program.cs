using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentageOfTheUsEr = Console.ReadLine();
        int grade = int.Parse(percentageOfTheUsEr);

        string letter = "";

        string siGn = "";

        if (grade < 97 && grade >60)
        {
            int remainder = grade % 10;
            if (remainder >= 7)
            {
                siGn= "+";

            }
            else if (remainder <3)
            {
                siGn="-";
            }

        }

        if (grade >= 90 )
        {
            letter= "A";
        }
        else if (grade >= 80)
        {
            letter= "B";
        }
        else if (grade >= 70)
        {
            letter= "C";
        }
        else if (grade >= 60)
        {
            letter= "D";
        }
        else
        {
            letter= "F";
        }


        Console.WriteLine($"Your grade is {letter} {siGn}");

        if (grade >=70)
        {
            Console.WriteLine("Congratulations, You passed!");
        }
        else
        {
            Console.WriteLine("Don't be discouraged, Better luck next time!");
        }

    }
}