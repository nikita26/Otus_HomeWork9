using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Otus_HomeWork9
{
    /// <summary>
    /// Животные
    /// </summary>
    public class Animal : IMyCloneable<Animal>
    {
        public Animal(double weight,bool isPredator,bool isPet,int age)
        {
            Weight = weight;
            IsPredator = isPredator;
            IsPet = isPet;
            Age = age;
        }
        
        /// <summary>
        /// Масса животного кг
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Является хишным
        /// </summary>
        public bool IsPredator { get; set; }
        /// <summary>
        /// Является домашним
        /// </summary>
        public bool IsPet { get; set; }
        /// <summary>
        /// Возраст животного
        /// </summary>
        public int Age { get; set; }
        public Animal Clone() => new Animal(Weight,IsPredator,IsPet,Age);
    }
    /// <summary>
    /// Млекопитающие
    /// </summary>
    public class Mammals : Animal, IMyCloneable<Mammals>
    {
        public Mammals(bool haveWool, double weight, bool isPredator, bool isPet, int age)
            :base(weight:weight,isPredator:isPredator,isPet:isPet,age:age)
        {
            HaveWool = haveWool;
        }
        /// <summary>
        /// Имеет ли шерсть
        /// </summary>
        public bool HaveWool { get; set; }

        public Mammals Clone() => new Mammals(bool haveWool, double weight, bool isPredator, bool isPet, int age)
    }

    /// <summary>
    /// Рыбы
    /// </summary>
    public class Fish : Animal
    {
        public Fish(int finsCount,bool isFishScales, double weight, bool isPredator, bool isPet, int age)
            : base(weight: weight, isPredator: isPredator, isPet: isPet, age: age)
        {
            FinsCount = finsCount;
            IsFishScales = isFishScales;
        }
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
        public Birds(bool canFly, double weight, bool isPredator, bool isPet, int age)
            : base(weight: weight, isPredator: isPredator, isPet: isPet, age: age)
        {
            CanFly = canFly;
        }
        /// <summary>
        /// Может летать
        /// </summary>
        public bool CanFly { get; set; }
    }
}
