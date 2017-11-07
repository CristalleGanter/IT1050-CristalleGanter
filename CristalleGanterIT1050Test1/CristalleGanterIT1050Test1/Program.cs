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
            int x = 0;
            
            while (x != 128)

            {
                int counter = 1;counter++;
                x = x + 2;

                Console.WriteLine("[{0}]\n",x); }
        }
    }
}
