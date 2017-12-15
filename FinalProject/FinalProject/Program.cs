using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero("Sesshoumaru", "Inuyasha","dog demon", "strength, speed, magic sword, demon dog transformation", true);
            Hero myOtherHero = new Hero("Flash", "Zoom", "Human", "Speed", true);
            Hero thirdHero = new Hero("Wonder Woman", "All bad people", "Amazonian", "Stength, Speed, Fly");

            myHero.PowerLevel = 49;
            myOtherHero.PowerLevel = 49;
            thirdHero.PowerLevel = 49;

            /*
                Problem 7:
                Each Hero must:
                 - ChargePower (as much as you want)
                 - Investigate
                 - FightCrime (at least one must win. at least one must not win)
                 - Fly (at least one superhero should be able to fly)
                 - Climb
            */

            myHero.ChargePower(50);
            myOtherHero.ChargePower(50);
            thirdHero.ChargePower();

            myHero.Investigate();
            myOtherHero.Investigate();
            thirdHero.Investigate();


            myHero.FightCrime("Somewhere in Japan");
            myOtherHero.FightCrime("123 Justice Avenue");
            thirdHero.FightCrime("555 Crime Alley");


            myHero.Fly();
            myOtherHero.Fly();
            thirdHero.Fly();


            myHero.Climb(50);
            myOtherHero.Climb(20);
            thirdHero.Climb(25);



        }
    }
}
