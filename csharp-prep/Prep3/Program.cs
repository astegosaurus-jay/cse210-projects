using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("what is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (magicNumber > guess)
            {
                Console.WriteLine("higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine("you guessed the number");
            }
        }


    }
}