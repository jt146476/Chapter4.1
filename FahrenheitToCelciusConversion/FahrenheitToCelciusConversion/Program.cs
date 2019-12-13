using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitToCelciusConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry8;
            int userEntry12;
            int userEntry5;

            Console.WriteLine("Temperature in faherheit is 8 P.M.");
            userEntry8 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Temperature in faherheit is 12 P.M.");
            userEntry12 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Temperature in faherheit is 5 P.M.");
            userEntry5 = Convert.ToInt32(Console.ReadLine());

            if (userEntry8 <= 32 || userEntry12 <= 32 || userEntry5 <= 32)
            {
                Console.WriteLine("it is freezing");
            }
            else if (userEntry8 >= 100 || userEntry12 >= 100 || userEntry5 >= 100)
            {
                Console.WriteLine("It is hot.");
            }
        }
    }
}
