// See https://aka.ms/new-console-template for more information
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



    }
}
