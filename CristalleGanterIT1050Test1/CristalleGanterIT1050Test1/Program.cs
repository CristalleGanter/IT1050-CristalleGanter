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

            Console.WriteLine("/n");

            // number 4

            int i = 1;
            while (i!=23)
            {
                Console.Write("{0}   ",i);
                i = i + 2;
            }

            // number 5

            // number 7

            for (int l=1; l<=6; l++)
            
            {
                for (int c=1;c<l;c++)
                { Console.Write(" "); }

                for (int a = 1; a <= 5; a++)
                { Console.Write("{0}",a);
                    
                }
                for (int b = 4; b >=1; b--)
                { Console.Write("{0}", b); }
                Console.WriteLine();
            }





        }
    }
}
