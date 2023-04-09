using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3DotNet
{
    public class Atlantis : Civilization 
    {
        private static Atlantis instance;

        public static Atlantis Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Atlantis();
                }
                return instance;
            }
        }

    }

    public class AtlanticWarrior : Warrior
    {

        public AtlanticWarrior(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
        {

        }

        public override void SpecificAttack()
        {
            Console.WriteLine($"{Name}: Atlantic attack!");
        }

        public override void SpecificDefend()
        {
            Console.WriteLine($"{Name}: Atlantic defence!");
        }
    }

    public class AtlanticWorker : Worker
    {
        public AtlanticWorker(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
        {

        }
    }

    public class AtlanticAristocrat : Aristocrat
    {
        public AtlanticAristocrat(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
        {

        }
    }
}
