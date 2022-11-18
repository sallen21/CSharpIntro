// See https://aka.ms/new-console-template for more information
using System;

namespace newApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSunny = true;
            Console.WriteLine(isSunny);

            string wear;
            wear = "Wear sunglasses!";

            string dontWear;
            dontWear = "You don't have to wear sunglasses!";

            if (isSunny == false)
            {
                Console.WriteLine(wear);
            }
            else 
            {
                Console.WriteLine(dontWear);
            }
            bool atBeach = true;
            Console.WriteLine(atBeach);

            string sunblock;
            sunblock = "Sunblock is a good idea.";

            string noSunblock;
            noSunblock = "Sunblock isn't needed.";

            if (atBeach == true)
            {
                Console.WriteLine(sunblock);
            }
            else {
                Console.WriteLine(noSunblock);
            }

            bool goAnyway = true;
            
            string going;
            going = "Awesome! Glad you don't mind clouds!";

            string nextTime;
            nextTime = "No worries! Hopefully next time we will have some sun!";

            if (goAnyway == true)
            {
                Console.WriteLine(going);
            }
            else {
                Console.WriteLine(nextTime);
            }


        }
    }
}