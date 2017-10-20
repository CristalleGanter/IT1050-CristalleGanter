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
            Console.WriteLine("Welcome to the Apple Farm!");
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
            { Console.WriteLine("You still have {0} apples.", app); }

            Console.WriteLine("Would you like to pick apples?");
            string ans2;
            ans2 = Console.ReadLine();

            if (ans2 == "y")
            { app++; Console.WriteLine("You have {0} apples.", app); }

            if (ans2 == "n")
            { Console.WriteLine("You still have {0} apples.", app); }

            while (app < 10)
            {
                Console.WriteLine("Would you like to pick apples?");
                string ans3;
                ans3 = Console.ReadLine();

                if (ans3 == "y")
                { app++; Console.WriteLine("You have {0} apples.", app); }

                if (ans3 == "n")
                { Console.WriteLine("You still have {0} apples.", app); }
            }
            if (app>=10)
            { Console.WriteLine("Your basket is full.");
                Console.WriteLine("Would you like to make pie?");
                string pie;
                pie = Console.ReadLine();

                if (pie == "y")
                { app=0; Console.WriteLine("You have {0} apples and 1 pie.", app);
                    Console.WriteLine("  S    S    S\n  S    S    S \n  \n  ~~~~~~~~~~~\n (###########)\n  \\_________/");
                }

                if (pie == "n")
                { Console.WriteLine("Your basket is full."); }



            }
            


        }
    }
}
