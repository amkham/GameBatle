﻿using System;
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
        /// Предметы в рюкзаке. Если Unit не живой обькт, то расценивать как содержимое обьекта
        /// </summary>
        private ILoot[] _loot;

        public string Name { get => _name; set => _name = value; }
        public int Health { get => _health; set => _health = value; }
        internal ILoot[] Loot { get => _loot; set => _loot = value; }
    }
}
