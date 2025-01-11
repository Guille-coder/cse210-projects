using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magicnumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 101);

        int guess = -1;

    while (guess != magicnumber)
        {

            Console.Write("What is tour guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicnumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicnumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}