using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemudvikling

{
    public class Sofie
    {
        public Sofie(string name, int age, int energyDrinkPrDay)
        {
            Name = name;
            Age = age;
            EmnergyDrinkPrDay = energyDrinkPrDay;
        }
        public string Name;
        public int Age;
        public int EmnergyDrinkPrDay;

        public string Snakker(string altid)
        {
            Console.WriteLine("snakker 99% af tiden");
            return altid;
        }

    }

}
