using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = new int[100];
           // for (int i = 0; i < arr1.Length; i++)
               // arr1[i] = i;

            int[] scores = new int[] { 97, 92, 81, 60 };

            Console.WriteLine(scores);

            int a = 1;


            for (; a<= 100; a++)
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

                if (a % 3 == 0 && a % 7 ==0)

                {
                    Console.WriteLine("OnBase");
                }

                


            }

            
           

        }
    }
}
