using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick heads or tails user");
            String 


            Random rand = new Random();
            int randomNbr = rand.Next(1, 3); //generate random number between 1 and 2

            Console.WriteLine(randomNbr);

            


        }
    }
}
