using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FishingApp
{
    class GameEngine
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();


        public Fish CatchFish()
        {
            int r = GetRandomNumber();

            //create a fish object to return;
            Fish fish = new Fish();

            if (r == 1) // Bass and 10 points
            {
                fish.FishType = "Bass";
                fish.Points = 10;
            }
            else if (r == 2) //
            {
                fish.FishType = "Perch";
                fish.Points = 2;
            }
            else if (r == 3)
            {
                fish.FishType = "Walleye";
                fish.Points = 20;
            }
            else if (r == 4)
            {
                fish.FishType = "Sunfish";
                fish.Points = 5;
            }
            else if (r == 5)
            {
                fish.FishType = "Pike";
                fish.Points = 30;
            }
            else
            {
                fish.FishType = "NO FISH!";
                fish.Points = 0;
            }



            return fish;
        }

        public static int GetRandomNumber()
        {
            Random randomNum = new Random();
            //lock (syncLock)
            //{ // synchronize
            //    return random.Next(1, 8);
            //}
            Thread.Sleep(1000);
            int i = randomNum.Next(1, 8);
            return i;
        }
    }
}
