using System;

namespace Lab3DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            HyperboreanFactory HyperboreanFactory = new HyperboreanFactory();
            RomanFactory RomanFactory = new RomanFactory();
            SpartanFactory SpartanFactory = new SpartanFactory();

            Hyperborea.Instance.AddIndividual((Individual)HyperboreanFactory.CreateWarrior("Erik"));
            Hyperborea.Instance.AddIndividual((Individual)HyperboreanFactory.CreateWarrior("Bjørn"));
            Hyperborea.Instance.AddIndividual((Individual)HyperboreanFactory.CreateWarrior("Arne"));
            Hyperborea.Instance.AddIndividual((Individual)HyperboreanFactory.CreateWorker("Halfdan"));
            Hyperborea.Instance.AddIndividual((Individual)HyperboreanFactory.CreateWorker("Njal"));
            Hyperborea.Instance.AddIndividual((Individual)HyperboreanFactory.CreateWorker("Sten"));
            Hyperborea.Instance.AddIndividual((Individual)HyperboreanFactory.CreateAristocrat("Harald"));
            Hyperborea.Instance.AddIndividual((Individual)HyperboreanFactory.CreateAristocrat("Ødger"));
            Hyperborea.Instance.AddIndividual((Individual)HyperboreanFactory.CreateAristocrat("Ulf"));

            Hyperborea.Instance.AddLand(new Land("Aebeltoft"));
            Hyperborea.Instance.AddLand(new Land("Ravndal"));
            Hyperborea.Instance.AddLand(new Land("Sandvik"));

            Hyperborea.Instance.Lands[0].AddUnit(new Forest(10,10));
            Hyperborea.Instance.Lands[0].AddUnit(new Field(20, 5));
            Hyperborea.Instance.Lands[0].AddUnit(new Dwelling(5, 10));

            Hyperborea.Instance.Lands[1].AddUnit(new Forest(30, 50));
            Hyperborea.Instance.Lands[1].AddUnit(new Field(50, 30));
            Hyperborea.Instance.Lands[1].AddUnit(new Dwelling(10, 20));
            Hyperborea.Instance.Lands[1].AddUnit(new Factory(5, 100));

            Hyperborea.Instance.Lands[2].AddUnit(new Forest(10, 15));
            Hyperborea.Instance.Lands[2].AddUnit(new Forest(20, 25));
            Hyperborea.Instance.Lands[2].AddUnit(new Field(20, 15));

            Rome.Instance.AddIndividual((Individual)RomanFactory.CreateWarrior("Lucius"));
            Rome.Instance.AddIndividual((Individual)RomanFactory.CreateWarrior("Severus"));
            Rome.Instance.AddIndividual((Individual)RomanFactory.CreateWarrior("Marcus"));
            Rome.Instance.AddIndividual((Individual)RomanFactory.CreateWorker("Tiberius"));
            Rome.Instance.AddIndividual((Individual)RomanFactory.CreateWorker("Quintus"));
            Rome.Instance.AddIndividual((Individual)RomanFactory.CreateWorker("Publius"));
            Rome.Instance.AddIndividual((Individual)RomanFactory.CreateAristocrat("Albus"));
            Rome.Instance.AddIndividual((Individual)RomanFactory.CreateAristocrat("Atticus"));
            Rome.Instance.AddIndividual((Individual)RomanFactory.CreateAristocrat("Caesar"));

            Rome.Instance.AddLand(new Land("Gallia"));
            Rome.Instance.AddLand(new Land("Italia"));
            Rome.Instance.AddLand(new Land("Britannia"));

            Rome.Instance.Lands[0].AddUnit(new Forest(10, 10));
            Rome.Instance.Lands[0].AddUnit(new Field(30, 10));
            Rome.Instance.Lands[0].AddUnit(new Dwelling(20, 40));

            Rome.Instance.Lands[1].AddUnit(new Forest(30, 50));
            Rome.Instance.Lands[1].AddUnit(new Field(50, 30));
            Rome.Instance.Lands[1].AddUnit(new Dwelling(10, 20));
            Rome.Instance.Lands[1].AddUnit(new Factory(5, 100));

            Rome.Instance.Lands[2].AddUnit(new Forest(15, 20));
            Rome.Instance.Lands[2].AddUnit(new Forest(20, 30));
            Rome.Instance.Lands[2].AddUnit(new Field(30, 50));

            Sparta.Instance.AddIndividual((Individual)SpartanFactory.CreateWarrior("Achilles"));
            Sparta.Instance.AddIndividual((Individual)SpartanFactory.CreateWarrior("Ares"));
            Sparta.Instance.AddIndividual((Individual)SpartanFactory.CreateWarrior("Hercules"));
            Sparta.Instance.AddIndividual((Individual)SpartanFactory.CreateWorker("Orpheus"));
            Sparta.Instance.AddIndividual((Individual)SpartanFactory.CreateWorker("Hector"));
            Sparta.Instance.AddIndividual((Individual)SpartanFactory.CreateWorker("Alpheus"));
            Sparta.Instance.AddIndividual((Individual)SpartanFactory.CreateAristocrat("Aragorn"));
            Sparta.Instance.AddIndividual((Individual)SpartanFactory.CreateAristocrat("Perseus"));
            Sparta.Instance.AddIndividual((Individual)SpartanFactory.CreateAristocrat("Leonidas"));

            Sparta.Instance.AddLand(new Land("Arcadia"));
            Sparta.Instance.AddLand(new Land("Laconia"));
            Sparta.Instance.AddLand(new Land("Achaea"));

            Sparta.Instance.Lands[0].AddUnit(new Forest(30, 50));
            Sparta.Instance.Lands[0].AddUnit(new Field(50, 50));
            Sparta.Instance.Lands[0].AddUnit(new Dwelling(15, 40));

            Sparta.Instance.Lands[1].AddUnit(new Forest(30, 50));
            Sparta.Instance.Lands[1].AddUnit(new Field(50, 30));
            Sparta.Instance.Lands[1].AddUnit(new Dwelling(10, 20));
            Sparta.Instance.Lands[1].AddUnit(new Factory(5, 100));

            Sparta.Instance.Lands[2].AddUnit(new Forest(10, 20));
            Sparta.Instance.Lands[2].AddUnit(new Dwelling(20, 50));
            Sparta.Instance.Lands[2].AddUnit(new Field(30, 50));

            ((Warrior)Hyperborea.Instance.Individuals[0]).Attack(Rome.Instance.Individuals[3]);
            ((Warrior)Hyperborea.Instance.Individuals[1]).Attack(Rome.Instance.Individuals[5]);
            ((Warrior)Hyperborea.Instance.Individuals[2]).Attack(Rome.Instance.Individuals[7]);
            ((Warrior)Hyperborea.Instance.Individuals[0]).Attack(Rome.Instance.Individuals[6]);
            ((Warrior)Hyperborea.Instance.Individuals[1]).Attack(Rome.Instance.Individuals[4]);

            ((Warrior)Rome.Instance.Individuals[0]).Defend(Rome.Instance.Individuals[3]);
            ((Warrior)Rome.Instance.Individuals[1]).Defend(Rome.Instance.Individuals[5]);
            ((Warrior)Rome.Instance.Individuals[2]).Defend(Rome.Instance.Individuals[7]);
            ((Warrior)Rome.Instance.Individuals[0]).Defend(Rome.Instance.Individuals[6]);
            ((Warrior)Rome.Instance.Individuals[1]).Defend(Rome.Instance.Individuals[4]);

            ((Warrior)Rome.Instance.Individuals[0]).Attack(Hyperborea.Instance.Individuals[0]);
            ((Warrior)Rome.Instance.Individuals[1]).Attack(Hyperborea.Instance.Individuals[1]);
            ((Warrior)Rome.Instance.Individuals[2]).Attack(Hyperborea.Instance.Individuals[2]);

            ((Warrior)Sparta.Instance.Individuals[0]).Defend(Rome.Instance.Individuals[0]);
            ((Warrior)Sparta.Instance.Individuals[1]).Defend(Rome.Instance.Individuals[1]);
            ((Warrior)Sparta.Instance.Individuals[2]).Defend(Rome.Instance.Individuals[2]);

            ((Warrior)Sparta.Instance.Individuals[0]).Attack(Hyperborea.Instance.Lands[0]);
            ((Warrior)Sparta.Instance.Individuals[1]).Attack(Hyperborea.Instance.Lands[1]);
            ((Warrior)Sparta.Instance.Individuals[2]).Attack(Hyperborea.Instance.Lands[2]);

            ((Warrior)Hyperborea.Instance.Individuals[0]).Defend(Hyperborea.Instance.Lands[0]);
            ((Warrior)Hyperborea.Instance.Individuals[1]).Defend(Hyperborea.Instance.Lands[1]);
            ((Warrior)Hyperborea.Instance.Individuals[2]).Defend(Hyperborea.Instance.Lands[2]);

            Rome.Instance.Lands[0].Units[0].Use();
            Rome.Instance.Lands[0].Units[1].Use();
            Rome.Instance.Lands[2].Units[2].Use();

            Hyperborea.Instance.Lands[1].Units[0].Use();
            Hyperborea.Instance.Lands[1].Units[1].Use();
            Hyperborea.Instance.Lands[1].Units[2].Use();
            Hyperborea.Instance.Lands[1].Units[3].Use();

            Sparta.Instance.Lands[0].Units[0].Use();
            Sparta.Instance.Lands[1].Units[1].Use();
            Sparta.Instance.Lands[2].Units[2].Use();
        }
    }
}
