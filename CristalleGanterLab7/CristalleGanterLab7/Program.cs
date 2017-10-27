using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CristalleGanterLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =1;
            Console.WriteLine(n);

            while (n<9)
            { Console.WriteLine(n + 2); n = n + 2; }

            int i = 30;
            for (i = 30; i <= 45; i++)
            { Console.WriteLine(i); }

            int t = 17;
            if (t<=11)
            { Console.WriteLine("Good Morning"); }

            if (t >= 12 && t<=16)
            { Console.WriteLine("Good Afternoon"); }

            if (t>16)
            { Console.WriteLine("Good Evening"); }

            // There was no part where anything was added to the initial number so it just kept putting out 10.
            int x = 10;
            while (x < 21)
            {
                Console.WriteLine(x++);
            }


            for (int c = 0; c < 101; c++)
            {
                Console.WriteLine(c);
                Console.WriteLine("********");
            }

            int p = 1;
            for (p = 1; p <= 1; p++)
            { Console.Write("*");
                Console.WriteLine();

                for (int q =1; q<2;q++)
                { Console.Write("*");
                    

                    for (int m = 1; m <2; m++)
                    {
                        Console.Write("*");
                        Console.WriteLine();

                        for (int z = 1; z <2; z++)
                        {
                            Console.Write("*");
                           
                            for (int v = 1; v <=2; v++)
                            {
                                Console.Write("*");

                            }
                            
                        }

                    }


                }

            }
              
           
        }
    }
}
