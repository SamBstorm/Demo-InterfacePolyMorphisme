namespace Demo_InterfacePolyMorphisme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aquarium aqua = new Aquarium();

            Poisson p1 = new Poisson("Ibrahim", RacePoisson.Clown); 
            Poisson p2 = new Poisson("Sam", RacePoisson.Merou);
            Poisson p3 = new Poisson("Arthur", RacePoisson.Thon);

            Algue a1 = new Algue();
            Algue a2 = new Algue();
            Algue a3 = new Algue();

            aqua.AjouterPoisson(p1);
            aqua.AjouterPoisson(p2);
            aqua.AjouterPoisson(p3);

            aqua.AjouterAlgue(a1);
            aqua.AjouterAlgue(a2);
            aqua.AjouterAlgue(a3);

            for (int i = 0; i < aqua.Poissons.Count; i++)
            {
                Poisson p = aqua.Poissons[i];
                switch (p.Race)
                {
                    case RacePoisson.Thon:
                    case RacePoisson.Clown:
                        ICarnivore carnivore = p;
                        carnivore.MangerPoisson();
                    break;
                    case RacePoisson.Merou:
                        IHerbivore herbivore = p;
                        herbivore.MangerAlgue();
                    break;
                }
            }
        }
    }
}
