﻿using System;
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



        public Car(string make, string model, int year, int speed)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Speed = speed;

        }

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            Speed = 0;

        }





    }
}
