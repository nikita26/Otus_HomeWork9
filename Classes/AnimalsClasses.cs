using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_HomeWork9
{
    /// <summary>
    /// Кот
    /// </summary>
    public class Cat : Mammals , IMyCloneable<Cat>
    {
        public Cat(string name, bool haveWool, double weight, bool isPredator, bool isPet, int age)
            :base(haveWool: haveWool, weight:weight, isPredator:isPredator, isPet:isPet, age:age)
        {
            Name = name;
        }

        public string Name { get; set; }

        public Cat Clone()
        {
            
            return null;
        }
    }
    ///// <summary>
    ///// Угорь
    ///// </summary>
    //public class Eel : Fish
    //{
    //    public bool IsElectric { get; set; }
    //}
    ///// <summary>
    ///// Попугай
    ///// </summary>
    //public class Parrot : Birds
    //{
    //    public string Name { get; set; }
    //}
    ///// <summary>
    ///// Петух
    ///// </summary>
    //public class Rooster : Birds
    //{
    //    public bool IsCombat { get; set; }
    //}
}
