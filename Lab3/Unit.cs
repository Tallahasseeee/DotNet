using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3DotNet
{
    public interface IUsable
    {
        void Use();
    }
    public class Unit
    {
        public int Size;
        public int Value;

        public Unit(int size, int value)
        {
            Size = size;
            Value = value;
        }

        public virtual void Use() { }
    }

    public class Forest : Unit, IUsable
    {
        public Forest(int size, int value) : base(size,value)
        {

        }
        public override void Use()
        {
            Console.WriteLine("The forest is being used. Wood is being produced.");
        }
    }

    public class Field : Unit, IUsable
    {
        public Field(int size, int value) : base(size, value)
        {

        }
        public override void Use()
        {
            Console.WriteLine("The field is being used. Food is being produced.");
        }
    }

    public class Dwelling : Unit, IUsable
    {
        public Dwelling(int size, int value) : base(size, value)
        {

        }
        public override void Use()
        {
            Console.WriteLine("The dwelling is being used. Individuals are having rest.");
        }
    }

    public class Factory : Unit, IUsable
    {
        public Factory(int size, int value) : base(size, value)
        {

        }
        public override void Use()
        {
            Console.WriteLine("The factory is being used. Things are being produced.");
        }
    }
}
