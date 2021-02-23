using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNbr = rand.Next(1, 3); //generate random number between 1 and 2
            int guess = 0;
            int coin;
            const string developer = "Alex Upton";

            Console.WriteLine("Please pick heads or tails user");
            string answer = Console.ReadLine();

            Console.WriteLine(randomNbr); // 1=heads 2=tails
           

            if (answer == "heads")
               
            {
                guess = 1;
            }
            else if (answer == "tails")
            {
                guess = 2;
            }

            if (randomNbr == 1)
            {
                coin = 1;
                Console.WriteLine("Heads");
            }
            else
            {
                coin = 2;
                Console.WriteLine("Tails");
            }

            if (guess == coin)
            {
                Console.WriteLine("You have guessed correctly!");
            }
            else
            {
                Console.WriteLine("Too bad, try again.");
            }
            Console.WriteLine("developer " + developer);

           

            


        }
    }
}
