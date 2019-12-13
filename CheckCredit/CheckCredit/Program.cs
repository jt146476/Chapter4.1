using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;

            Console.WriteLine("Enter a purchase price for an item");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry > 5000)
            {
                Console.WriteLine("The purchase price " + userEntry + " is greater than allowed");
            }
            else
            {
                Console.WriteLine("The purchase price is improved" + userEntry);
            }

        }
    }
}
