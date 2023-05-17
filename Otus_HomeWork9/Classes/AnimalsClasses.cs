using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_HomeWork9
{
    /// <summary>
    /// Кот
    /// </summary>
    public class Cat : Mammals, IMyCloneable<Cat>,ICloneable
    {
        public Cat(string name, bool haveWool, double weight, bool isPredator, bool isPet, int age)
            :base(haveWool: haveWool, weight:weight, isPredator:isPredator, isPet:isPet, age:age)
        {
            Name = name;
        }

        public string Name { get; set; }

        public Cat MyClone() => new (Name,base.HaveWool,base.Weight,base.IsPredator,base.IsPet,base.Age);

        public object Clone() => MyClone();
    }
    /// <summary>
    /// Угорь
    /// </summary>
    public class Eel : Fish, IMyCloneable<Eel>, ICloneable
    {
        public Eel(bool isElectric, int finsCount, bool isFishScales, double weight, bool isPredator, bool isPet, int age)
           : base(finsCount: finsCount,isFishScales: isFishScales, weight: weight, isPredator: isPredator, isPet: isPet, age: age)
        {
            IsElectric = isElectric;
        }
        
        /// <summary>
        /// Электрический
        /// </summary>
        public bool IsElectric { get; set; }

        public Eel MyClone()
            => new(IsElectric, base.FinsCount, base.IsFishScales, base.Weight, base.IsPredator, base.IsPet, base.Age);
        public object Clone() => MyClone();

    }
    /// <summary>
    /// Попугай
    /// </summary>
    public class Parrot : Birds, IMyCloneable<Parrot>,ICloneable
    {
        public Parrot(string name, bool canFly, double weight, bool isPredator, bool isPet, int age)
            : base(canFly: canFly, weight: weight, isPredator: isPredator, isPet: isPet, age: age)
        {
            Name = name;
        }
        public string Name { get; set; }

        public Parrot MyClone() => new(Name, base.CanFly, base.Weight, base.IsPredator, base.IsPet, base.Age);
        public object Clone() => MyClone();

    }
    /// <summary>
    /// Петух
    /// </summary>
    public class Rooster : Birds, IMyCloneable<Rooster>, ICloneable
    {
        public Rooster(bool isCombat, bool canFly, double weight, bool isPredator, bool isPet, int age)
            : base(canFly: canFly, weight: weight, isPredator: isPredator, isPet: isPet, age: age)
        {
            IsCombat = isCombat;
        }
        public bool IsCombat { get; set; }

        public Rooster MyClone() => new(IsCombat, base.CanFly, base.Weight, base.IsPredator, base.IsPet, base.Age);
        public object Clone() => MyClone();
    }
}
