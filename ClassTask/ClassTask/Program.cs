using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    class Program
    {
        public static string orange;

        static void Main(string[] args)
        {
            Tree Maple = new Tree();
            Maple.numBranches = 25;
            Maple.color = orange;
            Maple.Display();

            Tree Plum = new Tree();
        }
    }
}
