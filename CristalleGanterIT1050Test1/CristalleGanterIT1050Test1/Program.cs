using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CristalleGanterIT1050Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            // number 1




            // number 2
            int x = 0;
            int counter = 0;
            while (x != 128)

            {
                counter++;
                x = x + 2;

                Console.WriteLine("[{0}]\n",x);
                Console.WriteLine(counter);
            }
            Console.WriteLine("\n");

            // number 3

            for (int y = 49; y >= 1; y--)
            {
                Console.Write("{0}",y); if (y != 1) { Console.Write(","); }
                
            }

            Console.WriteLine("\n");

            // number 4

            int i = 1;
            while (i!=23)
            {
                Console.Write("{0}   ",i);
                i = i + 2;
            }
            Console.WriteLine("\n");
            // number 5

            Console.WriteLine("\n");
            // number 6
            bool icyRain = false;
            bool tornadoWarning = false;

            if (icyRain&&tornadoWarning)
            { Console.WriteLine("Let's stay inside!"); }
            else
            { Console.WriteLine("Let's go outside!"); }

            Console.WriteLine("\n");
            // number 7

            for (int l=5; l>=1; l--)
            
            {
                for (int c=5;c>l;c--)
                { Console.Write(" "); }
               
                for (int a = 1; a <= l; a++)
                { Console.Write(a);
                   
                }

                for (int b = 1; b <l; b++)
                { Console.Write(b); }




                Console.WriteLine();
            }


           

        }
    }
}
