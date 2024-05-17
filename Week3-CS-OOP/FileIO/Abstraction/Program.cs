namespace Abstraction;


using System;

class Program
{
    static void Main(string[] args)
    {
       Dog d = new();
       d.Sleep();
       d.MakeSound();
       d.Species = "Border Collie";
       d.FavoriteChewToy = "Bone";
       d.EatMeat();

        System.Console.WriteLine("--------------");

        Cat c = new();
        c.Sleep();
        c.MakeSound();
        c.Species = "american long hair";
        c.EatMeat();
        //c.FavoriteChewToy- this doesn't work because only in dog class
        //cats don't inherit from dog class, only from Animal class

        System.Console.WriteLine("-----------");

        Bunny bugs = new();
        bugs.MakeSound();
        bugs.Sleep();
        bugs.EatPlant();
        IHerbivore b = new Bunny();
        b.EatPlant();

        Animal[] animals = new Animal[4];

        animals[0] = d;
        animals[1] = c;
        animals[2] = bugs;

        ICarnivore[] carnivores = new ICarnivore[3];

        carnivores[0] = d;
        carnivores[1] = c;
       // carnivores[2] = bugs; //not a carnivore, cannot add it to carnivore array

       IAdorable[] adorables = new IAdorable[3];

       adorables[0] = c;
       adorables[1] = bugs;

       TeddyBear teddyBear = new();
       adorables[2] = teddyBear;



    }
}
