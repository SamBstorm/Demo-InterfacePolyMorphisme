using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfacePolyMorphisme
{
    internal class Aquarium
    {

        public List<Poisson> Poissons { get; set; }
        public List<Algue> Algues { get; set; }

        public Aquarium() {
            Poissons = new List<Poisson>();
            Algues = new List<Algue>();
        }

        public void AjouterPoisson(Poisson poisson)
        {
            Poissons.Add(poisson);
            poisson.Aquarium = this;
        }
        public void AjouterAlgue(Algue algue)
        {
            Algues.Add(algue);
        }
    }
}
