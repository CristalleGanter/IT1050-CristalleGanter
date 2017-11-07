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
                Console.WriteLine("{0}",y); if (y != 1) { Console.WriteLine(","); }
                
            }











        }
    }
}
