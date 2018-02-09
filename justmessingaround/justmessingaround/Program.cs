using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justmessingaround
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;


            for (; a <= 100; a++)
            {
                Console.WriteLine(a);




                if (a % 3 == 0)

                {

                    Console.WriteLine("On");



                }
                if (a % 7 == 0)

                {
                    Console.WriteLine("Base");
                }

                if (a % 3 == 0 && a % 7 == 0)

                {
                    Console.WriteLine("OnBase");
                }


                int[] integers = new int[999];
                for (int i = 1; i < 999; i++)
                {
                    i++;

                    Console.WriteLine(integers);
                }

            }
            }
    }
}
