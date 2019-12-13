using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {



            Random rnd = new Random();
            int ai = rnd.Next(1, 3);
            int userEntry;
            int wins = 0;
            bool again = true;

            Console.WriteLine("Welcome to Rock Paper Scissors ");
            Console.WriteLine("######################################");
            Console.WriteLine("Enter the following numbers to play: " +
                "/n - Rock /n2 - Scissors /n3 - Paper");
            userEntry = Convert.ToInt32(Console.ReadLine());

            while (again)
            {


                if (ai == 1)
                {
                    if (userEntry == 1)
                    {
                        Console.WriteLine("Tie");
                    }
                    else if (userEntry == 2)
                    {
                        Console.WriteLine("You Lost");
                    }
                    else
                    {
                        Console.WriteLine("You won!!!");
                        wins = wins + 1;
                    }
                }
                else if (ai == 2)
                {
                    if (userEntry == 1)
                    {
                        Console.WriteLine("You Win!!!");
                        wins = wins + 1;
                    }
                    else if (userEntry == 2)
                    {
                        Console.WriteLine(" Tie");
                    }
                    else
                    {
                        Console.WriteLine("You Lost");
                    }
                }
                else if (ai == 3)
                {
                    if (userEntry == 1)
                    {
                        Console.WriteLine("You Lost");
                    }
                    else if (userEntry == 2)
                    {
                        Console.WriteLine("You Won!!!");
                        wins = wins + 1;
                    }
                    else
                    {
                        Console.WriteLine("Tie");

                    }

                }
                if (wins == 5)
                {
                    again = false;
                }
                Console.WriteLine("You have won" + wins + "times");
            }
        }
    }
}
