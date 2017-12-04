using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            names[0] = "Al Dente";
            names[1] = "Anna Graham";
            names[2] = "Earle Bird";
            names[3] = "Ginger Rayle";
            names[4] = "Iona Ford";

            Console.WriteLine(names[2]+ names[4]);

            // Question 2

            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(months[i]);
            }






        }

    }
}
