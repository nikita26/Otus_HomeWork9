using Otus_HomeWork9;

var rooster = new Rooster(true,false,3,false,true,3);
var parrot = new Parrot("Кеша",true,0.04,false,true,5);
var eel = new Eel(true, 3, false, 15, true, false, 1);
var cat = new Cat("Муся",true,10,true,true,5);

var roosterClone = rooster.MyClone();
var parrotClone = parrot.MyClone();
var eelClone = eel.MyClone();
var catClone = cat.MyClone();

var roosterClone2 = rooster.Clone();
var parrotClone2 = parrot.Clone();
var eelClone2 = eel.Clone();
var catClone2 = cat.Clone();