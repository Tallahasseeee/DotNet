using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3DotNet
{
    public class Land : IAttackable
    {
        public string Name;
        private List<Unit> _units = new List<Unit>();

        public List<Unit> Units => _units;
        public Land(string name)
        {
            Name = name;
        }
        public void AddUnit(Unit unit)
        {
            _units.Add(unit);
        }
        public void ReceiveAttack()
        {
            Console.WriteLine($"{Name} is under attack");
        }
    }
}
