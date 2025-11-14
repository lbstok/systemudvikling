using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace systemudvikling
{
    public class Lasse
    {
        
        public string Name;
        public int Age;

        public Lasse(string name, int age)
        {
            Name = name;
            Age = age; 
        }

        public void PrintLasseStatus()
        {
            Console.WriteLine("Status for Lasse: 99% charme, 1% chance for at hans kode virker første gang.");
        }
    }


    }
}
