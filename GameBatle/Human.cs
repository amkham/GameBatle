using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Human: Unit, IAction
    {
        private Weapon weapon1;
        private Weapon weapon2;


        internal Weapon Weapon1 { get => weapon1; set => weapon1 = value; }
        internal Weapon Weapon2 { get => weapon2; set => weapon2 = value; }

        public void Buff(int treatment)
        {
            Health += treatment;
        }

        public int Debuff(int damage)
        {
            Health -= damage;
            return Health;
        }

        public ILoot[] Destroy()
        {
            return Loot;
        }
    }
}
