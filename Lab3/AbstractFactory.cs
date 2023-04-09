using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3DotNet
{
    public interface ICivilizationFactory
    {
        IWarrior CreateWarrior(string name);
        IWorker CreateWorker(string name);
        IAristocrat CreateAristocrat(string name);
    }

    public class AtlanticFactory : ICivilizationFactory
    {
        public IWarrior CreateWarrior(string name)
        {
            return new AtlanticWarrior(name,10,10,2,2);
        }

        public IWorker CreateWorker(string name)
        {
            return new AtlanticWorker(name, 7, 2, 2, 10);
        }

        public IAristocrat CreateAristocrat(string name)
        {
            return new AtlanticAristocrat(name, 7, 5, 10, 2);
        }
    }

    public class HyperboreanFactory : ICivilizationFactory
    {
        public IWarrior CreateWarrior(string name)
        {
            return new HyperboreanWarrior(name, 15, 20, 2, 2);
        }

        public IWorker CreateWorker(string name)
        {
            return new HyperboreanWorker(name, 7, 5, 2, 10);
        }

        public IAristocrat CreateAristocrat(string name)
        {
            return new HyperboreanAristocrat(name, 10, 10, 15, 3);
        }
    }

    public class RomanFactory : ICivilizationFactory
    {
        public IWarrior CreateWarrior(string name)
        {
            return new RomanWarrior(name, 15, 15, 5, 3);
        }

        public IWorker CreateWorker(string name)
        {
            return new RomanWorker(name, 7, 4, 3, 10);
        }

        public IAristocrat CreateAristocrat(string name)
        {
            return new RomanAristocrat(name, 10, 8, 20, 3);
        }
    }

    public class SpartanFactory : ICivilizationFactory
    {
        public IWarrior CreateWarrior(string name)
        {
            return new SpartanWarrior(name, 15, 20, 8, 3);
        }

        public IWorker CreateWorker(string name)
        {
            return new SpartanWorker(name, 10, 8, 3, 10);
        }

        public IAristocrat CreateAristocrat(string name)
        {
            return new SpartanAristocrat(name, 10, 8, 10, 3);
        }
    }

}
