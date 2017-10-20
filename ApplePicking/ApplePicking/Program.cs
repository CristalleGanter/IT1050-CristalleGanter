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
            Console.WriteLine("Welcome to the apple farm!");
            Console.WriteLine("\n    ~~~~~~ \n   (      ) \n  (        )\n  (        )\n   (      )\n     |  |\n     |  |\n     |  |\n     |  |");
            Console.WriteLine("\n    ~~~~~    \n  (       ) \n (         )\n (         )\n  ~~~~~~~~~\n  ~~~~~~~~~\n  ~~~~~~~~~\n  ~~~~~~~~~");

            int app = 0;
            Console.WriteLine("You have {0} apples.", app);
            Console.WriteLine("\nWould you like to pick apples?");
            string ans;
            ans = Console.ReadLine();

            if (ans == "y")
            { app++; Console.WriteLine("You have {0} apple.", app); }

            if (ans == "n")
            { Console.WriteLine("You have {0} apples.", app); }

            Console.WriteLine("Would you like to pick apples?");
            string ans2;
            ans2 = Console.ReadLine();

            if (ans2 == "y")
            { app++; Console.WriteLine("You have {0} apples.", app); }

            if (ans2 == "n")
            { Console.WriteLine("You have {0} apples.", app); }

        }
    }
}
