using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {

            int product = MyMath.Multiply(7, 7);
            { Console.WriteLine(product); }

            int quotient = MyMath.Divide (24, 7);
            { Console.WriteLine(quotient); }

            MyMath mathObj1 = new MyMath();
            int sum = mathObj1.Add(3,4);
            { Console.WriteLine(sum); }

            MyMath mathObj2 = new MyMath();
            int difference = mathObj2.Subtract (3, 4);
            { Console.WriteLine(difference); }


        }
    }
}
