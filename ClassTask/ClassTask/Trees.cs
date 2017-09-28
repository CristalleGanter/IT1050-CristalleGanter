using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    class Tree
    {
       public double numBranches;
        private string color;
        private bool alive;
        private int roots;

        public void Display()
        {
            Console.WriteLine($"Tree:\nnumBranches={numBranches}\ncolor={color}\nalive={alive}");

        }
    }
    
    }

