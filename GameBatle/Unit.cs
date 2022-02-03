using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    /// <summary>
    /// Абстрактынй класс описывающий бойцов
    /// </summary>
    internal abstract class Unit
    {
        /// <summary>
        /// Имя персонажа
        /// </summary>
        private String _name;

        /// <summary>
        /// Колличество здоровья
        /// </summary>
        private int _health;


        /// <summary>
        /// 
        /// </summary>
        private Loot[] _loot;

    }
}
