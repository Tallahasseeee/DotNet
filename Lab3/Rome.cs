using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3DotNet
{
    class Rome : Civilization
    {
        private static Rome instance;

        public static Rome Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Rome();
                }
                return instance;
            }
        }
    }

    public class RomanWarrior : Warrior
    {
        public RomanWarrior(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
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

    public class RomanWorker : Worker
    {
        public RomanWorker(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
        {

        }
    }

    public class RomanAristocrat : Aristocrat
    {
        public RomanAristocrat(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
        {

        }
    }
}
