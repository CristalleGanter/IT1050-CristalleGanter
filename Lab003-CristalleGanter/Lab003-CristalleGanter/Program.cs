using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab003_CristalleGanter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 Numbers Here");
            int a;
            int b;
            int result;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            result = a + b;
            Console.WriteLine("The Solution is " + result);
        }
    }
}
