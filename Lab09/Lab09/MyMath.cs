using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class MyMath
    {
         
        public int result;
        public double operand1;
        public double operand2;
        

        public int Add(int a, int b)
        {
            operand1 = a;
            operand2 = b;
            result = a + b;
            return result;
        }
        public void DisplayLastOperation()
        {
            Console.WriteLine(operand1 + operand2 + "=" + result);
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

    }
}
