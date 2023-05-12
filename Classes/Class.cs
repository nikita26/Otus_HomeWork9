using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Otus_HomeWork9.Classes
{
    /// <summary>
    /// Животные
    /// </summary>
    public class Animal {
        
        /// <summary>
        /// Масса животного
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Является хишным
        /// </summary>
        public bool IsPredator { get; set; }

    }
    /// <summary>
    /// Млекопитающие
    /// </summary>
    public class Mammals : Animal
    {

    }

    /// <summary>
    /// Рыбы
    /// </summary>
    public sealed class Fish : Animal
    {
        /// <summary>
        /// Количество плавников
        /// </summary>
        public int FinsCount { get; set; }
        /// <summary>
        /// Наличие чешуи
        /// </summary>
        public bool IsFishScales { get; set; }
    }
    /// <summary>
    /// Птицы
    /// </summary>
    public class Birds : Animal
    {
        
    }

}
