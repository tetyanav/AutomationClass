using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "1")
                message = "You won a car";
            else if (userValue == "2")
                message = "You won a boat";
            else if (userValue == "3")
                message = "You won a cat";
            else
            {
                message = "Wrong input. ";
                message += "Try next time.";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            */

            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "boat" : "pensil";
            Console.WriteLine("You entered {0}, and you won a {1}", userValue, message);
            Console.ReadLine();

            for (int i = 0; i < length; i++)
            {

            }

        }
    }
}
