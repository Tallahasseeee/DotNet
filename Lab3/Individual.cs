using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3DotNet
{
    public interface IAttackable
    {
        void ReceiveAttack();
    }
    public interface IIndividual
    {
        void Upgrade();
    }
    public class Individual : IAttackable
    {
        public string Name;
        public int Health;
        public int Power;
        public int Authority;
        public int Performance;

        public Individual(string name, int health, int power, int authority, int performance)
        {
            Name = name;
            Health = health;
            Power = power;
            Authority = authority;
            Performance = performance;
        }
        public void ReceiveAttack()
        {
            Console.WriteLine($"{Name} is under attack");
        }
    }

    public interface IWarrior
    {
        void Attack(IAttackable target);
        void Defend(IAttackable target);
        void Train();
    }

    public interface IWorker
    {
        void Work();
    }

    public interface IAristocrat
    {
        void Rule();
    }

    

    public class Warrior : Individual, IWarrior, IIndividual
    {
        public Warrior(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
        {

        }

        public void Upgrade()
        {
            Health += 3;
            Power += 8;
            Authority += 1;
            Performance += 1;
        }

        public void Attack(IAttackable target)
        {
            Console.WriteLine("\n");
            if (target is Individual)
            {
                Individual IndividualTarget = (Individual)target;
                Console.WriteLine($"{Name} is attacking {IndividualTarget.Name}");
                SpecificAttack();

            }
            else if (target is Land)
            {
                Land LandTarget = (Land)target;
                Console.WriteLine($"{Name} is attacking {LandTarget.Name}");
                SpecificAttack();
            }
            target.ReceiveAttack();
            Console.WriteLine("\n");
        }
        public void Defend(IAttackable target)
        {
            Console.WriteLine("\n");
            if (target is Individual)
            {
                Individual IndividualTarget = (Individual)target;
                Console.WriteLine($"{Name} is defending {IndividualTarget.Name}");
                SpecificDefend();
            }
            else if (target is Land)
            {
                Land LandTarget = (Land)target;
                Console.WriteLine($"{Name} is defending {LandTarget.Name}");
                SpecificDefend();
            }
            Console.WriteLine("\n");
        }
        public void Train()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{Name} is raining");
            Console.WriteLine("\n");
        }
        public virtual void SpecificAttack() { }
        public virtual void SpecificDefend() { }
    }

    public class Worker : Individual, IWorker, IIndividual
    {
        public Worker(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
        {

        }
        public void Upgrade()
        {
            Health += 2;
            Power += 2;
            Authority += 2;
            Performance += 8;
        }
        public void Work()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{Name} is Working");
            Console.WriteLine("\n");
        }

    }

    public class Aristocrat : Individual, IAristocrat, IIndividual
    {
        public Aristocrat(string name, int health, int power, int authority, int performance) : base(name, health, power, authority, performance)
        {

        }
        public void Upgrade()
        {
            Health += 3;
            Power += 4;
            Authority += 8;
            Performance += 1;
        }
        public void Rule()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{Name} is Ruling");
            Console.WriteLine("\n");
        }
    }
}
