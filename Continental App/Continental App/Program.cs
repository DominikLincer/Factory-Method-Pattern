using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Continental_App.Continents;

namespace Continental_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Continent[] continents = new Continent[2];

            continents[0] = new Africa();
            continents[1] = new Asia();

            foreach (Continent continent in continents)
            {
                Console.WriteLine(continent.GetType().Name + ":");
                foreach (Animal animal in continent.Animals)
                {
                    Console.WriteLine(" " + animal.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}
