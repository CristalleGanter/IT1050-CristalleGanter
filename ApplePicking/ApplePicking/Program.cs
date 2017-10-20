using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplePicking
{
    class Program
    {
        static void Main(string[] args)
        {
            int app = 0;
            Console.WriteLine("You have {0} apples.", app);
            Console.WriteLine("\n Would you like to pick apples?");
            string ans;
            ans = Console.ReadLine();

            if (ans == "y")
            { app++; Console.WriteLine("You have {0} apple.", app); }

            if (ans == "n")
            { Console.WriteLine("You have {0} apples.", app); }


        }
    }
}
