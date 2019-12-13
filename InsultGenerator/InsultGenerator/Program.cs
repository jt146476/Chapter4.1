using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterAge;
            string result = null;
            Console.WriteLine("Please enter an age so I can make fun of you!");
            Console.WriteLine("If you call me a boomer you might die of old age.");
            enterAge = Convert.ToInt32(Console.ReadLine());

            if (enterAge <= 12)
            {
                result = "You are just a young punk.";
            }
            else if (enterAge > 12 && enterAge <= 17)
            {
                result = "Your generation is the problem";
            }
            else if (enterAge > 17 && enterAge <= 25)
            {
                result = "Get a job and pay some taxes hippie!";
            }
            else if (enterAge > 18 && enterAge < 25)
            {
                result = "Wow you got a job finally.";
            }
            else if (enterAge > 26 && enterAge < 35)
            {
                result = "Do you even know how to pay your bills?";
            }
            else if (enterAge > 36 && enterAge < 45)
            {
                result = "You've gotten a lot skinnier from the last time I saw you.";
            }
            else if (enterAge > 45 && enterAge < 54)
            {
                result = "Oh man, getting older by the second huh?";
            }
            else if (enterAge > 55 && enterAge < 62)
            {
                result = "Dang old man, you're hardly standing";
            }
            else if (enterAge > 62 && enterAge < 73)
            {
                result = "You can't even get up to go to the bathroom.";
            }
            //Enter the other age groups below this 



            //Do not type below this Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}
