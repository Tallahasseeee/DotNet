using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3DotNet
{
    class Hyperborea : Civilization
    {
        private static Hyperborea instance;

        public static Hyperborea Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Hyperborea();
                }
                return instance;
            }
        }
    }

    public class HyperboreanWarrior : Warrior
    {
        public HyperboreanWarrior(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
        {

        }
        public override void SpecificAttack()
        {
            Console.WriteLine($"{Name}: Massacre!");
        }

        public override void SpecificDefend()
        {
            Console.WriteLine($"{Name}: Massacre!");
        }
    }

    public class HyperboreanWorker : Worker
    {
        public HyperboreanWorker(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
        {

        }
    }

    public class HyperboreanAristocrat : Aristocrat
    {
        public HyperboreanAristocrat(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
        {

        }
    }
}
