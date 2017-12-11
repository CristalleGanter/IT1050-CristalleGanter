using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanterLab13
{
    class Car
    {
        private int Speed;
        private string Make;
        private string Model;
        private int Year;



        public Car(string make, string model, int year, int Speed)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Speed = Speed;

        }

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Speed = 0;

        }


        public int SpeedUp()
        {if (Speed == 0)
            {Speed++; }
                return Speed;
               }
        
        public int   SlowDown()
        {if (Speed>0)
            {Speed--; }
       
            return Speed;
                    }

        public void Display()
        {
            Console.WriteLine(Year + " " + Make + " " + Model + " is going " + Speed + " MPH.");
        }


    }
}
