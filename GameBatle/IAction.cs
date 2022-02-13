using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal interface IAction
    {
        /// <summary>
        /// Метод для описания поломки, смерти, разрущения обьекта
        /// </summary>
        ILoot[] Destroy();



        /// <summary>
        /// Метод для описания уменьшения здоровья обьекта, в последствии взаимодействия с чем-то 
        /// </summary>
        /// <param name="damage">Входящий урон</param>
        int Debuff(int damage);

        /// <summary>
        /// Метод для описания увелечения здоровья обьекта, в последствии взаимодействия с чем-то
        /// Реализовать только для живых обьектов
        /// </summary>
        /// <param name="treatment">Колличество лечения</param>
        void Buff(int treatment);
    }
}
