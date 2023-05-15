using Otus_HomeWork9;

var rooster = new Rooster()
{ 
    Age = 3,
    CanFly = false,
    IsCombat = true,
    IsPet = true,
    IsPredator = false,
    Weight = 3
};
var parrot = new Parrot() { 
    Age= 2,
    CanFly = true,
    IsPet= true,
    IsPredator = false,
    Name = "Кеша",
    Weight  = 0.04
};
var acne = new Eel() { 
    IsElectric = true,
    Age = 1,
    FinsCount = 3,
    IsFishScales = false,
    IsPredator = true,
    IsPet = false,
    Weight = 15
};
var cat = new Cat() { 
    Name = "Муся",
    HaveWool = true,
    Age = 10,
    IsPet = true,
    IsPredator = true,
    Weight = 5
};


var clone = cat.Clone();

Console.ReadLine();