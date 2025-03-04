﻿namespace GameBatle
{

    /// <summary>
    /// Абстрактный класс Добыча. Передается при разрущении обьекта
    /// </summary>
    internal interface ILoot
    {

        /// <summary>
        /// Использование добычи. Если это оружие или броня то у Unit должно поменятся значение соответствующих полей. 
        /// Если сьедобное или лечащее то прибавлятся здоровье 
        /// </summary>
        /// <param name="loot"> Обьект добычи</param>
        ILoot Use();
    }
}