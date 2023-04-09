using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3DotNet
{
    class Sparta : Civilization 
    {
        private static Sparta instance;

        public static Sparta Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Sparta();
                }
                return instance;
            }
        }
    }

    public class SpartanWarrior : Warrior
    {
        public SpartanWarrior(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
        {

        }
        public override void SpecificAttack()
        {
            Console.WriteLine($"{Name}: Phalanx!");
        }

        public override void SpecificDefend()
        {
            Console.WriteLine($"{Name}: Phalanx!");
        }
    }

    public class SpartanWorker : Worker
    {
        public SpartanWorker(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
        {

        }
    }

    public class SpartanAristocrat : Aristocrat
    {
        public SpartanAristocrat(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
        {

        }
    }
}
