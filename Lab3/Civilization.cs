using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3DotNet
{
    public class Civilization
    {
        private List<Individual> _individuals = new List<Individual>();
        private List<Land> _lands = new List<Land>();

        public List<Land> Lands => _lands;
        public List<Individual> Individuals => _individuals;
        public void AddIndividual(Individual individual)
        {
            _individuals.Add(individual);
        }

        public void AddLand(Land land)
        {
            _lands.Add(land);
        }

    }
}
