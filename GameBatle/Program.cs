using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Sword sword = new Sword();
            sword.Name = "Dragon-Sword";
            sword.Damage = 100;
            sword.Durability = 70;
            sword.Material = "Metal";

            Sword sword2 = new Sword();
            sword2.Name = "Green-day";
            sword2.Damage = 80;
            sword2.Durability = 100;
            sword2.Material = "Metal-Grafit";

            Sword sword3 = new Sword();
            sword3.Name = "Heldock";
            sword3.Damage = 95;
            sword3.Durability = 150;
            sword3.Material = "Metal";


            Human human = new Human();
            human.Name = "Goreck";
            human.Health = 800;
            human.Loot = new ILoot[5];
            human.Weapon1 = sword;
            human.Weapon2 = sword2;

            human.Loot[0] = sword3;

            Sword sword4 = (Sword) human.Loot[0].Use();

            if (human.Debuff(10) < 0)
            {

                ILoot[] loots =  human.Destroy();
            }

        }


      

    }
}
