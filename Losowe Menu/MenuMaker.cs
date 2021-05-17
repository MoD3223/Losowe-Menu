using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Losowe_Menu
{
    class MenuMaker
    {
        public Random Randomizer;


        string[] Meats = { "Pieczona wołowina", "Salami", "Indyk", "Szynka", "Karkówka" };
        string[] Condiments = { "Żółta musztarda", "Brązowa musztarda", "Musztarda miodowa", "Majonez", "Przyprawa", "Sos francuski" };
        string[] Breads = { "Chleb ryżowy", "Chleb biały", "Chleb zbożowy", "Pumpernikiel", "Chleb włoski", "Bułka" };


        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiments = Condiments[Randomizer.Next(Meats.Length)];
            string randomBreads = Breads[Randomizer.Next(Meats.Length)];

            return randomMeat + ", " + randomCondiments + ", " + randomBreads;
        }
    }
}
