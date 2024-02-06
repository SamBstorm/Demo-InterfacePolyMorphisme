using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfacePolyMorphisme
{
    internal class Poisson : ICarnivore, IHerbivore
    {
        public string Name { get; set; }

        public RacePoisson Race { get; set; }
        public Aquarium Aquarium { get; set; }

        public Poisson(string name, RacePoisson race)
        {
            Name = name;
            Race = race;
        }

        public void MangerPoisson()
        {
            Random RNG = new Random();
            Poisson poisson = Aquarium.Poissons[RNG.Next(0, Aquarium.Poissons.Count)];
            if(poisson == this)
            {
                Console.WriteLine($"Quel con ce {Name}, il a voula se manger lui-même...");
            }
            else
            {
                Console.WriteLine($"Miam! Miam! {poisson.Name} était délicieux.");
                Aquarium.Poissons.Remove(poisson);
            }
        }


        public void MangerAlgue()
        {
            Random RNG = new Random();
            Algue algue = Aquarium.Algues[RNG.Next(0, Aquarium.Algues.Count)];
            Console.WriteLine($"Miam! Miam! Cette algue était délicieuse.");
            Aquarium.Algues.Remove(algue);
        }
    }
}
