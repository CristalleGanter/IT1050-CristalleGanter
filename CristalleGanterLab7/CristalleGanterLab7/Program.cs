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
            int n = 1;
            Console.WriteLine(n);

            while (n < 9)
            { Console.WriteLine(n + 2); n = n + 2; }

            int i = 30;
            for (i = 30; i <= 45; i++)
            { Console.WriteLine(i); }

            int t = 17;
            if (t <= 11)
            { Console.WriteLine("Good Morning"); }

            if (t >= 12 && t <= 16)
            { Console.WriteLine("Good Afternoon"); }

            if (t > 16)
            { Console.WriteLine("Good Evening"); }

            // There was no part where anything was added to the initial number so it just kept putting out 10.
            int x = 10;
            while (x < 21)
            {
                Console.WriteLine(x++);
            }

            for (int k=1; k<=10;k++)
            {
                for (int j =1; j<=k;j++)
                { Console.Write("*"); }
                Console.WriteLine();
            }
          
    


        }

        } 
}
