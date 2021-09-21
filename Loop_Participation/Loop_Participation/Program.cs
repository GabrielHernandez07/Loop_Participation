using System;

namespace Loop_Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            int minimum, maximum, guessNumber;
            
            Console.WriteLine("Random number simulator");
            Console.WriteLine("Please pick a minimum value for the range. >>");
            string min = Console.ReadLine();
            minimum = Convert.ToInt32(min);

            Console.WriteLine("Please pick a maximum value for the rangs. >>");
            string max = Console.ReadLine();
            maximum = Convert.ToInt32(max);

            Random rand = new Random();
            double randValue = rand.Next(minimum, maximum + 1);

            Console.WriteLine("Guess the random value within your range. >>");
            string guess = Console.ReadLine();
            guessNumber = Convert.ToInt32(guess);

            while (guessNumber != randValue)
            {
                if (guessNumber > randValue)
                {
                    Console.WriteLine("Guessed too high.");
                }
                else
                {
                    Console.WriteLine("Guessed too low.");
                }
                Console.WriteLine("Guessed Incorrectly. Guess agian.");
                string newguess = Console.ReadLine();
                guessNumber = Convert.ToInt32(newguess);
            }
            Console.WriteLine("Congrats you guessed correctly");
        }
    }
}
