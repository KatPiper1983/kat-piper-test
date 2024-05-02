// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //OverloadEx();
        OverrideEx();



    }

    public static void OverrideEx()
    {
        Parent p = new();
        p.JobTitle = "Trainer";
        p.Work();

        Child c = new();
        c.JobTitle = "Student";
        c.FavoriteGame = "Minecraft";
        c.Play();
        c.Work();

        //Back to Parent
        System.Console.WriteLine(p.ToString());
        System.Console.WriteLine(c);

        //(Somewhat) Bonus Knowledge---turn back now!--- Save Yourself!
        Parent p2 = new();
        Parent p3 = p2;

        Parent pc = new Child();

        pc.JobTitle = "";
        p.Work();

        //Casting
        int num1 = (int)2.5;
        System.Console.WriteLine(num1);
        Child c2 = (Child) p;
        c2.Work();


    }


    private static void OverloadEx()
    {
        System.Console.WriteLine(Calculator.Add(4, 5));
        System.Console.WriteLine(Calculator.Add(4, 5, 6));
        System.Console.WriteLine(Calculator.Add(4.2, 5.6));


        int[] numbers = [1, 2, 3];

        System.Console.WriteLine(Calculator.Add(numbers));

        System.Console.WriteLine(Calculator.Add(3.4));
        System.Console.WriteLine(Calculator.Add(4.7, 4.3));
        System.Console.WriteLine(Calculator.Add(7.5, 8.4, 3.7));
        System.Console.WriteLine(Calculator.Add(9.4, 3.2, 8.4, 9.4));
    }
}
